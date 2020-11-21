/*
 * 
 * Created by Matt Filer
 * www.mattfiler.co.uk
 * 
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace AlienConfigEditor
{
    public static class SharedData
    {
        public static string pathToAI = "";
        public static string pathToWorkingFiles = "";
        public static string pathToModsFolder = "";
    }

    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Set paths
            if (args.Length > 0) for (int i = 0; i < args.Length; i++) SharedData.pathToAI += args[i] + " ";
            else SharedData.pathToAI = Environment.CurrentDirectory + " ";
            SharedData.pathToAI = SharedData.pathToAI.Substring(0, SharedData.pathToAI.Length - 1);
            SharedData.pathToWorkingFiles = SharedData.pathToAI + "/DATA/MODTOOLS/WORKING_FILES/";
            SharedData.pathToModsFolder = SharedData.pathToAI + "/DATA/MODS/";

            //Verify location
            if (!File.Exists(SharedData.pathToAI + "/AI.exe")) throw new Exception("This tool was launched incorrectly, or was not placed within the Alien: Isolation directory.");

            //Create required directories
            if (!Directory.Exists(SharedData.pathToWorkingFiles)) Directory.CreateDirectory(SharedData.pathToWorkingFiles);
            if (!Directory.Exists(SharedData.pathToModsFolder)) Directory.CreateDirectory(SharedData.pathToModsFolder);

            //Run app
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Landing mainLandingPage = new Landing();
            mainLandingPage.Show();
            Application.Run();
        }
    }
}
