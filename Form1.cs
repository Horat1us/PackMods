using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace PackMods
{
    public partial class PackMods : Form
    {
        
        protected string res_mods;
        protected string currentPatch,wotPath,modPath,clearPath,currentPath;
        protected bool isMods;
        public PackMods()
        {
            wotPath = Properties.Settings.Default.wotPath;
            if(!this.changePath())
            {
                Environment.Exit(0);
            }

            
            this.res_mods = wotPath + "\\res_mods";

            this.initPatch();
            if(this.currentPatch=="")
            {
                MessageBox.Show("В папке res_mods не найдены папки патчей.");
                Environment.Exit(1);
            }
            this.currentPath = currentPatch;
            
            this.isMods = !Directory.Exists(currentPath + "_m");
            modPath = currentPath + (this.isMods ? "" : "_m");
            clearPath = currentPath + (this.isMods ? "_c" : "");
            if (!Directory.Exists(this.isMods ? clearPath : modPath))
            {
                try
                {
                    Directory.CreateDirectory(this.isMods ? clearPath : modPath);
                }
                catch
                {
                    MessageBox.Show("Failed to create directory: " + (this.isMods ? clearPath : modPath));
                    Environment.Exit(2);
                }
            }
            InitializeComponent();
        }
        private bool changePath()
        {
            while (!Directory.Exists(wotPath + "\\res_mods"))
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.ShowNewFolderButton = false;
                    fbd.Description = "Select WorldOfTanks folder (must contain res_mods folder)";
                    DialogResult res;
                    try
                    {
                        res = fbd.ShowDialog();
                    }
                    catch (InvalidCastException)
                    {
                        MessageBox.Show("Some error while selecting path");
                        res = DialogResult.OK;
                    }
                    if (res == DialogResult.OK)
                    {
                        Properties.Settings.Default.wotPath = this.wotPath = fbd.SelectedPath;
                        Properties.Settings.Default.Save();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void initPatch()
        {
            string[] patches = Directory.GetDirectories(this.res_mods);
            Array.Sort(patches);
            int currentPatch = patches.Length - 1;
            string pattern = @"([0-9])(\.[0-9]+){2,}";
            Regex regPatch = new Regex(pattern);
            string patch = "";
            foreach(string path in patches)
            {
                MatchCollection matches = regPatch.Matches(path);
                if(matches.Count>0)
                {
                    if (res_mods + "\\" + matches[0].Value != path)
                    {
                        continue;
                    }
                    else
                    {
                        patch = path;
                    }
                }
            }
            this.currentPatch = patch;
        }

        private void changeMode()
        {
            bool isMods = modpack.Checked;
            if (this.isMods == isMods)
                return;
            else this.isMods = isMods;

            try
            {
                Directory.Move(currentPath, currentPath + (this.isMods ? "_c" : "_m"));
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ошибка презаписи каталогов [1]: " + ex.Message);
            }
            try
            {
                Directory.Move(currentPath + (!this.isMods ? "_c" : "_m"), currentPath);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ошибка презаписи каталогов [2]: " + ex.Message);
            }

            return;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            (this.isMods ? modpack : clearpack).Checked = true;
            launcher.Checked = Properties.Settings.Default.launcher;

        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            this.changeMode();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            this.changeMode();
            Process.Start(wotPath + "\\" + (launcher.Checked ? "WoTLauncher.exe" : "WorldOfTanks.exe"));
        }

        private void launcher_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.launcher = launcher.Checked;
            Properties.Settings.Default.Save();
        }


        private void changeWotPath_Click(object sender, EventArgs e)
        {
            string pathCached = this.wotPath;
            this.wotPath = "";
            if(!this.changePath())
            {
                this.wotPath = pathCached;
            }
            wotPathInput.Text = this.wotPath;
        }
    }
}
