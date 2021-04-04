using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlgoSetup
{
    partial class MainForm
    {
        enum ColorTheme {
            Default,
            Dark,
        }

        struct Theme {
            /// <summary> Dark grey, Lighter dark gray, Aqua, White, Red. </summary>
            public struct Dark {
                public static readonly Color color1 = Color.FromArgb(45, 45, 48);
                public static readonly Color color2 = Color.FromArgb(37, 37, 38);
                public static readonly Color color3 = Color.FromArgb(30, 30, 30);
                public static readonly Color color4 = Color.FromArgb(220, 220, 220);
                public static readonly Color color5 = Color.FromArgb(243, 139, 118);
            }
        }

        void UpdateColorTheme()
        {
            if (colorTheme == ColorTheme.Default)
            {
                BackColor = default;

                // SETUP.
                setupTP.BackColor = default;

                // Temp.
                setup_tempSetupGB.ForeColor = default;

                setup_temp_cppFilenameTB.BorderStyle = BorderStyle.Fixed3D;
                setup_temp_cppFilenameTB.ForeColor = default;
                setup_temp_cppFilenameTB.Font = new Font("Arial", 12);
                if (isTempCppCorrect)
                    setup_temp_cppFilenameTB.BackColor = default;
                else setup_temp_cppFilenameTB.BackColor = Color.IndianRed;

                setup_temp_inOutFilesCB.Cursor = default;

                setup_temp_inOutFilenameTB.BorderStyle = BorderStyle.Fixed3D;
                setup_temp_inOutFilenameTB.ForeColor = default;
                setup_temp_inOutFilenameTB.Font = new Font("Arial", 12);
                if (isTempInOutCorrect)
                    setup_temp_inOutFilenameTB.BackColor = default;
                else setup_temp_inOutFilenameTB.BackColor = Color.IndianRed;

                setup_temp_openB.BackColor = default;
                setup_temp_openB.FlatStyle = FlatStyle.System;
                setup_temp_openB.Font = new Font("Arial", 12);
                setup_temp_openB.Text = "Open";
                setup_temp_openB.Cursor = default;

                setup_temp_createB.BackColor = default;
                setup_temp_createB.FlatStyle = FlatStyle.System;
                setup_temp_createB.Font = new Font("Arial", 12);
                setup_temp_createB.Text = "Create";
                setup_temp_createB.Cursor = default;

                // Archive.
                setup_archiveSetupGB.ForeColor = default;

                setup_archive_cppFilenameTB.BorderStyle = BorderStyle.Fixed3D;
                setup_archive_cppFilenameTB.ForeColor = default;
                setup_archive_cppFilenameTB.Font = new Font("Arial", 12);
                if (isArchiveCppCorrect)
                    setup_archive_cppFilenameTB.BackColor = default;
                else setup_archive_cppFilenameTB.BackColor = Color.IndianRed;

                setup_archive_inOutFilesCB.Cursor = default;

                setup_archive_folderTB.BorderStyle = BorderStyle.Fixed3D;
                setup_archive_folderTB.ForeColor = default;
                setup_archive_folderTB.Font = new Font("Arial", 12);
                if (isArchiveFolderCorrect)
                    setup_archive_folderTB.BackColor = default;
                else setup_archive_folderTB.BackColor = Color.IndianRed;

                setup_archive_openB.BackColor = default;
                setup_archive_openB.FlatStyle = FlatStyle.System;
                setup_archive_openB.Font = new Font("Arial", 12);
                setup_archive_openB.Text = "Open";
                setup_archive_openB.Cursor = default;

                setup_archive_createB.BackColor = default;
                setup_archive_createB.FlatStyle = FlatStyle.System;
                setup_archive_createB.Font = new Font("Arial", 12);
                setup_archive_createB.Text = "Create";
                setup_archive_createB.Cursor = default;

                // PREF.
                preferencesTP.BackColor = default;
                preferencesTP.ForeColor = default;

                pref_tempSetupFolderL.ForeColor = Color.Blue;

                pref_tempSetupFolderB.FlatStyle = FlatStyle.System;
                pref_tempSetupFolderB.BackColor = default;
                pref_tempSetupFolderB.ForeColor = default;
                pref_tempSetupFolderB.Font = new Font("Arial", 12);
                pref_tempSetupFolderB.Cursor = default;

                pref_archiveSetupFolderL.ForeColor = Color.Blue;

                pref_archiveSetupFolderB.FlatStyle = FlatStyle.System;
                pref_archiveSetupFolderB.BackColor = default;
                pref_archiveSetupFolderB.ForeColor = default;
                pref_archiveSetupFolderB.Font = new Font("Arial", 12);
                pref_archiveSetupFolderB.Cursor = default;

                pref_openAfterCreateCB.Cursor = default;

                pref_exitAfterOpenCreateCB.Cursor = default;

                pref_editStartCodeB.BackColor = default;
                pref_editStartCodeB.FlatStyle = FlatStyle.System;
                pref_editStartCodeB.Font = new Font("Arial", 12);
                pref_editStartCodeB.Text = "Edit Start Code";
                pref_editStartCodeB.Cursor = default;

                pref_openPrefFolderB.BackColor = default;
                pref_openPrefFolderB.FlatStyle = FlatStyle.System;
                pref_openPrefFolderB.Font = new Font("Arial", 12);
                pref_openPrefFolderB.Text = "Open Preferences Folder";
                pref_openPrefFolderB.Cursor = default;

                pref_openFilesWithTB.BorderStyle = BorderStyle.Fixed3D;
                pref_openFilesWithTB.BackColor = default;
                pref_openFilesWithTB.ForeColor = default;
                pref_openFilesWithTB.Font = new Font("Arial", 12);

                pref_openWithOfdB.BackColor = default;
                pref_openWithOfdB.FlatStyle = FlatStyle.Standard;
                pref_openWithOfdB.Cursor = default;

                pref_saveDataForAutocompleteCB.Cursor = default;

                pref_colorThemeCB.BackColor = default;
                pref_colorThemeCB.FlatStyle = FlatStyle.System;
                pref_colorThemeCB.ForeColor = default;
                pref_colorThemeCB.Font = new Font("Arial", 12);
            }
            else if (colorTheme == ColorTheme.Dark)
            {
                BackColor = Theme.Dark.color1;

                // SETUP.
                setupTP.BackColor = Theme.Dark.color2;

                // Temp.
                setup_tempSetupGB.ForeColor = Theme.Dark.color4;

                setup_temp_cppFilenameTB.BorderStyle = BorderStyle.FixedSingle;
                setup_temp_cppFilenameTB.BackColor = Theme.Dark.color3;
                setup_temp_cppFilenameTB.Font = new Font("Consolas", 12, FontStyle.Bold);
                if (isTempCppCorrect)
                    setup_temp_cppFilenameTB.ForeColor = Theme.Dark.color4;
                else setup_temp_cppFilenameTB.ForeColor = Theme.Dark.color5;

                setup_temp_inOutFilesCB.Cursor = Cursors.Hand;

                setup_temp_inOutFilenameTB.BorderStyle = BorderStyle.FixedSingle;
                setup_temp_inOutFilenameTB.BackColor = Theme.Dark.color3;
                setup_temp_inOutFilenameTB.Font = new Font("Consolas", 12, FontStyle.Bold);
                if (isTempInOutCorrect)
                    setup_temp_inOutFilenameTB.ForeColor = Theme.Dark.color4;
                else setup_temp_inOutFilenameTB.ForeColor = Theme.Dark.color5;

                setup_temp_openB.BackColor = Theme.Dark.color3;
                setup_temp_openB.FlatStyle = FlatStyle.Flat;
                setup_temp_openB.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
                setup_temp_openB.Font = new Font("Consolas", 12, FontStyle.Bold);
                setup_temp_openB.Text = "OPEN";
                setup_temp_openB.Cursor = Cursors.Hand;

                setup_temp_createB.BackColor = Theme.Dark.color3;
                setup_temp_createB.FlatStyle = FlatStyle.Flat;
                setup_temp_createB.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
                setup_temp_createB.Font = new Font("Consolas", 12, FontStyle.Bold);
                setup_temp_createB.Text = "CREATE";
                setup_temp_createB.Cursor = Cursors.Hand;

                // Archive.
                setup_archiveSetupGB.ForeColor = Theme.Dark.color4;

                setup_archive_cppFilenameTB.BorderStyle = BorderStyle.FixedSingle;
                setup_archive_cppFilenameTB.BackColor = Theme.Dark.color3;
                setup_archive_cppFilenameTB.Font = new Font("Consolas", 12, FontStyle.Bold);
                if (isArchiveCppCorrect)
                    setup_archive_cppFilenameTB.ForeColor = Theme.Dark.color4;
                else setup_archive_cppFilenameTB.ForeColor = Theme.Dark.color5;

                setup_archive_inOutFilesCB.Cursor = Cursors.Hand;

                setup_archive_folderTB.BorderStyle = BorderStyle.FixedSingle;
                setup_archive_folderTB.BackColor = Theme.Dark.color3;
                setup_archive_folderTB.Font = new Font("Consolas", 12, FontStyle.Bold);
                if (isArchiveFolderCorrect)
                    setup_archive_folderTB.ForeColor = Theme.Dark.color4;
                else setup_archive_folderTB.ForeColor = Theme.Dark.color5;

                setup_archive_openB.BackColor = Theme.Dark.color3;
                setup_archive_openB.FlatStyle = FlatStyle.Flat;
                setup_archive_openB.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
                setup_archive_openB.Font = new Font("Consolas", 12, FontStyle.Bold);
                setup_archive_openB.Text = "OPEN";
                setup_archive_openB.Cursor = Cursors.Hand;

                setup_archive_createB.BackColor = Theme.Dark.color3;
                setup_archive_createB.FlatStyle = FlatStyle.Flat;
                setup_archive_createB.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
                setup_archive_createB.Font = new Font("Consolas", 12, FontStyle.Bold);
                setup_archive_createB.Text = "CREATE";
                setup_archive_createB.Cursor = Cursors.Hand;

                // PREF.
                preferencesTP.BackColor = Theme.Dark.color2;
                preferencesTP.ForeColor = Theme.Dark.color4;

                pref_tempSetupFolderL.ForeColor = Theme.Dark.color4;

                pref_tempSetupFolderB.FlatStyle = FlatStyle.Flat;
                pref_tempSetupFolderB.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
                pref_tempSetupFolderB.BackColor = Theme.Dark.color3;
                pref_tempSetupFolderB.ForeColor = Theme.Dark.color4;
                pref_tempSetupFolderB.Font = new Font("Consolas", 10, FontStyle.Bold);
                pref_tempSetupFolderB.Cursor = Cursors.Hand;

                pref_archiveSetupFolderL.ForeColor = Theme.Dark.color4;

                pref_archiveSetupFolderB.FlatStyle = FlatStyle.Flat;
                pref_archiveSetupFolderB.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
                pref_archiveSetupFolderB.BackColor = Theme.Dark.color3;
                pref_archiveSetupFolderB.ForeColor = Theme.Dark.color4;
                pref_archiveSetupFolderB.Font = new Font("Consolas", 10, FontStyle.Bold);
                pref_archiveSetupFolderB.Cursor = Cursors.Hand;

                pref_openAfterCreateCB.Cursor = Cursors.Hand;

                pref_exitAfterOpenCreateCB.Cursor = Cursors.Hand;

                pref_editStartCodeB.BackColor = Theme.Dark.color3;
                pref_editStartCodeB.FlatStyle = FlatStyle.Flat;
                pref_editStartCodeB.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
                pref_editStartCodeB.Font = new Font("Consolas", 12, FontStyle.Bold);
                pref_editStartCodeB.Text = "EDIT START CODE";
                pref_editStartCodeB.Cursor = Cursors.Hand;

                pref_openPrefFolderB.BackColor = Theme.Dark.color3;
                pref_openPrefFolderB.FlatStyle = FlatStyle.Flat;
                pref_openPrefFolderB.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
                pref_openPrefFolderB.Font = new Font("Consolas", 12, FontStyle.Bold);
                pref_openPrefFolderB.Text = "OPEN PREFERENCES FOLDER";
                pref_openPrefFolderB.Cursor = Cursors.Hand;

                pref_openFilesWithTB.BorderStyle = BorderStyle.FixedSingle;
                pref_openFilesWithTB.BackColor = Theme.Dark.color3;
                pref_openFilesWithTB.ForeColor = Theme.Dark.color4;
                pref_openFilesWithTB.Font = new Font("Consolas", 10.5f, FontStyle.Bold);

                pref_openWithOfdB.BackColor = Theme.Dark.color3;
                pref_openWithOfdB.FlatStyle = FlatStyle.Flat;
                pref_openWithOfdB.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
                pref_openWithOfdB.Cursor = Cursors.Hand;

                pref_saveDataForAutocompleteCB.Cursor = Cursors.Hand;

                pref_colorThemeCB.BackColor = Theme.Dark.color3;
                pref_colorThemeCB.FlatStyle = FlatStyle.Flat;
                pref_colorThemeCB.ForeColor = Theme.Dark.color4;
                pref_colorThemeCB.Font = new Font("Consolas", 12, FontStyle.Bold);
            }
        }
    }
}
