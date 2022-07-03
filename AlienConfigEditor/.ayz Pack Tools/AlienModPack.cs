using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace AlienConfigEditor
{
    class AlienModPack
    {
        //Define pack data
        byte[] AlienModPackArray = new byte[2000000]; //~2mb - we should get down to ~899kb when finished (if user includes all files).
        string AlienModManifest = "";
        int PackOffset = 0;


        //---------------------------------------------------------------


        /*
         * Access Level: Public
         * Description: Save a mod to an archive file
         * Return value: True if saved, false if error
        */
        public bool SaveModPack(string ModName, string ModDescription, string ModAuthor, string ModPreviewPicFilepath, string[] CheckboxArray)
        {
            try
            {
                //Shouldn't have 0 - but just in case.
                if (CheckboxArray.Count() == 0)
                {
                    return false;
                }

                //Add default info to manifest
                AlienModManifest = ModName + Environment.NewLine +
                                   ModDescription + Environment.NewLine +
                                   ModAuthor + Environment.NewLine;

                //Read in ENGINE_SETTINGS
                if (CheckboxArray.Contains("ENGINE_SETTINGS")) AddToPack(SharedData.pathToAI + "/DATA/ENGINE_SETTINGS.XML");

                //Read in PACKAGES (only MAIN.PKG)
                if (CheckboxArray.Contains("PACKAGES")) AddToPack(SharedData.pathToAI + "/DATA/PACKAGES/MAIN.PKG");

                //Read in GBL_ITEM files
                if (CheckboxArray.Contains("GBL_ITEMS"))
                {
                    AddToPack(SharedData.pathToAI + "/DATA/GBL_ITEM.BML");
                    AddToPack(SharedData.pathToAI + "/DATA/GBL_ITEM.XML");
                }

                //Read in generic lighting/shading files
                if (CheckboxArray.Contains("LIGHTING"))
                {
                    AddToPack(SharedData.pathToAI + "/DATA/HAIR_SHADING_SETTINGS.TXT");
                    AddToPack(SharedData.pathToAI + "/DATA/RADIOSITY_SETTINGS.TXT");
                    AddToPack(SharedData.pathToAI + "/DATA/SKIN_SHADING_SETTINGS.TXT");
                }

                //Read in ALIENCONFIGS
                if (CheckboxArray.Contains("ALIENCONFIGS"))
                {
                    foreach (string filename in Directory.GetFiles(SharedData.pathToAI + "/DATA/ALIENCONFIGS/"))
                    {
                        AddToPack(filename);
                    }
                }

                //Read in BINARY_BEHAVIOUR
                if (CheckboxArray.Contains("BEHAVIOR")) { AddToPack(SharedData.pathToAI + "/DATA/BINARY_BEHAVIOR/_DIRECTORY_CONTENTS.BML"); }

                //Read in CHR_INFO
                if (CheckboxArray.Contains("CHR_INFO"))
                {
                    foreach (string filename in Directory.GetFiles(SharedData.pathToAI + "/DATA/CHR_INFO/ATTRIBUTES/"))
                    {
                        AddToPack(filename);
                    }
                }

                //Read in DIFFICULTYSETTINGS
                if (CheckboxArray.Contains("DIFFICULTYSETTINGS"))
                {
                    foreach (string filename in Directory.GetFiles(SharedData.pathToAI + "/DATA/DIFFICULTYSETTINGS/"))
                    {
                        AddToPack(filename);
                    }
                }

                //Read in VIEW_CONE_SETS
                if (CheckboxArray.Contains("VIEW_CONE_SETS"))
                {
                    foreach (string filename in Directory.GetFiles(SharedData.pathToAI + "/DATA/VIEW_CONE_SETS/"))
                    {
                        AddToPack(filename);
                    }
                }

                //Read in WEAPON_INFO
                if (CheckboxArray.Contains("WEAPON_INFO"))
                {
                    foreach (string filename in Directory.GetFiles(SharedData.pathToAI + "/DATA/WEAPON_INFO/AMMO/"))
                    {
                        AddToPack(filename);
                    }
                }

                //Resize array to the right size - don't want a huge pack file :)
                Array.Resize(ref AlienModPackArray, PackOffset);

                //Create directory
                Directory.CreateDirectory(SharedData.pathToModsFolder + ModName);

                //Save to file
                File.WriteAllBytes(SharedData.pathToModsFolder + ModName + "/" + ModName + ".ayz", AlienModPackArray);
                File.WriteAllText(SharedData.pathToModsFolder + ModName + "/" + ModName + "_manifest.ayz", AlienModManifest);

                //Copy preview image
                File.Copy(ModPreviewPicFilepath, SharedData.pathToModsFolder + ModName + "/" + ModName  + "_preview" + Path.GetExtension(ModPreviewPicFilepath));

                return true;
            }
            catch
            {
                return false;
            }
        }


        /*
         * Access Level: Private
         * Description: Add file to mod tool pack byte array
         * Return value: null
        */
        private void AddToPack(string filename)
        {
            byte[] currentFile = File.ReadAllBytes(filename); //Load in current file bytes
            currentFile.CopyTo(AlienModPackArray, PackOffset); //Copy byte contents of file to pack
            AlienModManifest += filename.Split(new[] { "/DATA/" }, StringSplitOptions.None)[1] + Environment.NewLine + PackOffset; //Write filename and start position to manifest
            PackOffset += currentFile.Length; //Update offset
            AlienModManifest += Environment.NewLine + PackOffset + Environment.NewLine; //Write end position to manifest
        }


        //---------------------------------------------------------------


        /*
         * Access Level: Public
         * Description: Get mod info before loading
         * Return value: Information array
        */
        public string[] GetModInfo(string ModName)
        {
            string[] ModInfo = { "", "", "" };

            try
            {
                //Read in manifest & split out info
                string ModManifestPath = SharedData.pathToModsFolder + ModName + "/" + ModName + "_manifest.ayz";
                string[] ModManifest = File.ReadAllLines(ModManifestPath);
                ModInfo[0] = ModManifest[0];
                ModInfo[1] = ModManifest[1];
                ModInfo[2] = ModManifest[2];
            }
            catch
            {
                ModInfo[0] = "Error";
                ModInfo[1] = "Error";
                ModInfo[2] = "Error";
            }

            //Return info
            return ModInfo;
        }


        /*
         * Access Level: Public
         * Description: Load a mod from an archive file
         * Return value: True if loaded, false if error
        */
        public bool LoadModPack(string ModName)
        {
            try
            {
                //Get filepaths to mod files
                string ModPackPath = SharedData.pathToModsFolder + ModName + "/" + ModName + ".ayz";
                string ModManifestPath = SharedData.pathToModsFolder + ModName + "/" + ModName + "_manifest.ayz";

                //Load in main pack and manifest
                byte[] ModPack = File.ReadAllBytes(ModPackPath);
                string[] ModManifest = File.ReadAllLines(ModManifestPath);

                //Read manifest and extract files
                int ManifestCount = 0;
                int ArrayCount = -1;
                bool ManifestDataLoaded = false;
                string ModTitle = "";
                string ModDescription = "";
                string ModIngameDescription = "";
                string[] FilesToExtract = new string[999];
                int[] FileStartPositions = new int[999];
                int[] FileEndPositions = new int[999];
                foreach (string ManifestLine in ModManifest)
                {
                    //Load Mod Data
                    if (ManifestCount == 0 && !ManifestDataLoaded)
                    {
                        ModTitle = ManifestLine;
                    } else if (ManifestCount == 1 && !ManifestDataLoaded)
                    {
                        ModDescription = ManifestLine;
                    } else if (ManifestCount == 2 && !ManifestDataLoaded)
                    {
                        ModIngameDescription = ManifestLine;
                        ManifestDataLoaded = true;
                        ManifestCount = -1;
                    }

                    //Load File Data
                    if (ManifestCount == 0 && ManifestDataLoaded)
                    {
                        ArrayCount++;
                        FilesToExtract[ArrayCount] = ManifestLine;
                    } else if (ManifestCount == 1 && ManifestDataLoaded)
                    {
                        FileStartPositions[ArrayCount] = Convert.ToInt32(ManifestLine);
                    } else if (ManifestCount == 2 && ManifestDataLoaded)
                    {
                        FileEndPositions[ArrayCount] = Convert.ToInt32(ManifestLine);
                        ManifestCount = -1;
                    }

                    ManifestCount++;
                }

                //Resize file arrays to correct count
                Array.Resize(ref FilesToExtract, ArrayCount);
                Array.Resize(ref FileStartPositions, ArrayCount);
                Array.Resize(ref FileEndPositions, ArrayCount);

                //First up, reset everything to defaults
                ResetFiles("ALL",true);

                //Extract files to game
                for (int i = 0; i < ArrayCount; i++)
                {
                    File.WriteAllBytes(SharedData.pathToAI + "/DATA/" + FilesToExtract[i], File.ReadAllBytes(ModPackPath).Skip(FileStartPositions[i]).Take(FileEndPositions[i] - FileStartPositions[i]).ToArray());
                }

                //Update UI text
                string[] UiText = File.ReadAllLines(SharedData.pathToAI + "/DATA/TEXT/ENGLISH/UI.TXT");
                bool HasFoundPressToStart = false;
                bool HasFoundPressToStartKeyboard = false;
                bool HasFoundPlayGameDesc = false;
                int LineCounter = 0;
                foreach (string UiLine in UiText)
                {
                    //Update attribute if found
                    if (HasFoundPressToStart || HasFoundPressToStartKeyboard)
                    {
                        UiText[LineCounter] = "{Running mod: \"" + ModName + "\"}";
                        if (HasFoundPressToStart) { HasFoundPressToStart = false; } else { HasFoundPressToStartKeyboard = false; }
                    }
                    if (HasFoundPlayGameDesc)
                    {
                        UiText[LineCounter] = "{"+ModIngameDescription+"}";
                        HasFoundPlayGameDesc = false;
                    }

                    //Has found attribute
                    if (UiLine == "[AI_UI_FRONTEND_PRESS_TO_START]")
                    {
                        HasFoundPressToStart = true;
                    }
                    if (UiLine == "[AI_UI_FRONTEND_PRESS_TO_START_KB]")
                    {
                        HasFoundPressToStart = true;
                    }
                    if (UiLine == "[AI_UI_FRONTEND_PLAY_GAME_DESC]")
                    {
                        HasFoundPlayGameDesc = true;
                    }

                    LineCounter++;
                }
                File.WriteAllLines(SharedData.pathToAI + "/DATA/TEXT/ENGLISH/UI.TXT", UiText, Encoding.Unicode);

                return true;
            }
            catch
            {
                return false;
            }
        }


        //---------------------------------------------------------------


        /*
         * Access Level: Public
         * Description: Reset the requested files back to default
         * Return value: void
        */
        public void ResetFiles(string toReset, bool isAccessingInFunction)
        {
            try
            {
                DialogResult Confirmation = DialogResult.Yes;

                if (!isAccessingInFunction)
                {
                    Confirmation = MessageBox.Show("Are you sure?" + Environment.NewLine + Environment.NewLine + "- This will undo anything you have edited yourself." + Environment.NewLine + "- This will uninstall the selected installed mod files.", "Resetting Files", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

                if (Confirmation == DialogResult.Yes)
                {
                    if (toReset == "GRAPHICS" || toReset == "ALL")
                    {
                        ResetFile("ENGINE_SETTINGS.XML");
                    }

                    if (toReset == "PACKAGES" || toReset == "ALL")
                    {
                        ResetFile("PACKAGES/MAIN.PKG");
                    }

                    if (toReset == "LIGHTING" || toReset == "ALL")
                    {
                        ResetFile("HAIR_SHADING_SETTINGS.TXT");
                        ResetFile("RADIOSITY_SETTINGS.TXT");
                        ResetFile("SKIN_SHADING_SETTINGS.TXT");
                    }

                    if (toReset == "ALIENCONFIGS" || toReset == "ALL")
                    {
                        ResetFile("ALIENCONFIGS/ALIENCONFIGS.BML");
                        ResetFile("ALIENCONFIGS/BACKSTAGEALERT.BML");
                        ResetFile("ALIENCONFIGS/BACKSTAGEHOLD.BML");
                        ResetFile("ALIENCONFIGS/BACKSTAGEHOLD_MILD.BML");
                        ResetFile("ALIENCONFIGS/BACKSTAGEHOLD_VCLOSE.BML");
                        ResetFile("ALIENCONFIGS/BACSTAGEHOLD_CLOSE.BML");
                        ResetFile("ALIENCONFIGS/CANTEEN.BML");
                        ResetFile("ALIENCONFIGS/CREWEXPENDABLE_VENT.BML");
                        ResetFile("ALIENCONFIGS/DEFAULT.BML");
                        ResetFile("ALIENCONFIGS/INTENSE.BML");
                        ResetFile("ALIENCONFIGS/MILD.BML");
                        ResetFile("ALIENCONFIGS/MODERATE.BML");
                        ResetFile("ALIENCONFIGS/MODERATELY_INTENSE.BML");
                    }

                    if (toReset == "DIFFICULTIES" || toReset == "ALL")
                    {
                        ResetFile("DIFFICULTYSETTINGS/DIFFICULTYSETTINGS.BML");
                        ResetFile("DIFFICULTYSETTINGS/EASY.BML");
                        ResetFile("DIFFICULTYSETTINGS/HARD.BML");
                        ResetFile("DIFFICULTYSETTINGS/IRON.BML");
                        ResetFile("DIFFICULTYSETTINGS/MEDIUM.BML");
                        ResetFile("DIFFICULTYSETTINGS/NOVICE.BML");
                    }

                    if (toReset == "VIEWCONES" || toReset == "ALL")
                    {
                        ResetFile("VIEW_CONE_SETS/VIEWCONESET_ANDROID.BML");
                        ResetFile("VIEW_CONE_SETS/VIEWCONESET_HUMAN.BML");
                        ResetFile("VIEW_CONE_SETS/VIEWCONESET_HUMAN_HEIGHTENED.BML");
                        ResetFile("VIEW_CONE_SETS/VIEWCONESET_NONE.BML");
                        ResetFile("VIEW_CONE_SETS/VIEWCONESET_SLEEPING.BML");
                        ResetFile("VIEW_CONE_SETS/VIEWCONESET_STANDARD.BML");
                        ResetFile("VIEW_CONE_SETS/VIEWCONESETS.BML");
                    }

                    if (toReset == "AMMO" || toReset == "ALL")
                    {
                        ResetFile("WEAPON_INFO/AMMO/ACID_BURST_LARGE.BML");
                        ResetFile("WEAPON_INFO/AMMO/ACID_BURST_SMALL.BML");
                        ResetFile("WEAPON_INFO/AMMO/AMMOTYPES.BML");
                        ResetFile("WEAPON_INFO/AMMO/BOLTGUN_NORMAL.BML");
                        ResetFile("WEAPON_INFO/AMMO/CATALYST_FIRE_LARGE.BML");
                        ResetFile("WEAPON_INFO/AMMO/CATALYST_FIRE_SMALL.BML");
                        ResetFile("WEAPON_INFO/AMMO/CATALYST_HE_LARGE.BML");
                        ResetFile("WEAPON_INFO/AMMO/CATALYST_HE_SMALL.BML");
                        ResetFile("WEAPON_INFO/AMMO/CATTLEPROD_POWERPACK.BML");
                        ResetFile("WEAPON_INFO/AMMO/EMP_BURST_LARGE.BML");
                        ResetFile("WEAPON_INFO/AMMO/EMP_BURST_LARGE_TIER2.BML");
                        ResetFile("WEAPON_INFO/AMMO/EMP_BURST_LARGE_TIER3.BML");
                        ResetFile("WEAPON_INFO/AMMO/EMP_BURST_SMALL.BML");
                        ResetFile("WEAPON_INFO/AMMO/ENVIRONMENT_FLAME.BML");
                        ResetFile("WEAPON_INFO/AMMO/FLAMETHROWER_AERATED.BML");
                        ResetFile("WEAPON_INFO/AMMO/FLAMETHROWER_HIGH_DAMAGE.BML");
                        ResetFile("WEAPON_INFO/AMMO/FLAMETHROWER_NORMAL.BML");
                        ResetFile("WEAPON_INFO/AMMO/GRENADE_FIRE.BML");
                        ResetFile("WEAPON_INFO/AMMO/GRENADE_FIRE_TIER2.BML");
                        ResetFile("WEAPON_INFO/AMMO/GRENADE_FIRE_TIER3.BML");
                        ResetFile("WEAPON_INFO/AMMO/GRENADE_HE.BML");
                        ResetFile("WEAPON_INFO/AMMO/GRENADE_HE_TIER2.BML");
                        ResetFile("WEAPON_INFO/AMMO/GRENADE_HE_TIER3.BML");
                        ResetFile("WEAPON_INFO/AMMO/GRENADE_SMOKE.BML");
                        ResetFile("WEAPON_INFO/AMMO/GRENADE_STUN.BML");
                        ResetFile("WEAPON_INFO/AMMO/GRENADE_STUN_TIER2.BML");
                        ResetFile("WEAPON_INFO/AMMO/GRENADE_STUN_TIER3.BML");
                        ResetFile("WEAPON_INFO/AMMO/IMPACT.BML");
                        ResetFile("WEAPON_INFO/AMMO/MELEE_CROW_AXE.BML");
                        ResetFile("WEAPON_INFO/AMMO/PISTOL_DUM_DUM.BML");
                        ResetFile("WEAPON_INFO/AMMO/PISTOL_NORMAL.BML");
                        ResetFile("WEAPON_INFO/AMMO/PISTOL_NORMAL_NPC.BML");
                        ResetFile("WEAPON_INFO/AMMO/PISTOL_TAZER.BML");
                        ResetFile("WEAPON_INFO/AMMO/PUSH.BML");
                        ResetFile("WEAPON_INFO/AMMO/SHOTGUN_INCENDIARY.BML");
                        ResetFile("WEAPON_INFO/AMMO/SHOTGUN_NORMAL.BML");
                        ResetFile("WEAPON_INFO/AMMO/SHOTGUN_NORMAL_NPC.BML");
                        ResetFile("WEAPON_INFO/AMMO/SHOTGUN_SLUG.BML");
                        ResetFile("WEAPON_INFO/AMMO/SMG_DUM_DUM.BML");
                        ResetFile("WEAPON_INFO/AMMO/SMG_NORMAL.BML");
                    }

                    if (toReset == "GBL_ITEM" || toReset == "ALL")
                    {
                        ResetFile("GBL_ITEM.XML");
                        ResetFile("GBL_ITEM.BML");
                    }

                    if (toReset == "CHR_INFO" || toReset == "ALL")
                    {
                        ResetFile("CHR_INFO/ATTRIBUTES/ALIEN.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/ANDROID.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/ANDROID_HEAVY.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/ATTRIBUTES.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/BASE_HUMAN.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/CIVILIAN.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/CUTSCENE.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/CUTSCENE_ANDROID.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/DEFAULTS.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/FACEHUGGER.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/INNOCENT.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/MELEE_HUMAN.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/RIOT_GUARD.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/SECURITY_GUARD.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/SPACESUIT_NPC.BML");
                        ResetFile("CHR_INFO/ATTRIBUTES/THE_PLAYER.BML");
                    }

                    if (!isAccessingInFunction)
                    {
                        //Reset UI text
                        string[] UiText = File.ReadAllLines(SharedData.pathToAI + "/DATA/TEXT/ENGLISH/UI.TXT");
                        bool HasFoundPressToStart = false;
                        bool HasFoundPressToStartKeyboard = false;
                        bool HasFoundPlayGameDesc = false;
                        int LineCounter = 0;
                        foreach (string UiLine in UiText)
                        {
                            //Update attribute if found
                            if (HasFoundPressToStart)
                            {
                                UiText[LineCounter] = "{Press @confirm@}";
                                HasFoundPressToStart = false;
                            }
                            if (HasFoundPressToStartKeyboard)
                            {
                                UiText[LineCounter] = "{Press any key}";
                                HasFoundPressToStartKeyboard = false;
                            }
                            if (HasFoundPlayGameDesc)
                            {
                                UiText[LineCounter] = "{Select Game Mode}";
                                HasFoundPlayGameDesc = false;
                            }

                            //Has found attribute
                            if (UiLine == "[AI_UI_FRONTEND_PRESS_TO_START]")
                            {
                                HasFoundPressToStart = true;
                            }
                            if (UiLine == "[AI_UI_FRONTEND_PRESS_TO_START_KB]")
                            {
                                HasFoundPressToStartKeyboard = true;
                            }
                            if (UiLine == "[AI_UI_FRONTEND_PLAY_GAME_DESC]")
                            {
                                HasFoundPlayGameDesc = true;
                            }

                            LineCounter++;
                        }
                        File.WriteAllLines(SharedData.pathToAI + "/DATA/TEXT/ENGLISH/UI.TXT", UiText, Encoding.Unicode);

                        MessageBox.Show("The requested files have been reset to defaults.", "Reset complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (!isAccessingInFunction)
                    {
                        MessageBox.Show("The requested files were not reset.", "Reset cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                if (!isAccessingInFunction)
                {
                    MessageBox.Show("An unexpected error occured while resetting." + Environment.NewLine + "Make sure no game files/editors are open.", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /*
         * Access Level: Private
         * Description: Reset the requested file to the requested resource in bytes
         * Return value: void
        */
        private void ResetFile(string resetFilePath)
        {
            File.Delete(SharedData.pathToAI + @"\DATA\" + resetFilePath);
            FileStream file = File.Create(SharedData.pathToAI + @"\DATA\" + resetFilePath);
            GetResourceStream(resetFilePath).CopyTo(file);
            file.Close();
        }
        protected static Stream GetResourceStream(string resourcePath)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            List<string> resourceNames = new List<string>(assembly.GetManifestResourceNames());

            resourcePath = resourcePath.Replace(@"/", ".");
            resourcePath = resourceNames.FirstOrDefault(r => r.Contains(resourcePath));

            if (resourcePath == null)
                throw new FileNotFoundException("Resource not found");

            return assembly.GetManifestResourceStream(resourcePath);
        }
    }
}
