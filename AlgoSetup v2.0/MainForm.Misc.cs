using System;

namespace AlgoSetup
{
    partial class MainForm
    {
        bool ValidFilename(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length > 100)
                return false;

            foreach (char c in s)
            {
                if (!char.IsLetterOrDigit(c) && " ()_-,.".IndexOf(c) < 0)
                    return false;
            }

            return true;
        }
    }
}
