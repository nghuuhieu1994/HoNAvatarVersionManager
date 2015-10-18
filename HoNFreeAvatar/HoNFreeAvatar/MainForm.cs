using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Xml;

namespace HoNFreeAvatar
{
    public partial class MainForm : Form
    {
        //string folderPath = @"E:\SBT\GameData\Apps\HoN\game";
        //string resources0Path;
        //string resources1Path;
        //string resources2Path;
        List<String> resourcesPath;
        string texturesPath;
        List<String> currentCode;
        List<String> versionCode;
        List<String> diffCode;
        public MainForm()
        {
            InitializeComponent();
            GetGameVersion();
            currentCode = new List<string>();
            versionCode = new List<string>();
            diffCode = new List<string>();
            resourcesPath = new List<string>();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            string folderPath = tb_folderPath.Text;
            if (folderPath == "")
            {
                MessageBox.Show("Please enter path of resources file!!!");
                return;
            }
            //resources0Path = Path.Combine(folderPath, "resources0.s2z");
            //resources1Path = Path.Combine(folderPath, "resources1.s2z");
            //resources2Path = Path.Combine(folderPath, "resources2.s2z");
            texturesPath = Path.Combine(folderPath, "textures.s2z");
            Thread thrd1 = new Thread(extract);
            thrd1.Start();

        }

        void OpenFunction(string _folderPath)
        {
            for (int i = 0;; i++)
            {
                String currentPath = Path.Combine(_folderPath, "resources" + i + ".s2z");
                if (File.Exists(currentPath))
                {
                    resourcesPath.Add(currentPath);
                }
                else
                {
                    break;
                }
            }
            //resources0Path = Path.Combine(_folderPath, "resources0.s2z");
            //resources1Path = Path.Combine(_folderPath, "resources1.s2z");
            //resources2Path = Path.Combine(_folderPath, "resources2.s2z");
            texturesPath = Path.Combine(_folderPath, "textures.s2z");
            Thread thrd1 = new Thread(extract);
            thrd1.Start();
        }

        void extract()
        {
            //extractResources(resources0Path);
            //extractResources(resources1Path);
            //extractResources(resources2Path);
            for (int i = 0; i < resourcesPath.Count; i++)
            {
                lb_count.Text = "Extracting " + Path.GetFileName(resourcesPath[i]);
                extractResources(resourcesPath[i]);
            }
            lb_count.Text = "Extracting " + Path.GetFileName(texturesPath);
            extractTextures(texturesPath);
            lb_count.Text = "Converting Files";
            convert();
            lb_count.Text = "Loading Heroes";
            lb_count.Text = "Number of avatar:";
        }

        void convert()
        {
            string[] m_Directories = Directory.GetFiles("extract\\00000000", "*.dds", SearchOption.AllDirectories);
            
            string texconvPath = Path.GetFullPath("texconv.exe");
            string command = "-ft PNG -o";
            pb_Process.Maximum = m_Directories.Length;
            pb_Process.Minimum = 0;
            pb_Process.Step = 1;
            for (int i = 0; i < m_Directories.Length; i++)
            {
                lb_count.Text = "Converting file " + i + "/" + m_Directories.Length.ToString();
                StreamWriter sw = new StreamWriter("convertBat.bat");
                string line = texconvPath + " " + command + " ";
                string directoryName = Path.GetDirectoryName(Path.GetFullPath(m_Directories[i])) + " ";
                line += directoryName;
                line += Path.GetFullPath(m_Directories[i]);
                sw.WriteLine(line);
                sw.Close();
                ProcessStartInfo processInfo = new ProcessStartInfo("convertBat.bat");
                processInfo.CreateNoWindow = true;
                processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Process p = Process.Start(processInfo);
                p.WaitForExit();
                pb_Process.Value = i;
            }
            
            for (int i = 0; i < m_Directories.Length; i++)
            {
                File.Delete(m_Directories[i]);
            }

            m_Directories = Directory.GetFiles("extract\\00000000", "*.png", SearchOption.AllDirectories);
            pb_Process.Value = 0;
            pb_Process.Maximum = m_Directories.Length;
            for (int i = 0; i < m_Directories.Length; i++)
            {
                lb_count.Text = "Processing file " + i + "/" + m_Directories.Length.ToString();
                Bitmap save = new Bitmap(m_Directories[i]);

                save.RotateFlip(RotateFlipType.Rotate180FlipX);
                save.Save(m_Directories[i]);
                pb_Process.Value = i;
            }
            pb_Process.Value = 0;
            MessageBox.Show("Done!");
        }

