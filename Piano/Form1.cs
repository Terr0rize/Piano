using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\C.wav");
            player.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\D_Drum.wav");
            player.Play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\G_Drum.wav");
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\D.wav");
            player.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\E.wav");
            player.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\F.wav");
            player.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\G.wav");
            player.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\A.wav");
            player.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\B.wav");
            player.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\C1.wav");
            player.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\D1.wav");
            player.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\E1.wav");
            player.Play(); ;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\F1.wav");
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\C_Drum.wav");
            player.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\F_Drum.wav");
            player.Play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\Bb_Drum.wav");
            player.Play();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\C_Drum.wav");
            player.Play();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\MusicNote\D_Drum.wav");
            player.Play();
        }
    }
}
