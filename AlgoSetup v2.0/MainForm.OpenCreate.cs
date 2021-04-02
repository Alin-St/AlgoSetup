using AlgoSetup.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AlgoSetup
{
    partial class MainForm
    {
        /// <summary> This is basically the button's click event just with a nicer name and without the try catch.
        /// This method is also called by the Create Function, if openAfterCreate is true! </summary>
        void TempOpen()
        {
            OpenThree(Path.Combine(tempRootFolder, temp_cppFilename + ".cpp"),
                temp_inOutFiles ? Path.Combine(tempRootFolder, temp_inOutFilename) : null);

            if (exitAfterOpenCreate)
                Application.Exit();
        }

        /// <summary> This is basically the button's click event just with a nicer name and without the try catch. </summary>
        void TempCreate()
        {
            if (!Directory.Exists(tempRootFolder))
                throw new InvalidOperationException("Folder doesn't exist!");

            string cppText = GetStartCode(true, temp_inOutFiles ? temp_inOutFilename : null);

            CreateThree(tempRootFolder, temp_cppFilename + ".cpp", temp_inOutFiles ? temp_inOutFilename : null, cppText);

            UpdateOpenCreateEnabled();

            if (openAfterCreate)
                TempOpen();
            else if (exitAfterOpenCreate)
                Application.Exit();
            else MessageBox.Show("Files created!", Application.ProductName);
        }

        /// <summary> This is basically the button's click event just with a nicer name and without the try catch.
        /// This method is also called by the Create Function, if openAfterCreate is true! </summary>
        void ArchiveOpen()
        {
            string filename = Path.Combine(archiveRootFolder, archive_folder, archive_cppFilename);
            OpenThree(filename + ".cpp", archive_inOutFiles ? filename : null);

            if (exitAfterOpenCreate)
                Application.Exit();
        }

        /// <summary> This is basically the button's click event just with a nicer name and without the try catch. </summary>
        void ArchiveCreate()
        {
            if (!Directory.Exists(archiveRootFolder))
                throw new InvalidOperationException("Folder doesn't exist!");

            string folder = Path.Combine(archiveRootFolder, archive_folder);
            Directory.CreateDirectory(folder);

            string cppText = GetStartCode(false, archive_inOutFiles ? archive_cppFilename : null);

            CreateThree(folder, archive_cppFilename + ".cpp", archive_inOutFiles ? archive_cppFilename : null, cppText);

            if (openAfterCreate)
                ArchiveOpen();
            else if (exitAfterOpenCreate)
                Application.Exit();
            else MessageBox.Show("Files created!", Application.ProductName);

            UpdateOpenCreateEnabled();
        }

        /// <summary> Here I open the cpp file and the in/out if needed only if all the files exist.
        /// cppWithExt expects a path including .cpp extension, while inOut expects a path without .in/.out ext. OR null </summary>
        void OpenThree(string cppWithExt, string inOut)
        {
            if (!File.Exists(cppWithExt) || (inOut != null) && (!File.Exists(inOut + ".in") || !File.Exists(inOut + ".out")))
                throw new InvalidOperationException("Files don't exist!");

            if (inOut != null)
            {
                OpenFile(inOut + ".out");
                OpenFile(inOut + ".in");
            }

            OpenFile(cppWithExt);
        }

        /// <summary> If the folder doesn't exist an exception is thrown.
        /// Else it just creates the cpp file with the cppText, and the in/out files if inOut != null.
        /// folder is a path, cppWithExt is only the cpp name with .cpp, while inOut is only the in/out name without .in/.out </summary>
        void CreateThree(string folder, string cppWithExt, string inOut, string cppText)
        {
            if (!Directory.Exists(folder))
                throw new InvalidOperationException("Folder doesn't exist!");

            File.WriteAllText(Path.Combine(folder, cppWithExt), cppText);

            if (inOut != null)
            {
                File.Create(Path.Combine(folder, inOut + ".in")).Close();
                File.Create(Path.Combine(folder, inOut + ".out")).Close();
            }
        }

        /// <summary> Returns the start code from the corresponding file, or the default value from Resources </summary>
        string GetStartCode(bool isTemp, string inOutFilename)
        {
            string path = Path.Combine(Application.LocalUserAppDataPath, START_CODE_FOLDER), text;
            bool inOutFiles = (inOutFilename != null);

            if (isTemp && !inOutFiles)
                path = Path.Combine(path, START_CODE_TEMP_FILENAME);
            else if (isTemp && inOutFiles)
                path = Path.Combine(path, START_CODE_TEMP_INOUT_FILENAME);
            else if (!isTemp && !inOutFiles)
                path = Path.Combine(path, START_CODE_ARCHIVE_FILENAME);
            else // if (isTemp && inOutFiles)
                path = Path.Combine(path, START_CODE_ARCHIVE_INOUT_FILENAME);

            if (File.Exists(path))
                text =  File.ReadAllText(path);
            else
            {
                if (isTemp && !inOutFiles)
                    return Resources.startcode_temp;
                else if (isTemp && inOutFiles)
                    return Resources.startcode_temp_inout;
                else if (!isTemp && !inOutFiles)
                    return Resources.startcode_archive;
                else // if (isTemp && inOutFiles)
                    return Resources.startcode_archive_inout;
            }

            if (inOutFiles)
                text = text.Replace("$$filename$$", inOutFilename);

            return text;
        }

        /// <summary> Here I just open the file at the specified path using the 'openWith' program. </summary>
        void OpenFile(string path)
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = openWith;
                process.StartInfo.Arguments = "\"" + path + "\"";
                process.Start();
            }
        }
    }
}
