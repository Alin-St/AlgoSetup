using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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

            string s = "";

            foreach (string t in temp_cppAuto)
                s += t + "/";
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

            // This is for autocomplete.
            if (!temp_cppAuto.Contains(temp_cppFilename))
            {
                string[] newAuto = new string[temp_cppAuto.Length + 1];
                temp_cppAuto.CopyTo(newAuto, 0);
                newAuto[newAuto.Length - 1] = temp_cppFilename;
                Set_temp_cppAuto(newAuto);
            }

            if (!temp_inOutAuto.Contains(temp_inOutFilename))
            {
                string[] newAuto = new string[temp_inOutAuto.Length + 1];
                temp_inOutAuto.CopyTo(newAuto, 0);
                newAuto[newAuto.Length - 1] = temp_inOutFilename;
                Set_temp_inOutAuto(newAuto);
            }
        }

        private void Setup_temp_createB_Click(object sender, EventArgs e)
        {
            try
            {
                TempCreate();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error while creating the files:"); }

            // This is for autocomplete.
            if (!temp_cppAuto.Contains(temp_cppFilename))
            {
                string[] newAuto = new string[temp_cppAuto.Length + 1];
                temp_cppAuto.CopyTo(newAuto, 0);
                newAuto[newAuto.Length - 1] = temp_cppFilename;
                Set_temp_inOutAuto(newAuto);
            }

            if (!temp_inOutAuto.Contains(temp_inOutFilename))
            {
                string[] newAuto = new string[temp_inOutAuto.Length + 1];
                temp_inOutAuto.CopyTo(newAuto, 0);
                newAuto[newAuto.Length - 1] = temp_inOutFilename;
                Set_temp_cppAuto(newAuto);
            }
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

            // This is for autocomplete.
            if (!archive_cppAuto.Contains(archive_cppFilename))
            {
                string[] newAuto = new string[archive_cppAuto.Length + 1];
                archive_cppAuto.CopyTo(newAuto, 0);
                newAuto[newAuto.Length - 1] = archive_cppFilename;
                Set_archive_cppAuto(newAuto);
            }

            if (!archive_folderAuto.Contains(archive_folder))
            {
                string[] newAuto = new string[archive_folderAuto.Length + 1];
                archive_folderAuto.CopyTo(newAuto, 0);
                newAuto[newAuto.Length - 1] = archive_folder;
                Set_archive_folderAuto(newAuto);
            }
        }

        private void Setup_archive_createB_Click(object sender, EventArgs e)
        {
            try
            {
                ArchiveCreate();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error while creating the files:"); }

            // This is for autocomplete.
            if (!archive_cppAuto.Contains(archive_cppFilename))
            {
                string[] newAuto = new string[archive_cppAuto.Length + 1];
                archive_cppAuto.CopyTo(newAuto, 0);
                newAuto[newAuto.Length - 1] = archive_cppFilename;
                Set_archive_cppAuto(newAuto);
            }

            if (!archive_folderAuto.Contains(archive_folder))
            {
                string[] newAuto = new string[archive_folderAuto.Length + 1];
                archive_folderAuto.CopyTo(newAuto, 0);
                newAuto[newAuto.Length - 1] = archive_folder;
                Set_archive_folderAuto(newAuto);
            }
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
            Set_saveAutocomplete(pref_saveDataForAutocompleteCB.Checked);
        }
    }
}
