using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AlgoSetup
{
    public partial class MainForm : Form
    {
        // Main Form.
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error while loading data:"); }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SaveData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error while saving data:"); }
        }

        // Temp.
        private void Setup_temp_cppFilenameTB_TextChanged(object sender, EventArgs e)
        {
            string text = setup_temp_cppFilenameTB.Text;

            if (ValidFilename(text))
            {
                Set_temp_cppFilename(text);
                setup_temp_cppFilenameTB.BackColor = DefaultBackColor;
            }
            else setup_temp_cppFilenameTB.BackColor = Color.IndianRed;
        }

        private void Setup_temp_inOutFilesCB_CheckedChanged(object sender, EventArgs e)
        {
            Set_temp_inOutFiles(setup_temp_inOutFilesCB.Checked);
        }

        private void Setup_temp_inOutFilenameTB_TextChanged(object sender, EventArgs e)
        {
            string text = setup_temp_inOutFilenameTB.Text;

            if (ValidFilename(text))
            {
                Set_temp_inOutFilename(text);
                setup_temp_inOutFilenameTB.BackColor = DefaultBackColor;
            }
            else setup_temp_inOutFilenameTB.BackColor = Color.IndianRed;
        }

        private void Setup_temp_openB_Click(object sender, EventArgs e)
        {
            try
            {
                TempOpen();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error while opening the files:"); }
        }

        private void Setup_temp_createB_Click(object sender, EventArgs e)
        {
            try
            {
                TempCreate();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error while creating the files:"); }
        }

        // Archive.
        private void Setup_archive_cppFilenameTB_TextChanged(object sender, EventArgs e)
        {
            string text = setup_archive_cppFilenameTB.Text;

            if (ValidFilename(text))
            {
                Set_archive_cppFilename(text);
                setup_archive_cppFilenameTB.BackColor = DefaultBackColor;
            }
            else setup_archive_cppFilenameTB.BackColor = Color.IndianRed;
        }

        private void Setup_archive_inOutFilesCB_CheckedChanged(object sender, EventArgs e)
        {
            Set_archive_inOutFiles(setup_archive_inOutFilesCB.Checked);
        }

        private void Setup_archive_folderTB_TextChanged(object sender, EventArgs e)
        {
            string text = setup_archive_folderTB.Text;

            if (ValidFilename(text))
            {
                Set_archive_folder(text);
                setup_archive_folderTB.BackColor = DefaultBackColor;
            }
            else setup_archive_folderTB.BackColor = Color.IndianRed;
        }

        private void Setup_archive_openB_Click(object sender, EventArgs e)
        {
            try
            {
                ArchiveOpen();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error while opening the files:"); }
        }

        private void Setup_archive_createB_Click(object sender, EventArgs e)
        {
            try
            {
                ArchiveCreate();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error while creating the files:"); }
        }

        // Preferences.
        private void Pref_tempSetupFolderL_Click(object sender, EventArgs e)
        {
            try
            {
                var process = Process.Start(tempRootFolder);
                process?.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error while opening the folder:"); }
        }

        private void Pref_tempSetupFolderB_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.SelectedPath = tempRootFolder;
                
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Set_tempRootFolder(dialog.SelectedPath);
                }
            }
        }

        private void Pref_archiveSetupFolderL_Click(object sender, EventArgs e)
        {
            try
            {
                var process = Process.Start(archiveRootFolder);
                process?.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error while opening the folder:"); }
        }

        private void Pref_archiveSetupFolderB_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.SelectedPath = archiveRootFolder;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Set_archiveRootFolder(dialog.SelectedPath);
                }
            }
        }

        private void Pref_openAfterCreateCB_CheckedChanged(object sender, EventArgs e)
        {
            Set_openAfterCreate(pref_openAfterCreateCB.Checked);
        }

        private void Pref_exitAfterOpenCreateCB_CheckedChanged(object sender, EventArgs e)
        {
            Set_exitAfterOpenCreate(pref_exitAfterOpenCreateCB.Checked);
        }

        private void Pref_editStartCodeB_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Application.LocalUserAppDataPath, START_CODE_FOLDER);
                Directory.CreateDirectory(path);

                var process = Process.Start(path);
                process?.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error while opening the Start Code folder:"); }
        }

        private void Pref_openPrefFolderB_Click(object sender, EventArgs e)
        {
            try
            {
                var process = Process.Start(Application.LocalUserAppDataPath);
                process?.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error while opening preferences folder:"); }
        }

        private void Pref_openFilesWithTB_TextChanged(object sender, EventArgs e)
        {
            Set_openWith(pref_openFilesWithTB.Text);
        }

        private void Pref_saveDataForAutocompleteCB_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
