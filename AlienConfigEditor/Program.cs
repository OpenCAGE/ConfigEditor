/*
 * 
 * Created by Matt Filer
 * www.mattfiler.co.uk
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
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
        static Dictionary<string, string> _args;

        [STAThread]
        static void Main(string[] args)
        {
            _args = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            {
                var arguments = Environment.GetCommandLineArgs();
                for (int i = 0; i < arguments.Length; i++)
                {
                    var match = Regex.Match(arguments[i], "-([^=]+)=(.*)");
                    if (!match.Success) continue;
                    var vName = match.Groups[1].Value;
                    var vValue = match.Groups[2].Value;
                    _args[vName] = vValue;

                    if (_args[vName].Substring(_args[vName].Length - 1) == "\"")
                        _args[vName] = _args[vName].Substring(0, _args[vName].Length - 1);
                }
            }

            //Set path to AI
            if (GetArgument("pathToAI") != null)
                SharedData.pathToAI = GetArgument("pathToAI");
            else
                SharedData.pathToAI = Environment.CurrentDirectory;

            //Set paths
            SharedData.pathToWorkingFiles = SharedData.pathToAI + "/DATA/MODTOOLS/WORKING_FILES/";
            SharedData.pathToModsFolder = SharedData.pathToAI + "/DATA/MODS/";

            //Verify location
            if (!File.Exists(SharedData.pathToAI + "/AI.exe")) 
                throw new Exception("This tool was launched incorrectly, or was not placed within the Alien: Isolation directory.");

            //Create required directories
            if (!Directory.Exists(SharedData.pathToWorkingFiles)) 
                Directory.CreateDirectory(SharedData.pathToWorkingFiles);
            if (!Directory.Exists(SharedData.pathToModsFolder)) 
                Directory.CreateDirectory(SharedData.pathToModsFolder);

            //Run app
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new ConfigEditor());
        }

        public static string GetArgument(string name)
        {
            if (_args.ContainsKey(name))
                return _args[name];
            return null;
        }
    }
}
