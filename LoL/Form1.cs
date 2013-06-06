using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace LoL
{
    public partial class MainForm : Form
    {
        List<Champs> champions;
        Champs currentChamp;

        DateTime redStart;
        DateTime blueStart;
        DateTime dragonStart;
        DateTime baronStart;

        int redTime;
        int blueTime;
        int dragonTime;
        int baronTime;
        
        const int MYACTION_HOTKEY_DRAGON = 1;
        const int MYACTION_HOTKEY_BARON = 2;
        const int MYACTION_HOTKEY_RED = 3;
        const int MYACTION_HOTKEY_BLUE = 4;
        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public MainForm()
        {
            InitializeComponent();
            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_RED, 0, (int)Keys.F1);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_BLUE, 0, (int)Keys.F2);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_DRAGON, 0, (int)Keys.F3);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_BARON, 0, (int)Keys.F4);

            champions = new List<Champs>();
            LoadChampions();
            updatelbSelectChamp("");
            timer1.Start();
            pbCover.Image = Image.FromFile("startimage.jpg");
        }

        private void tbChampionName_TextChanged(object sender, EventArgs e)
        {
            string name = tbChampionName.Text.Trim() ;
            updatelbSelectChamp(name);
        }

        private void updatelbSelectChamp(string name)
        {
            lbSelectChamp.Items.Clear();
            lbSelectChamp.SelectionMode = SelectionMode.One;
            if (name == "") champions.ForEach(x => lbSelectChamp.Items.Add(x.getName()));
            else champions.ForEach(x =>
            {
                if (x.getName().ToUpper().Contains(name.ToUpper())) lbSelectChamp.Items.Add(x.getName());
            });
        }

        private void LoadChampions()
        {
            buttonOffline.Enabled = false;
            buttonOnline.BackColor = Color.SpringGreen;
            buttonCounters.BackColor = Color.LightGray;
            buttonSkills.BackColor = Color.LightGray;
            buttonBuilds.BackColor = Color.LightGray;
            try
            {
                string[] champInfo = System.IO.File.ReadAllLines("Champions.txt");
                for (int i = 0; i < champInfo.Length; i++)
                {
                    Champs newChamp = new Champs();
                    newChamp.setChampStats(champInfo[i]);
                    champions.Add(newChamp);
                }
            }
            catch
            {
                MessageBox.Show("Exception is caught(Load Champions)");
            }
        }

        private void buttonSelectChamp_Click(object sender, EventArgs e)
        {
            pbCover.Image = null;

            try
            {
                string name = lbSelectChamp.SelectedItem.ToString();
                currentChamp = new Champs();
                champions.ForEach(x =>
                    {
                        if (x.findChamp(name) != null)
                        {
                            currentChamp = x;
                        }

                    });
                pbChampImage.Image = Image.FromFile("Images/" + name + ".jpg");
                updateTextBoxes(currentChamp);
                pbCover.Image = Image.FromFile("Cover Images/" + name + ".jpg");
                
                pbCover.Visible = true;
                wbInformation.Visible = false;
            }

            catch
            {

            }

        }


        private string[] getInformation(string directory, string name)
        {
            string[] champInfo = System.IO.File.ReadAllLines(directory + name + ".txt");
            return champInfo;
        }

        private void updateTextBoxes(Champs champ)
        {
            tbCurrentChamp.Text = champ.name;
            tbType.Text = champ.charType;
            tbHealth.Text = champ.health;
            tbAD.Text = champ.adPercent;
            tbAP.Text = champ.apPercent;
            tbDifficulty.Text = champ.difficulty;
            tbIPCost.Text = champ.ipCost;
            tbRPCost.Text = champ.rpCost;
            tbReleaseDate.Text = champ.releaseDate;
        }
        private string getName()
        {
            return lbSelectChamp.SelectedItem.ToString();
        }


        //Timers
        /***********************************************************************************/
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_DRAGON)
            {
                dragonStart = DateTime.Now.AddMinutes(6.0);
                dragonTime = 355;
                timerDragon.Start();
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_RED)
            {
                redStart = DateTime.Now.AddMinutes(5.0);
                redTime = 295;
                timerRed.Start();
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_BLUE)
            {
                blueStart = DateTime.Now.AddMinutes(5.0);
                blueTime = 295;
                timerBlue.Start();
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_BARON)
            {
                baronStart = DateTime.Now.AddMinutes(7.0);
                baronTime = 415;
                timerBaron.Start();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString();
        }

        private void timerRed_Tick(object sender, EventArgs e)
        {
            redTime--;
            if (redTime >= 0 && cbEnableTimer.Checked)
            {
                if (redTime == 10)
                {
                    using (SoundPlayer player = new SoundPlayer("Sounds/redbuff.wav"))
                    {
                        player.Play();
                    }
                }
                else if (redTime < 60)
                {
                    tbRedTimer.ForeColor = Color.Red;
                }
                else tbRedTimer.ForeColor = Color.Lime;
                tbRedTimer.Text = (redStart - DateTime.Now).Minutes.ToString() + ":" + (redStart - DateTime.Now).Seconds.ToString();
            }
            else
            {
                timerRed.Stop();
                tbRedTimer.Text = "0:00";
            }
        }

        private void timerBlue_Tick(object sender, EventArgs e)
        {
            blueTime--;
            if (blueTime >= 0 && cbEnableTimer.Checked)
            {
                if (blueTime == 10)
                {
                    using (SoundPlayer player = new SoundPlayer("Sounds/bluebuff.wav"))
                    {
                        player.Play();
                    }
                }
                else if (blueTime < 60)
                {
                    tbBlueTimer.ForeColor = Color.Red;
                }
                else tbBlueTimer.ForeColor = Color.Lime;
                tbBlueTimer.Text = (blueStart - DateTime.Now).Minutes.ToString() + ":" + (blueStart - DateTime.Now).Seconds.ToString();
            }
            else
            {
                timerBlue.Stop();
                tbBlueTimer.Text = "0:00";
            }
        }

        private void timerDragon_Tick(object sender, EventArgs e)
        {
            dragonTime--;
            if (dragonTime >= 0 && cbEnableTimer.Checked)
            {
                if (dragonTime == 10)
                {
                    using (SoundPlayer player = new SoundPlayer("Sounds/dragon.wav"))
                    {
                        player.Play();
                    }
                }
                else if (dragonTime < 60)
                {
                    tbDragonTimer.ForeColor = Color.Red;
                }
                else tbDragonTimer.ForeColor = Color.Lime;
                tbDragonTimer.Text = (dragonStart - DateTime.Now).Minutes.ToString() + ":" + (dragonStart - DateTime.Now).Seconds.ToString();
            }
            else
            {
                timerDragon.Stop();
                tbDragonTimer.Text = "0:00";
            }
        }

        private void timerBaron_Tick(object sender, EventArgs e)
        {
            baronTime--;
            if (baronTime >= 0 && cbEnableTimer.Checked)
            {
                if (baronTime == 10)
                {
                    using (SoundPlayer player = new SoundPlayer("Sounds/baron.wav"))
                    {
                        player.Play();
                    }
                }
                else if (baronTime < 60)
                {
                    tbBaronTimer.ForeColor = Color.Red;
                }
                else tbBaronTimer.ForeColor = Color.Lime;
                tbBaronTimer.Text = (baronStart - DateTime.Now).Minutes.ToString() + ":" + (baronStart - DateTime.Now).Seconds.ToString();
            }
            else
            {
                timerBaron.Stop();
                tbBaronTimer.Text = "0:00";
            }
        }

        private void buttonTimerHelp_Click(object sender, EventArgs e)
        {
            TimerHelp help = new TimerHelp();
            help.ShowDialog();
        }
        /*---------------------------------------------------------------------------------*/

        //Web Browser Stuff
        /***********************************************************************************/

        private void buttonBuilds_Click(object sender, EventArgs e)
        {
            try
            {
                Uri url = new Uri(@currentChamp.buildsURL);
                wbInformation.ScriptErrorsSuppressed = true;
                navigatePage(url);
                buttonCounters.BackColor = Color.LightGray;
                buttonSkills.BackColor = Color.LightGray;
                buttonBuilds.BackColor = Color.LightBlue;
            }
            catch
            {
                MessageBox.Show("You must select a champion!");
            }


            //lbInformation.Items.AddRange(getInformation("Champions Builds/", getName()));
        }

        private void buttonCounters_Click(object sender, EventArgs e)
        {

            try
            {
                Uri url = new Uri(@currentChamp.counterURL);
                wbInformation.ScriptErrorsSuppressed = true;
                navigatePage(url);
                buttonCounters.BackColor = Color.LightBlue;
                buttonSkills.BackColor = Color.LightGray;
                buttonBuilds.BackColor = Color.LightGray;
            }
            catch
            {
                MessageBox.Show("You must select a champion!");
            }
        }

        private void buttonSkills_Click(object sender, EventArgs e)
        {
            try
            {
                Uri url = new Uri(@currentChamp.skillsURL);
                wbInformation.ScriptErrorsSuppressed = true;
                navigatePage(url);
                buttonSkills.BackColor = Color.LightBlue;
                buttonCounters.BackColor = Color.LightGray;
                buttonBuilds.BackColor = Color.LightGray;
            }
            catch
            {
                MessageBox.Show("You must select a champion!");
            }
        }

        private void navigatePage(Uri url)
        {
            pbCover.Visible = false;
            wbInformation.Visible = true;
            wbInformation.Navigate(url);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            wbInformation.Navigate("about:blank");
            wbInformation.Visible = false;
            pbCover.Visible = true;
            buttonCounters.BackColor = Color.LightGray;
            buttonSkills.BackColor = Color.LightGray;
            buttonBuilds.BackColor = Color.LightGray;
            //put photo here
        }
        /*--------------------------------------------------------------------------------*/
        
        //buttons for exit and minimize
        /**********************************************************************************/
        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pbMinimize.Image = Image.FromFile("minimize2.jpg");
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.Image = Image.FromFile("minimize.jpg");
        }


        private void pbExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbExitButton_MouseEnter(object sender, EventArgs e)
        {
            pbExitButton.Image = Image.FromFile("close2.jpg");
        }
        private void pbExitButton_MouseLeave(object sender, EventArgs e)
        {
            pbExitButton.Image = Image.FromFile("close.jpg");
        }


        /**********************************************************************************/



        //Handler for panel1 movement
        /**********************************************************************************/
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        /**********************************************************************************/

    }
}
