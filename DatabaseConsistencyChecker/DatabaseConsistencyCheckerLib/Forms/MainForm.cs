using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration;
using DoenaSoft.DVDProfiler.DVDProfilerHelper;
using DoenaSoft.DVDProfiler.DVDProfilerXML.Version400;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class MainForm : Form
    {
        private Collection _collection;

        private CheckConfiguration _configuration;

        public MainForm() : this(null)
        {
        }

        public MainForm(Collection collection)
        {
            _collection = collection;

            if (Properties.Settings.Default.UpgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeRequired = false;
                Properties.Settings.Default.Save();
            }

            InitializeComponent();

            if (collection != null)
            {
                LoadCollectionButton.Enabled = false;
            }
            else
            {
                var collectionFile = Properties.Settings.Default.CollectionFile;

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

            var configurationFile = Properties.Settings.Default.ConfigurationFile;

            if (!string.IsNullOrEmpty(configurationFile) && File.Exists(configurationFile))
            {
                try
                {
                    TryLoadConfiguration(configurationFile);
                }
                catch
                { }
            }

            SwitchButtons();
        }

        private void SwitchButtons()
        {
            EditConfigurationButton.Enabled = _configuration != null;

            RunChecksButton.Enabled = _collection != null && _configuration != null;

            ExportFlagSetButton.Enabled = ResultListView.Items.Count > 0;
        }

        private void ClearResults()
        {
            ResultListView.Items.Clear();
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
                var collectionFile = Properties.Settings.Default.CollectionFile;

                if (!string.IsNullOrEmpty(collectionFile) && File.Exists(collectionFile))
                {
                    var fi = new FileInfo(collectionFile);

                    ofd.InitialDirectory = fi.DirectoryName;
                    ofd.FileName = fi.Name;
                }

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TryLoadCollection(ofd.FileName);

                    Properties.Settings.Default.CollectionFile = ofd.FileName;
                    Properties.Settings.Default.Save();

                    SwitchButtons();

                    ClearResults();
                }
            }
        }

        private void TryLoadCollection(string fileName)
        {
            _collection = DVDProfilerSerializer<Collection>.Deserialize(fileName);

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
                var configurationFile = Properties.Settings.Default.ConfigurationFile;

                if (!string.IsNullOrEmpty(configurationFile) && File.Exists(configurationFile))
                {
                    var fi = new FileInfo(configurationFile);

                    ofd.InitialDirectory = fi.DirectoryName;
                    ofd.FileName = fi.Name;
                }

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TryLoadConfiguration(ofd.FileName);

                    Properties.Settings.Default.ConfigurationFile = ofd.FileName;
                    Properties.Settings.Default.Save();


                    SwitchButtons();

                    ClearResults();
                }
            }
        }

        private void TryLoadConfiguration(string fileName)
        {
            _configuration = DVDProfilerSerializer<CheckConfiguration>.Deserialize(fileName);

            ConfigurationFileTextBox.Text = fileName;

            var ruleCount = _configuration.Rule?.Length ?? 0;

            RulesLoadedLabel.Text = $"{ruleCount:#,0} rules loaded.";
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

        private void SaveConfiguration(CheckConfiguration configuration, string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    DVDProfilerSerializer<CheckConfiguration>.Serialize(xtw, configuration);
                }
            }

            _configuration = configuration;

            ConfigurationFileTextBox.Text = fileName;

            SwitchButtons();

            ClearResults();
        }

        private void OnNewConfigurationButtonClick(object sender, EventArgs e)
        {
            TryExecute(CreateNewConfiguration);
        }

        private void CreateNewConfiguration()
        {
            var newItem = new CheckConfiguration();

            using (var form = new ConfigurationForm(newItem))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    TrySaveNewConfiguration(newItem);
                }
            }
        }

        private void TrySaveNewConfiguration(CheckConfiguration newItem)
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

            var ruleChecker = new RuleChecker(_collection);

            foreach (var rule in _configuration.Rule)
            {
                var allResults = ruleChecker.Check(rule);

                var invalidResults = allResults.Where(result => !result.Success);

                foreach (var result in invalidResults)
                {
                    foreach (var profile in result.FailedProfiles)
                    {
                        var row = new ListViewItem(new[] { rule.Name, result.Check.Name, profile.ToString() })
                        {
                            Tag = profile,
                        };

                        ResultListView.Items.Add(row);
                    }
                }
            }

            SwitchButtons();
        }

        private void OnExportFlagSetButtonClick(object sender, EventArgs e)
        {
            TryExecute(ExportFlagSet);
        }

        private void ExportFlagSet()
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
                    SaveFlagSet(sfd.FileName);
                }
            }
        }

        private void SaveFlagSet(string fileName)
        {
            using (var sw = new StreamWriter(fileName, false, Encoding.GetEncoding("Windows-1252")))
            {
                foreach (ListViewItem row in ResultListView.Items)
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
    }
}