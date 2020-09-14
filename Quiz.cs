using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;

namespace MelodyGame
{
    static class Quiz
    {
        static public List<string> list = new List<string>();
        static public int gameDuration = 60;
        static public int musicDuration = 15;
        static public bool randomStart = true;
        static public string lastFolder = "";
        static public bool allDirectories = false;
        static string regKeyName = "Software\\Baldezhland\\MelodyGame";
        static public void ReadMusic()
        {
            string[] music_files = Directory.GetFiles(lastFolder, "*.mp3", allDirectories?
                                                      SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            list.Clear();
            list.AddRange(music_files);
        }
        public static void SaveSettings()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null)
                    return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("RandomStart", randomStart);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("AllDirectories", allDirectories);
            }
            finally
            {
                if (rk != null)
                    rk.Close();
            }
        }
        public static void ReadSettings()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    randomStart = Convert.ToBoolean(rk.GetValue("RandomStart", false));
                    gameDuration = (int)rk.GetValue("GameDuration");
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    allDirectories = Convert.ToBoolean(rk.GetValue("AllDirectories", false));
                }
            }
            finally
            {
                if (rk != null)
                    rk.Close();
            }
        }
    }
}
