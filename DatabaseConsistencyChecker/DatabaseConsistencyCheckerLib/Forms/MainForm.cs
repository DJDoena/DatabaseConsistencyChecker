﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DoenaSoft.DVDProfiler.DVDProfilerHelper;
using DoenaSoft.DVDProfiler.DVDProfilerXML.Version400;
using DoenaSoft.ToolBox.Generics;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_2;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class MainForm : Form
    {
        private Collection _collection;

        private Config.CheckConfiguration _configuration;

        public string CollectionFile { get; private set; }

        public string ConfigurationFile { get; private set; }

        public string IgnoreFile { get; private set; }

        private Ignore.IgnoreConfiguration _ignore;

        public MainForm() : this(null, null, null, null)
        {
        }

        public MainForm(Collection collection, string collectionFile, string configurationFile, string ignoreFile)
        {
            _collection = collection;
            this.CollectionFile = collectionFile;
            this.ConfigurationFile = configurationFile;
            this.IgnoreFile = ignoreFile;
            _configuration = null;
            _ignore = null;

            InitializeComponent();

            Icon = Properties.Resources.DJDSOFT;

            if (collection != null)
            {
                LoadCollectionButton.Enabled = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(collectionFile) && File.Exists(collectionFile))
                {
                    try
                    {
                        TryLoadCollection(collectionFile);
                    }
                    catch
                    { }
                }
            }

            if (!string.IsNullOrEmpty(configurationFile) && File.Exists(configurationFile))
            {
                try
                {
                    TryLoadConfiguration(configurationFile, true);
                }
                catch
                { }
            }

            if (!string.IsNullOrEmpty(ignoreFile) && File.Exists(ignoreFile))
            {
                try
                {
                    TryLoadIgnore(ignoreFile, true);
                }
                catch
                { }
            }

            SwitchButtons();

            var toolTip = new ToolTip()
            {
                AutoPopDelay = 10000,
                InitialDelay = 1000,
                ReshowDelay = 1000,
                IsBalloon = true,
                ShowAlways = false,
                ToolTipIcon = ToolTipIcon.Info,
                ToolTipTitle = "Ignore",
            };

            const string ToolTipText = "The ignore feature is for profiles that fail the check but will never be successful either.";

            toolTip.SetToolTip(IgnoreFileLabel, ToolTipText);
            toolTip.SetToolTip(IgnoreFileTextBox, ToolTipText);
            toolTip.SetToolTip(LoadIgnoreButton, ToolTipText);
            toolTip.SetToolTip(ClearIgnoreButton, ToolTipText);
            toolTip.SetToolTip(IgnoresLoadedLabel, ToolTipText);
        }

        private IEnumerable<ListViewItem> GetResults(bool mustBeChecked)
        {
            var results = ResultListView.Items.OfType<ListViewItem>();

            if (mustBeChecked)
            {
                results = results.Where(item => item.Checked);
            }

            return results;
        }

        private void SwitchButtons()
        {
            EditConfigurationButton.Enabled = _configuration != null;

            RunChecksButton.Enabled = _collection != null && _configuration != null;

            var hasResults = GetResults(false).Any();

            var hasCheckedResults = GetResults(true).Any();

            ExportAllProfilesFlagSetButton.Enabled = hasResults;
            ExportCheckedProfilesFlagSetButton.Enabled = hasCheckedResults;

            IgnoreCheckedProfilesButton.Enabled = hasCheckedResults;
        }

        private void ClearResults()
        {
            NewMethod();

            try
            {
                ResultListView.Items.Clear();
            }
            finally
            {
                ResultListView.ItemChecked += OnResultListViewItemChecked;
            }
        }

        private void NewMethod()
        {
            ResultListView.ItemChecked -= OnResultListViewItemChecked;
        }

        private static void TryExecute(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnLoadCollectionButtonClick(object sender, EventArgs e)
        {
            TryExecute(LoadCollection);
        }

        private void LoadCollection()
        {
            using (var ofd = new OpenFileDialog()
            {
                CheckFileExists = true,
                Filter = "Collection file|*.xml",
                Multiselect = false,
                RestoreDirectory = true,
                Title = "Please select your collection XML file",
            })
            {
                if (!string.IsNullOrEmpty(CollectionFile) && File.Exists(CollectionFile))
                {
                    var fi = new FileInfo(CollectionFile);

                    ofd.InitialDirectory = fi.DirectoryName;
                    ofd.FileName = fi.Name;
                }

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TryLoadCollection(ofd.FileName);

                    CollectionFile = ofd.FileName;

                    SwitchButtons();

                    ClearResults();
                }
            }
        }

        private void TryLoadCollection(string fileName)
        {
            _collection = XmlSerializer<Collection>.Deserialize(fileName);

            CollectionFileTextBox.Text = fileName;

            var profileCount = _collection.DVDList?.Length ?? 0;

            ProfilesLoadedLabel.Text = $"{profileCount:#,0} profiles loaded.";
        }

        private void OnLoadConfigurationButtonClick(object sender, EventArgs e)
        {
            TryExecute(LoadConfiguration);
        }

        private void LoadConfiguration()
        {
            using (var ofd = new OpenFileDialog()
            {
                CheckFileExists = true,
                Filter = "Configuration file|*.xml",
                Multiselect = false,
                RestoreDirectory = true,
                Title = "Please select your configuration file",
            })
            {

                if (!string.IsNullOrEmpty(ConfigurationFile) && File.Exists(ConfigurationFile))
                {
                    var fi = new FileInfo(ConfigurationFile);

                    ofd.InitialDirectory = fi.DirectoryName;
                    ofd.FileName = fi.Name;
                }

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TryLoadConfiguration(ofd.FileName, false);

                    ConfigurationFile = ofd.FileName;

                    SwitchButtons();

                    ClearResults();
                }
            }
        }

        private void TryLoadConfiguration(string fileName, bool silent)
        {
            _configuration = ConfigurationHelper.Load(fileName, silent);

            if (_configuration != null)
            {
                ConfigurationFileTextBox.Text = fileName;

                var ruleCount = _configuration.Rule?.Length ?? 0;

                RulesLoadedLabel.Text = $"{ruleCount:#,0} rules loaded.";
            }
            else
            {
                ConfigurationFileTextBox.Text = string.Empty;

                RulesLoadedLabel.Text = string.Empty;
            }
        }

        private void TryLoadIgnore(string fileName, bool silent)
        {
            try
            {
                _ignore = XmlSerializer<Ignore.IgnoreConfiguration>.Deserialize(fileName);
            }
            catch
            {
                if (!silent)
                {
                    MessageBox.Show("The ignore file cannot be read.", "Read error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                _ignore = null;
            }

            if (_ignore != null)
            {
                IgnoreFileTextBox.Text = fileName;

                UpdateIgnoreLabel();
            }
            else
            {
                IgnoreFileTextBox.Text = string.Empty;

                IgnoresLoadedLabel.Text = string.Empty;
            }
        }

        private void OnEditConfigurationButtonClick(object sender, EventArgs e)
        {
            TryExecute(EditConfiguration);
        }

        private void EditConfiguration()
        {
            var copy = _configuration.Clone();

            using (var form = new ConfigurationForm(copy))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveConfiguration(copy, ConfigurationFileTextBox.Text);
                }
            }
        }

        private void SaveConfiguration(Config.CheckConfiguration configuration, string fileName)
        {
            ConfigurationHelper.Save(configuration, fileName);

            _configuration = configuration;

            ConfigurationFileTextBox.Text = fileName;

            ConfigurationFile = fileName;

            SwitchButtons();

            ClearResults();
        }

        private void OnNewConfigurationButtonClick(object sender, EventArgs e)
        {
            TryExecute(CreateNewConfiguration);
        }

        private void CreateNewConfiguration()
        {
            var newItem = new Config.CheckConfiguration();

            using (var form = new ConfigurationForm(newItem))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    TrySaveNewConfiguration(newItem);
                }
            }
        }

        private void TrySaveNewConfiguration(Config.CheckConfiguration newItem)
        {
            using (var sfd = new SaveFileDialog()
            {
                CheckPathExists = true,
                Filter = "Configuration file|*.xml",
                OverwritePrompt = true,
                RestoreDirectory = true,
                Title = "Please select a destination for your configuration file",
                ValidateNames = true,
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SaveConfiguration(newItem, sfd.FileName);
                }
                else
                {
                    var confirmation = MessageBox.Show("Your configuration will be lost. Really continue without saving?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmation == DialogResult.No)
                    {
                        TrySaveNewConfiguration(newItem);
                    }
                    else
                    {
                        //close & discard
                    }
                }
            }
        }

        private void OnRunChecksButtonClick(object sender, EventArgs e)
        {
            TryExecute(RunChecks);
        }

        private void RunChecks()
        {
            if (_configuration?.Rule == null || _configuration.Rule.Length == 0)
            {
                MessageBox.Show("The configuration does not contain any rules!", "No rules", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            else if (_collection?.DVDList == null || _collection.DVDList.Length == 0)
            {
                MessageBox.Show("The collection does not contain any profiles!", "No profiles", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            ClearResults();

            ResultListView.ItemChecked -= OnResultListViewItemChecked;

            try
            {
                var ruleChecker = new RuleChecker(_collection);

                foreach (var rule in _configuration.Rule)
                {
                    var allResults = ruleChecker.Check(rule);

                    var invalidResults = allResults.Where(result => !result.Success);

                    foreach (var result in invalidResults)
                    {
                        foreach (var profile in result.FailedProfiles.OrderBy(p => p.SortTitle))
                        {
                            var row = new ListViewItem(new[] { rule.Name, result.Check.Name, profile.ToString() })
                            {
                                Tag = profile,
                            };

                            ResultListView.Items.Add(row);
                        }
                    }
                }

                ApplyResultIgnores();

                SwitchButtons();
            }
            finally
            {
                ResultListView.ItemChecked += OnResultListViewItemChecked;
            }
        }

        private void OnExportAllProfilesFlagSetButtonClick(object sender, EventArgs e)
        {
            TryExecute(() => ExportAllProfilesFlagSet(true));
        }

        private void ExportAllProfilesFlagSet(bool all)
        {
            using (var sfd = new SaveFileDialog()
            {
                CheckPathExists = true,
                Filter = "Flag set file|*.lst",
                OverwritePrompt = true,
                RestoreDirectory = true,
                Title = "Please select a destination for your flag set file",
                ValidateNames = true,
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SaveFlagSet(sfd.FileName, all);
                }
            }
        }

        private void SaveFlagSet(string fileName, bool all)
        {
            using (var sw = new StreamWriter(fileName, false, Encoding.GetEncoding("Windows-1252")))
            {
                foreach (var row in GetResults(!all))
                {
                    var profile = (DVD)row.Tag;

                    sw.WriteLine(profile.ID);
                }
            }
        }

        private void OnSaveConfigurationButtonClick(object sender, EventArgs e)
        {
            TryExecute(SaveConfiguration);
        }

        private void SaveConfiguration()
        {
            using (var sfd = new SaveFileDialog()
            {
                CheckPathExists = true,
                FileName = ConfigurationFileTextBox.Text,
                Filter = "Configuration file|*.xml",
                OverwritePrompt = true,
                RestoreDirectory = true,
                Title = "Please select a destination for your configuration file",
                ValidateNames = true,
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SaveConfiguration(_configuration, sfd.FileName);
                }
            }
        }

        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnCheckForUpdatesToolStripMenuItemClick(object sender, EventArgs e)
        {
            OnlineAccess.CheckForNewVersion("http://doena-soft.de/dvdprofiler/3.9.0/versions.xml", new WindowHandle(), "Database Consistency Checker", GetType().Assembly);
        }

        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (var aboutBox = new AboutBox(GetType().Assembly))
            {
                aboutBox.ShowDialog();
            }
        }

        private void OnExportCheckedProfilesFlagSetButtonClick(object sender, EventArgs e)
        {
            TryExecute(() => ExportAllProfilesFlagSet(false));
        }

        private void OnLoadIgnoreButtonClick(object sender, EventArgs e)
        {
            TryExecute(LoadIgnore);
        }

        private void LoadIgnore()
        {
            using (var ofd = new OpenFileDialog()
            {
                CheckFileExists = true,
                Filter = "Ignore file|*.xml",
                Multiselect = false,
                RestoreDirectory = true,
                Title = "Please select your ignore file",
            })
            {
                if (!string.IsNullOrEmpty(IgnoreFile) && File.Exists(IgnoreFile))
                {
                    var fi = new FileInfo(IgnoreFile);

                    ofd.InitialDirectory = fi.DirectoryName;
                    ofd.FileName = fi.Name;
                }

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TryLoadIgnore(ofd.FileName, false);

                    IgnoreFile = ofd.FileName;

                    SwitchButtons();

                    ClearResults();
                }
            }
        }

        private void UpdateIgnoreLabel()
        {
            var profileCount = _ignore?.Rule?.SelectMany(r => r?.Check?.SelectMany(c => c?.Profile))?.Count(p => p != null) ?? 0;

            IgnoresLoadedLabel.Text = $"{profileCount:#,0} profiles ignored.";
        }

        private void ApplyResultIgnores()
        {
            if (_ignore == null)
            {
                return;
            }

            for (var rowIndex = ResultListView.Items.Count - 1; rowIndex >= 0; rowIndex--)
            {
                var row = ResultListView.Items[rowIndex];

                var ruleName = row.SubItems[0].Text;

                var rule = _ignore.Rule?.FirstOrDefault(r => r.Name == ruleName);

                if (rule == null)
                {
                    continue;
                }

                var checkName = row.SubItems[1].Text;

                var check = rule.Check?.FirstOrDefault(c => c.Name == checkName);

                if (check == null)
                {
                    continue;
                }

                var originalProfile = (DVD)row.Tag;

                var profile = check.Profile?.FirstOrDefault(p => p.ID == originalProfile.ID);

                if (profile != null)
                {
                    ResultListView.Items.RemoveAt(rowIndex);
                }
            }
        }

        private void OnClearIgnoreButtonClick(object sender, EventArgs e)
        {
            TryExecute(ClearIgnore);
        }

        private void ClearIgnore()
        {
            if (_ignore == null)
            {
                return;
            }

            _ignore = new Ignore.IgnoreConfiguration();

            if (string.IsNullOrEmpty(IgnoreFileTextBox.Text))
            {
                SaveIgnore();
            }
            else
            {
                SaveIgnore(IgnoreFileTextBox.Text);
            }
        }

        private void SaveIgnore()
        {
            using (var sfd = new SaveFileDialog()
            {
                CheckPathExists = true,
                FileName = IgnoreFileTextBox.Text,
                Filter = "Ignore file|*.xml",
                OverwritePrompt = true,
                RestoreDirectory = true,
                Title = "Please select a destination for your ignore file",
                ValidateNames = true,
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SaveIgnore(sfd.FileName);
                }
            }
        }

        private void SaveIgnore(string fileName)
        {
            XmlSerializer<Ignore.IgnoreConfiguration>.Serialize(fileName, _ignore);

            IgnoreFileTextBox.Text = fileName;

            IgnoreFile = fileName;

            UpdateIgnoreLabel();
        }

        private void OnIgnoreCheckedProfilesButtonClick(object sender, EventArgs e)
        {
            TryExecute(IgnoreCheckedProfiles);
        }

        private void IgnoreCheckedProfiles()
        {
            ResultListView.ItemChecked -= OnResultListViewItemChecked;

            try
            {
                if (_ignore == null)
                {
                    _ignore = new Ignore.IgnoreConfiguration();
                }

                var rules = (_ignore.Rule ?? Enumerable.Empty<Ignore.Rule>()).ToList();

                foreach (var row in GetResults(true))
                {
                    IgnoreProfile(rules, row);
                }

                _ignore.Rule = rules.ToArray();

                if (string.IsNullOrEmpty(IgnoreFileTextBox.Text))
                {
                    SaveIgnore();
                }
                else
                {
                    SaveIgnore(IgnoreFileTextBox.Text);
                }

                SwitchButtons();

                ApplyResultIgnores();
            }
            finally
            {
                ResultListView.ItemChecked += OnResultListViewItemChecked;
            }
        }

        private static void IgnoreProfile(List<Ignore.Rule> rules, ListViewItem row)
        {
            var ruleName = row.SubItems[0].Text;

            var rule = rules.FirstOrDefault(r => r.Name == ruleName);

            if (rule == null)
            {
                rule = new Ignore.Rule()
                {
                    Name = ruleName,
                };

                rules.Add(rule);
            }

            var checks = (rule.Check ?? Enumerable.Empty<Ignore.Check>()).ToList();

            var checkName = row.SubItems[1].Text;

            var check = checks.FirstOrDefault(c => c.Name == checkName);

            if (check == null)
            {
                check = new Ignore.Check()
                {
                    Name = checkName,
                };

                checks.Add(check);
            }

            var profiles = (check.Profile ?? Enumerable.Empty<Ignore.Profile>()).ToList();

            var originalProfile = (DVD)row.Tag;

            profiles.Add(new Ignore.Profile()
            {
                ID = originalProfile.ID,
                ID_VariantNum = originalProfile.ID_VariantNum,
                ID_LocalityDesc = originalProfile.ID_LocalityDesc,
                ID_Type = (Ignore.ProfileID_Type)originalProfile.ID_Type,
                UPC = originalProfile.UPC,
                Title = originalProfile.Title,
                Edition = originalProfile.Edition,
                OriginalTitle = originalProfile.OriginalTitle,
            });

            check.Profile = profiles.ToArray();

            rule.Check = checks.ToArray();
        }

        private void OnResultListViewItemChecked(object sender, ItemCheckedEventArgs e)
        {
            SwitchButtons();
        }
    }
}