        void extractResources(string filePath)
        {
            ZipFile zip = ZipFile.Read(filePath);
            pb_Process.BeginInvoke(new Action(() =>
            {
                pb_Process.Maximum = zip.Entries.Count;
                pb_Process.Step = 1;
                pb_Process.Value = 0;
            }));
            List<string> fileExist = new List<string>();
            for (int i = 0; i < zip.Entries.Count; i++)
            {
                if (zip.Entries.ElementAt(i).FileName.Contains("heroes"))
                {
                    if (isEntityFile(zip.Entries.ElementAt(i).FileName))
                    {
                        zip.Entries.ElementAt(i).Extract("extract", ExtractExistingFileAction.OverwriteSilently);
                    }
                }
                pb_Process.BeginInvoke(new Action(() => pb_Process.Value = i));
            }
            pb_Process.BeginInvoke(new Action(() => pb_Process.Value = 0));
        }

        void extractTextures(string filePath)
        {
            ZipFile zip = ZipFile.Read(filePath);
            pb_Process.BeginInvoke(new Action(() =>
            {
                pb_Process.Maximum = zip.Entries.Count;
                pb_Process.Step = 1;
                pb_Process.Value = 0;
            }));
            List<string> fileExist = new List<string>();
            for (int i = 0; i < zip.Entries.Count; i++)
            {
                if (zip.Entries.ElementAt(i).FileName.Contains("00000000") && zip.Entries.ElementAt(i).FileName.Contains("heroes"))
                {
                    if (isTexturesfile(zip.Entries.ElementAt(i).FileName))
                    {
                        zip.Entries.ElementAt(i).Extract("extract", ExtractExistingFileAction.OverwriteSilently);
                    }
                }
                pb_Process.BeginInvoke(new Action(() => pb_Process.Value = i));
            }
            pb_Process.BeginInvoke(new Action(() => pb_Process.Value = 0));
        }

        bool isEntityFile(string fileName)
        {
            fileName = fileName.Substring(fileName.LastIndexOf('/') + 1);
            string[] entityName = { "krixi.entity", "hammerstorm.entity", "hantumon.entity", "hiro.entity", "kunas.entity", "nomad.entity", "pollywogpriest.entity", "voodoo.entity", "hero.entity" };

            //string[] exceptionName = { "projectile_hero.entity", "state_hero.entity" };

            //for (int i = 0; i < exceptionName.Length; i++)
            //{
            //    if (fileName == exceptionName[i])
            //    {
            //        return false;
            //    }
            //}

            for (int i = 0; i < entityName.Length; i++)
            {
                if (fileName == entityName[i])
                //if (fileName.Contains(entityName[i]))
                {
                    return true;
                }
            }
            return false;
        }

        bool isTexturesfile(string fileName)
        {
            string[] iconName = { "icon.dds", "hero.dds" };

            string[] exceptionName = { "ability" };

            for (int i = 0; i < exceptionName.Length; i++)
            {
                if (fileName.Contains(exceptionName[i]))
                {
                    return false;
                }
            }
            fileName = fileName.Substring(fileName.LastIndexOf('/') + 1);
            for (int i = 0; i < iconName.Length; i++)
            {
                if (fileName == iconName[i])
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            convert();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteFunction();
            MessageBox.Show("Done!!!");
        }

        void DeleteFunction()
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete old files?", "Alert!", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            if (Directory.Exists("extract\\heroes"))
            {
                Directory.Delete("extract\\heroes", true);
            }
            if (Directory.Exists("extract\\00000000"))
            {
                Directory.Delete("extract\\00000000", true);
            }
        }

