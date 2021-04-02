using System;
using System.IO;
using System.Windows.Forms;

namespace AlgoSetup
{
    partial class MainForm
    {
        // Temp.
        string temp_cppFilename = "main";
        bool temp_inOutFiles = true;
        string temp_inOutFilename = "problem";

        // Archive.
        string archive_cppFilename = "problem";
        bool archive_inOutFiles = true;
        string archive_folder = "Problem";

        // Preferences.
        string tempRootFolder = @"C:\";
        string archiveRootFolder = @"C:\";
        bool openAfterCreate = true;
        bool exitAfterOpenCreate = true;
        string openWith = "explorer";
        bool saveAutocomplete = true;

        // Autocomplete.
        string[] temp_cppAuto = new string[0];
        string[] temp_inOutAuto = new string[0];
        string[] archive_cppAuto = new string[0];
        string[] archive_folderAuto = new string[0];

        // Temp.
        void Set_temp_cppFilename(string value)
        {
            setup_temp_cppFilenameTB.Text = value;
            temp_cppFilename = value;
            UpdateOpenCreateEnabled();
        }

        void Set_temp_inOutFiles(bool value)
        {
            setup_temp_inOutFilesCB.Checked = value;
            setup_temp_inOutFilenameL.Enabled = value;
            setup_temp_inOutFilenameTB.Enabled = value;
            temp_inOutFiles = value;
            UpdateOpenCreateEnabled();
        }

        void Set_temp_inOutFilename(string value)
        {
            setup_temp_inOutFilenameTB.Text = value;
            temp_inOutFilename = value;
            UpdateOpenCreateEnabled();
        }

        // Archive.
        void Set_archive_cppFilename(string value)
        {
            string oldFilename = archive_cppFilename;

            setup_archive_cppFilenameTB.Text = value;
            archive_cppFilename = value;
            UpdateOpenCreateEnabled();

            if (setup_archive_folderTB.Text == oldFilename)
                Set_archive_folder(value);
        }

        void Set_archive_inOutFiles(bool value)
        {
            setup_archive_inOutFilesCB.Checked = value;
            archive_inOutFiles = value;
            UpdateOpenCreateEnabled();
        }

        void Set_archive_folder(string value)
        {
            setup_archive_folderTB.Text = value;
            archive_folder = value;
            UpdateOpenCreateEnabled();
        }

        // Preferences.
        void Set_tempRootFolder(string value)
        {
            pref_tempSetupFolderB.Text = value;
            tempRootFolder = value;
            UpdateOpenCreateEnabled();
        }

        void Set_archiveRootFolder(string value)
        {
            pref_archiveSetupFolderB.Text = value;
            archiveRootFolder = value;
            UpdateOpenCreateEnabled();
        }

        void Set_openAfterCreate(bool value)
        {
            pref_openAfterCreateCB.Checked = value;
            openAfterCreate = value;
        }

        void Set_exitAfterOpenCreate(bool value)
        {
            pref_exitAfterOpenCreateCB.Checked = value;
            exitAfterOpenCreate = value;
        }

        void Set_openWith(string value)
        {
            pref_openFilesWithTB.Text = value;
            openWith = value;
        }

        void Set_saveAutocomplete(bool value)
        {
            pref_saveDataForAutocompleteCB.Checked = value;
            saveAutocomplete = value;
        }

        // Autocomplete.
        void Set_temp_cppAuto(string[] value)
        {
            setup_temp_cppFilenameTB.AutoCompleteCustomSource.Clear();
            setup_temp_cppFilenameTB.AutoCompleteCustomSource.AddRange(value);
            temp_cppAuto = value;
        }

        void Set_temp_inOutAuto(string[] value)
        {
            setup_temp_inOutFilenameTB.AutoCompleteCustomSource.Clear();
            setup_temp_inOutFilenameTB.AutoCompleteCustomSource.AddRange(value);
            temp_inOutAuto = value;
        }

        void Set_archive_cppAuto(string[] value)
        {
            setup_archive_cppFilenameTB.AutoCompleteCustomSource.Clear();
            setup_archive_cppFilenameTB.AutoCompleteCustomSource.AddRange(value);
            archive_cppAuto = value;
        }

        void Set_archive_folderAuto(string[] value)
        {
            setup_archive_folderTB.AutoCompleteCustomSource.Clear();
            setup_archive_folderTB.AutoCompleteCustomSource.AddRange(value);
            archive_folderAuto = value;
        }

        /// <summary> This method must be called when the root folders change or anything that might break the paths for Open / Create. </summary>
        void UpdateOpenCreateEnabled()
        {
            // Temp.
            string path = Path.Combine(tempRootFolder, temp_cppFilename);
            setup_temp_openB.Enabled = File.Exists(path + ".cpp");

            path = Path.Combine(tempRootFolder, temp_inOutFilename);
            if (temp_inOutFiles && (!File.Exists(path + ".in") || !File.Exists(path + ".out")))
                setup_temp_openB.Enabled = false;

            setup_temp_createB.Enabled = Directory.Exists(tempRootFolder);

            // Archive.
            path = Path.Combine(archiveRootFolder, archive_folder, archive_cppFilename);
            setup_archive_openB.Enabled = File.Exists(path + ".cpp");

            if (archive_inOutFiles && (!File.Exists(path + ".in") || !File.Exists(path + ".out")))
                setup_archive_openB.Enabled = false;

            setup_archive_createB.Enabled = Directory.Exists(archiveRootFolder);
        }
    }
}
