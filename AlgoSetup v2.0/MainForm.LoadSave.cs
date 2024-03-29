﻿using AlgoSetup.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace AlgoSetup
{
    partial class MainForm
    {
        const string PREF_FILENAME = "preferences.algosetup";
        const string AUTOCOMPLETE_FILENAME = "autocomplete.algosetup";
        const string START_CODE_FOLDER = "Start Code";
        const string START_CODE_TEMP_FILENAME = "startcode_temp.txt";
        const string START_CODE_TEMP_INOUT_FILENAME = "startcode_temp_inout.txt";
        const string START_CODE_ARCHIVE_FILENAME = "startcode_archive.txt";
        const string START_CODE_ARCHIVE_INOUT_FILENAME = "startcode_archive_inout.txt";

        /// <summary> Method called on MainForm_Load, to work on everything that is needed on App startup, related to loading data. </summary>
        void LoadData()
        {
            // Create folders for Temp and Archive inside the .exe folder.
            string path = Path.Combine(Application.StartupPath, "Temp");
            Directory.CreateDirectory(path);

            path = Path.Combine(Application.StartupPath, "Archive");
            Directory.CreateDirectory(path);

            // Load pref and autocomplete files if they exists, else set everything to default.
            path = Path.Combine(Application.LocalUserAppDataPath, PREF_FILENAME);
            if (File.Exists(path)) {
                try { LoadPref(); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error:"); }
            }
            else SetDefaultPref();

            path = Path.Combine(Application.LocalUserAppDataPath, AUTOCOMPLETE_FILENAME);
            if (File.Exists(path)) {
                try { LoadAutocomplete(); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error:"); }
            }
            else
            {
                Set_temp_cppAuto(new string[0]);
                Set_temp_inOutAuto(new string[0]);
                Set_archive_cppAuto(new string[0]);
                Set_archive_folderAuto(new string[0]);
            }

            // Create the default Start Code files if they don't exist (probably because it is the first time the app is started).
            path = Path.Combine(Application.LocalUserAppDataPath, START_CODE_FOLDER);

            Directory.CreateDirectory(path);

            if (!File.Exists(Path.Combine(path, START_CODE_TEMP_FILENAME))) {
                try { CreateTempStartcode(); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error:"); }
            }

            if (!File.Exists(Path.Combine(path, START_CODE_TEMP_INOUT_FILENAME))) {
                try { CreateTempInoutStartcode(); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error:"); }
            }

            if (!File.Exists(Path.Combine(path, START_CODE_ARCHIVE_FILENAME))) {
                try { CreateArchiveStartcode(); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error:"); }
            }

            if (!File.Exists(Path.Combine(path, START_CODE_ARCHIVE_INOUT_FILENAME))) {
                try { CreateArchiveInoutStartcode(); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error:"); }
            }
        }

        /// <summary> Method called on MainForm_Close, to work on everything that is needed on App closing, related to saving data. </summary>
        void SaveData()
        {
            try { SavePref(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error:"); }

            try { SaveAutocomplete(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error:"); }
        }

        /// <summary> Just for loading the data inside preferences.algosetup. </summary>
        void LoadPref()
        {
            string path = Path.Combine(Application.LocalUserAppDataPath, PREF_FILENAME);
            using (var fin = new StreamReader(path))
            {
                string s;
                while ((s = fin.ReadLine()) != null)
                {
                    // Temp.
                    if (s == nameof(temp_cppFilename))
                    {
                        s = fin.ReadLine();
                        Set_temp_cppFilename(s);
                    }
                    else if (s == nameof(temp_inOutFiles))
                    {
                        s = fin.ReadLine();
                        Set_temp_inOutFiles(bool.Parse(s));
                    }
                    else if (s == nameof(temp_inOutFilename))
                    {
                        s = fin.ReadLine();
                        Set_temp_inOutFilename(s);
                    }

                    // Archive.
                    else if (s == nameof(archive_cppFilename))
                    {
                        s = fin.ReadLine();
                        Set_archive_cppFilename(s);
                    }
                    else if (s == nameof(archive_inOutFiles))
                    {
                        s = fin.ReadLine();
                        Set_archive_inOutFiles(bool.Parse(s));
                    }
                    else if (s == nameof(archive_folder))
                    {
                        s = fin.ReadLine();
                        Set_archive_folder(s);
                    }

                    // Preferences.
                    else if (s == nameof(tempRootFolder))
                    {
                        s = fin.ReadLine();
                        Set_tempRootFolder(s);
                    }
                    else if (s == nameof(archiveRootFolder))
                    {
                        s = fin.ReadLine();
                        Set_archiveRootFolder(s);
                    }
                    else if (s == nameof(openAfterCreate))
                    {
                        s = fin.ReadLine();
                        Set_openAfterCreate(bool.Parse(s));
                    }
                    else if (s == nameof(exitAfterOpenCreate))
                    {
                        s = fin.ReadLine();
                        Set_exitAfterOpenCreate(bool.Parse(s));
                    }
                    else if (s == nameof(openWith))
                    {
                        s = fin.ReadLine();
                        Set_openWith(s);
                    }
                    else if (s == nameof(saveAutocomplete))
                    {
                        s = fin.ReadLine();
                        Set_saveAutocomplete(bool.Parse(s));
                    }
                    else if (s == nameof(colorTheme))
                    {
                        s = fin.ReadLine();
                        Set_colorTheme((ColorTheme)Enum.Parse(typeof(ColorTheme), s));
                    }
                }
            }
        }

        /// <summary> Just for loading the data inside autocomplete.algosetup. </summary>
        void LoadAutocomplete()
        {
            string path = Path.Combine(Application.LocalUserAppDataPath, AUTOCOMPLETE_FILENAME);
            using (var fin = new StreamReader(path))
            {
                string s;
                while ((s = fin.ReadLine()) != null)
                {
                    if (s != nameof(temp_cppAuto) && s != nameof(temp_inOutAuto) && s != nameof(archive_cppAuto) && s != nameof(archive_folderAuto))
                        continue;

                    string t = fin.ReadLine();
                    int n = int.Parse(t);
                    string[] S = new string[n];

                    for (int i = 0; i < n; ++i)
                        S[i] = fin.ReadLine();

                    if (s == nameof(temp_cppAuto))
                        Set_temp_cppAuto(S);
                    else if (s == nameof(temp_inOutAuto))
                        Set_temp_inOutAuto(S);
                    else if (s == nameof(archive_cppAuto))
                        Set_archive_cppAuto(S);
                    else if (s == nameof(archive_folderAuto))
                        Set_archive_folderAuto(S);
                }
            }
        }

        /// <summary> Just for saving the data inside preferences.algosetup </summary>
        void SavePref()
        {
            string path = Path.Combine(Application.LocalUserAppDataPath, PREF_FILENAME);
            using (var fout = new StreamWriter(path))
            {
                // Temp.
                fout.WriteLine(nameof(temp_cppFilename));
                fout.WriteLine(temp_cppFilename);
                fout.WriteLine(nameof(temp_inOutFiles));
                fout.WriteLine(temp_inOutFiles);
                fout.WriteLine(nameof(temp_inOutFilename));
                fout.WriteLine(temp_inOutFilename);

                // Archive.
                fout.WriteLine(nameof(archive_cppFilename));
                fout.WriteLine(archive_cppFilename);
                fout.WriteLine(nameof(archive_inOutFiles));
                fout.WriteLine(archive_inOutFiles);
                fout.WriteLine(nameof(archive_folder));
                fout.WriteLine(archive_folder);

                // Preferences.
                fout.WriteLine(nameof(tempRootFolder));
                fout.WriteLine(tempRootFolder);
                fout.WriteLine(nameof(archiveRootFolder));
                fout.WriteLine(archiveRootFolder);
                fout.WriteLine(nameof(openAfterCreate));
                fout.WriteLine(openAfterCreate);
                fout.WriteLine(nameof(exitAfterOpenCreate));
                fout.WriteLine(exitAfterOpenCreate);
                fout.WriteLine(nameof(openWith));
                fout.WriteLine(openWith);
                fout.WriteLine(nameof(saveAutocomplete));
                fout.WriteLine(saveAutocomplete);
                fout.WriteLine(nameof(colorTheme));
                fout.WriteLine(colorTheme);
            }
        }

        /// <summary> Just for saving the data inside autocomplete.algosetup </summary>
        void SaveAutocomplete()
        {
            string path = Path.Combine(Application.LocalUserAppDataPath, AUTOCOMPLETE_FILENAME);
            using (var fout = new StreamWriter(path))
            {
                fout.WriteLine(nameof(temp_cppAuto));
                fout.WriteLine(temp_cppAuto.Length);

                foreach (string s in temp_cppAuto)
                    fout.WriteLine(s);

                fout.WriteLine(nameof(temp_inOutAuto));
                fout.WriteLine(temp_inOutAuto.Length);

                foreach (string s in temp_inOutAuto)
                    fout.WriteLine(s);

                fout.WriteLine(nameof(archive_cppAuto));
                fout.WriteLine(archive_cppAuto.Length);

                foreach (string s in archive_cppAuto)
                    fout.WriteLine(s);

                fout.WriteLine(nameof(archive_folderAuto));
                fout.WriteLine(archive_folderAuto.Length);

                foreach (string s in archive_folderAuto)
                    fout.WriteLine(s);
            }
        }

        /// <summary> Here I only set the defaults for values you find in preferences.algosetup </summary>
        void SetDefaultPref()
        {
            // Temp.
            Set_temp_cppFilename("main");
            Set_temp_inOutFiles(true);
            Set_temp_inOutFilename("problem");

            // Archive.
            Set_archive_cppFilename("problem");
            Set_archive_inOutFiles(true);
            Set_archive_folder("Problem");

            // Preferences.
            Set_tempRootFolder(Path.Combine(Application.StartupPath, "Temp"));
            Set_archiveRootFolder(Path.Combine(Application.StartupPath, "Archive"));
            Set_openAfterCreate(true);
            Set_exitAfterOpenCreate(true);
            Set_openWith("explorer");
            Set_saveAutocomplete(true);
            Set_colorTheme(ColorTheme.Default);
        }

        #region Methods for creating Start Code files.
        /// <summary> Just for creating / overriding a new default startcode_temp.txt </summary>
        void CreateTempStartcode()
        {
            string path = Path.Combine(Application.LocalUserAppDataPath, START_CODE_FOLDER, START_CODE_TEMP_FILENAME);
            using (var fout = new StreamWriter(path))
            {
                fout.Write(Resources.startcode_temp);
            }
        }

        /// <summary> Just for creating / overriding a new default startcode_temp_inout.txt </summary>
        void CreateTempInoutStartcode()
        {
            string path = Path.Combine(Application.LocalUserAppDataPath, START_CODE_FOLDER, START_CODE_TEMP_INOUT_FILENAME);
            using (var fout = new StreamWriter(path))
            {
                fout.Write(Resources.startcode_temp_inout);
            }
        }

        /// <summary> Just for creating / overriding a new default startcode_archive.txt </summary>
        void CreateArchiveStartcode()
        {
            string path = Path.Combine(Application.LocalUserAppDataPath, START_CODE_FOLDER, START_CODE_ARCHIVE_FILENAME);
            using (var fout = new StreamWriter(path))
            {
                fout.Write(Resources.startcode_archive);
            }
        }

        /// <summary> Just for creating / overriding a new default startcode_archive_inout.txt </summary>
        void CreateArchiveInoutStartcode()
        {
            string path = Path.Combine(Application.LocalUserAppDataPath, START_CODE_FOLDER, START_CODE_ARCHIVE_INOUT_FILENAME);
            using (var fout = new StreamWriter(path))
            {
                fout.Write(Resources.startcode_archive_inout);
            }
        }
        #endregion
    }
}