        void GetDiff()
        {
            StreamReader readCount = new StreamReader("code\\count");
            int currentVersion = int.Parse(readCount.ReadLine());
            readCount.Close();
            StreamReader versionRead = new StreamReader("code\\" + currentVersion);

            string readline;
            while ((readline = versionRead.ReadLine()) != null)
            {
                versionCode.Add(readline);
            }

            List<string> matchString = new List<string>();

            for (int i = 0; i < currentCode.Count; i++)
            {
                for (int j = 0; j < versionCode.Count; j++)
                {
                    if (currentCode[i] == versionCode[j])
                    {
                        matchString.Add(currentCode[i]);
                    }
                }
            }
            List<string> saveCode = new List<string>();

            for (int i = 0; i < currentCode.Count; i++)
            {
                saveCode.Add(currentCode[i]);
            }

            for (int i = 0; i < matchString.Count; i++)
            {
                currentCode.Remove(matchString[i]);
            }
            while (currentCode.Contains(""))
	        {
	            currentCode.Remove("");
	        }
            if (currentCode.Count != 0)
            {
                currentVersion++;
                StreamWriter writeCount = new StreamWriter("code\\count");
                writeCount.WriteLine(currentVersion);
                writeCount.Close();

                StreamWriter writeCodeCurrent = new StreamWriter("code\\" + currentVersion.ToString());
                for (int i = 0; i < saveCode.Count; i++)
                {
                    writeCodeCurrent.WriteLine(saveCode[i]);
                }
                StreamWriter diff = new StreamWriter("code\\_diff");
                for (int i = 0; i < currentCode.Count; i++)
                {
                    diff.WriteLine(currentCode[i]);
                }
                diff.Close();
                writeCodeCurrent.Close();
            }
        }
        
        void LoadFunction()
        {
            fileToolStripMenuItem.DropDownItems[3].Visible = false;
            int countAvatar = 0;
            string[] m_Directories = Directory.GetFiles("extract\\heroes", "*.entity", SearchOption.AllDirectories);
            
            for (int i = 0; i < m_Directories.Length; i++)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(m_Directories[i]);
                XmlNode node = xmlDoc.DocumentElement.SelectSingleNode("/hero");

                ButtonHero b = new ButtonHero();
                string heroFolder = Path.GetDirectoryName(m_Directories[i]);
                heroFolder = heroFolder.Substring(heroFolder.LastIndexOf('\\') + 1);
                string iconPath;
                try
                {
                    iconPath = node.Attributes["icon"].Value;
                    iconPath = iconPath.Replace("tga", "png");
                    b.BackgroundImage = new Bitmap("extract\\00000000\\" + "heroes\\" + heroFolder + "\\" + iconPath);
                }
                catch (Exception)
                {
                    b.BackgroundImage = new Bitmap("unknown.png");
                }
                b.Size = new System.Drawing.Size(64, 64);
                b.BackgroundImageLayout = ImageLayout.Stretch;
                //b.Name = "ClientSpawnUnit " + node.Attributes["name"].Value + " 0 1 1 1700 1000";
                b.Code = "ClientSpawnUnit " + node.Attributes["name"].Value + " 0 1 1 1700 1000";
                b.Id = i;
                b.ListButtonHero = new List<ButtonHero>();
                b.HeroName = node.Attributes["name"].Value.Replace("Hero_", "");
                currentCode.Add("");
                currentCode.Add(b.Code);
                b.Click += new System.EventHandler(this.ButtonHero_Click);
                flowLayoutPanel1.Controls.Add(b);
                for (int j = 0; j < node.ChildNodes.Count; j++)
                {
                    if (node.ChildNodes[j].Name == "altavatar")
                    {
                        ButtonHero c = new ButtonHero();
                        try
                        {
                            iconPath = node.ChildNodes[j].Attributes["icon2"].Value.Replace("tga", "png");
                            c.BackgroundImage = new Bitmap("extract\\00000000\\" + "heroes\\" + heroFolder + "\\" + iconPath);
                        }
                        catch (Exception)
                        {

                            c.BackgroundImage = new Bitmap("unknown.png");
                        }
                        c.Size = new System.Drawing.Size(64, 64);
                        c.BackgroundImageLayout = ImageLayout.Stretch;
                        string avatarKey = node.ChildNodes[j].Attributes["key"].Value.Replace(node.Attributes["name"].Value + ".", "");
                        //c.Name = "ClientSpawnUnit " + node.Attributes["name"].Value + "." + avatarKey + " 0 1 1 1700 1000";
                        c.Code = "ClientSpawnUnit " + node.Attributes["name"].Value + "." + avatarKey + " 0 1 1 1700 1000";
                        c.Id = j;
                        c.ListButtonHero = null;
                        c.Click += new System.EventHandler(this.ButtonAvatar_Click);

                        currentCode.Add(c.Code);
                        //flowLayoutPanel1.Controls.Add(c);
                        countAvatar++;
                        b.ListButtonHero.Add(c);
                    } 
                }
            }
            lb_count.Text = "Number of Avatar: " + countAvatar;
            GetDiff();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadFunction();
        }
        private void ButtonHero_Click(object _obj, EventArgs e)
        {
            ButtonHero b = _obj as ButtonHero;
            tb_folderPath.Text = b.Code;
            flowLayoutPanel2.Controls.Clear();
            for (int i = 0; i < b.ListButtonHero.Count; i++)
            {
                flowLayoutPanel2.Controls.Add(b.ListButtonHero[i]);
            }
            Clipboard.SetText(tb_folderPath.Text);
        }

