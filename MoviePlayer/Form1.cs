using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviePlayer
{
    public partial class Form1 : Form
    {
        string videoPath, videoTitle;
        bool isMute=false;
        public Form1()
        {
            InitializeComponent();
            wmp.uiMode = "none";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, Filter="MP4 File|*.mp4|All File|*.*" };
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                videoPath = ofd.FileName;
                videoTitle = ofd.SafeFileName;
                wmp.URL = videoPath;
                lblTitle.Text = videoTitle;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.play();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.previous();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.fastReverse();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.fastForward();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.next();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (isMute)
            {
                btnMute.BackgroundImage = MoviePlayer.Properties.Resources.mute_96px;
                wmp.settings.mute = false;
                isMute = false;
            }
            else
            {
                btnMute.BackgroundImage = MoviePlayer.Properties.Resources.sound_96px;
                wmp.settings.mute = true;
                isMute = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.stop();
        }
    }
}
