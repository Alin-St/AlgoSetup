using AlgoSetup.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace AlgoSetup
{
    partial class MainForm
    {
        const string PREF_FILENAME = "preferences.algosetup";
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

            // Load pref file if it exists, else set everything to default.
            path = Path.Combine(Application.LocalUserAppDataPath, PREF_FILENAME);

            if (File.Exists(path))
                LoadPref();
            else SetDefaultPref();

            // Create the default Start Code files if they don't exist (probably because it is the first time the app is started).
            path = Path.Combine(Application.LocalUserAppDataPath, START_CODE_FOLDER);

            Directory.CreateDirectory(path);

            if (!File.Exists(Path.Combine(path, START_CODE_TEMP_FILENAME)))
                CreateTempStartcode();

            if (!File.Exists(Path.Combine(path, START_CODE_TEMP_INOUT_FILENAME)))
                CreateTempInoutStartcode();

            if (!File.Exists(Path.Combine(path, START_CODE_ARCHIVE_FILENAME)))
                CreateArchiveStartcode();

            if (!File.Exists(Path.Combine(path, START_CODE_ARCHIVE_INOUT_FILENAME)))
                CreateArchiveInoutStartcode();
        }

        /// <summary> Method called on MainForm_Close, to work on everything that is needed on App closing, related to saving data. </summary>
        void SaveData()
        {
            SavePref();
        }

        /// <summary> Just for loading the data inside preferences.algosetup </summary>
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