        private void ButtonAvatar_Click(object _obj, EventArgs e)
        {
            ButtonHero b = _obj as ButtonHero;
            tb_folderPath.Text = b.Code;
            Clipboard.SetText(tb_folderPath.Text);
        }

        private void pathToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangePath cp = new ChangePath();
            cp.ShowDialog();
        }

        private void pathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFunction();
            XmlDocument xmlDoc = new XmlDocument();
            
            
            xmlDoc.Load("path");

            XmlNode version = xmlDoc.SelectSingleNode("version");
            XmlNode SBT = version.SelectSingleNode("SBT");
            //Console.WriteLine(SBT.Attributes[0].Value);
            OpenFunction(SBT.Attributes[0].Value);

        }

        private void garenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFunction();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("path");

            XmlNode version = xmlDoc.SelectSingleNode("version");
            XmlNode Garena = version.SelectSingleNode("Garena");
            //Console.WriteLine(SBT.Attributes[0].Value);
            OpenFunction(Garena.Attributes[0].Value);
        }

        private void GetGameVersion()
        {
            //string exePath = @"C:\Users\Hieu\Documents\Heroes of Newerth (Garena)\game\console.log";

            //StreamReader reader = new StreamReader(exePath);

            //int countLine = 0;
            //string readLine;

            //while ((readLine = reader.ReadLine()) != null)
            //{
            //    countLine++;
            //    if (countLine == 5)
            //    {
            //        break;
            //    }
            //}

            //readLine = readLine.Replace("[", "");
            //readLine = readLine.Replace("]", "");

            //this.Text = "Game Version: " + readLine;
            //pictureBox1.Image = DevIL.DevIL.LoadBitmap(@"D:\icon.dds");
            //FileStream fs = new FileStream(@"D\:icon.dds",FileMode.Open);
            
           
           // DDSImage im = new DDSImage(File.ReadAllBytes(@"D:\icon.dds"));


            //Console.WriteLine(im.images.LongLength);
        }

        private void superBetaTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFunction();
            XmlDocument xmlDoc = new XmlDocument();


            xmlDoc.Load("path");

            XmlNode version = xmlDoc.SelectSingleNode("version");
            XmlNode SBT = version.SelectSingleNode("Super");
            //Console.WriteLine(SBT.Attributes[0].Value);
            OpenFunction(SBT.Attributes[0].Value);
        }

        private void tb_folderPath_TextChanged(object sender, EventArgs e)
        {
            //if (tb_folderPath.Text == "")
            //{
            //    for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            //    {
            //        ButtonHero b = flowLayoutPanel1.Controls[i] as ButtonHero;
            //        b.Visible = true;
            //    }
            //    return;
            //}
            //flowLayoutPanel2.Controls.Clear();
            //for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            //{
            //    ButtonHero b = flowLayoutPanel1.Controls[i] as ButtonHero;
            //    if (!b.HeroName.Contains(tb_folderPath.Text))
            //    {
            //        b.Visible = false;
            //    }
            //}
        }
    }
}
