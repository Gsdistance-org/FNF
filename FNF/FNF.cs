﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNF
{
    public partial class FNF : Form
    {
        public Random rng = new Random();
        public char r = '→';
        public char d = '↓';
        public char u = '↑';
        public char l = '←';
        public sbyte note = 0;
        public sbyte nextnote = 0;
        public bool notedone = false;
        public bool skip = false;
        public bool sounds = false;
        public BigInteger misses = 0;
        public BigInteger rigths = 0;
        public FNF()
        {
            InitializeComponent();
        }
        public void newnote()
        {
            switch (rng.Next(1,5))
            {
                case 1:
                    {
                        nextnote = 1;
                        button5.Text = r.ToString();
                        break;
                    }
                case 2:
                    {
                        nextnote = 2;
                        button5.Text = d.ToString();
                        break;
                    }
                case 3:
                    {
                        nextnote = 3;
                        button5.Text = u.ToString();
                        break;
                    }
                case 4:
                    {
                        nextnote = 4;
                        button5.Text = l.ToString();
                        break;
                    }

            }
            switch (note)
            {
                case 1:
                    {
                        button4push();
                        button6.Text = r.ToString();
                        break;
                    }
                case 2:
                    {
                        button3push();
                        button6.Text = d.ToString();
                        break;
                    }
                case 3:
                    {
                        button2push();
                        button6.Text = u.ToString();
                        break;
                    }
                case 4:
                    {
                        button1push();
                        button6.Text = l.ToString();
                        break;
                    }

            }
        }
        private void button1push()
        {
            button1.BackColor = Color.Green;
        }
        private void button2push()
        {
            button2.BackColor = Color.Green;
        }
        private void button3push()
        {
            button3.BackColor = Color.Green;
        }
        private void button4push()
        {
            button4.BackColor = Color.Green;
        }
        private void buttonallred()
        {
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
        }
        private void hideall()
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            label1.Hide();
            label2.Hide();
            menuStrip1.Hide();
        }
        private void hideothers()
        {
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
        }
        private void showothers()
        {
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            button11.Show();
            button12.Show();
        }
        private void showall()
        {
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            label1.Show();
            label2.Show();
            menuStrip1.Show();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sounds)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.left);
                player.Play();
            }
            if (note == 4)
            {
                buttonallred();
                button6.Text = "";
                note = 0;
                notedone = true;
                rigths++;
                nextnoteg();
            }
            else
            {
                misses++;
            }
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sounds)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.right);
                player.Play();
            }
            if (note == 1)
            {
                buttonallred();
                button6.Text = "";
                note = 0;
                notedone = true;
                rigths++;
                nextnoteg();
            }
            else
            {
                misses++;
            }
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sounds)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.up);
                player.Play();
            }
            if (note == 3)
            {
                buttonallred();
                button6.Text = "";
                note = 0;
                notedone = true;
                rigths++;
                nextnoteg();
            }
            else
            {
                misses++;
            }
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sounds)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.down);
                player.Play();
            }
            if (note == 2)
            {
                buttonallred();
                button6.Text = "";
                note = 0;
                notedone = true;
                rigths++;
                nextnoteg();
            }
            else
            {
                misses++;
            }
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            if (!skip)
            {
                if (!notedone)
                {
                    misses++;
                }
                notedone = false;
                note = nextnote;
                buttonallred();
                newnote();
            }
        }
        private void nextnoteg()
        {
            note = nextnote;
            newnote();
        }

        private void SpeedTick_Tick(object sender, EventArgs e)
        {
            label1.Text = "Rights:" + rigths;
            label2.Text = "Misses:" + misses;
        }

        private void FNF_Load(object sender, EventArgs e)
        {
            hideall();
            showothers();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tick.Enabled = true;
            tick.Interval = 900;
            hideothers();
            showall();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tick.Enabled = true;
            tick.Interval = 800;
            hideothers();
            showall();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tick.Enabled = true;
            tick.Interval = 700;
            hideothers();
            showall();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tick.Enabled = true;
            tick.Interval = 600;
            hideothers();
            showall();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tick.Enabled = true;
            tick.Interval = 500;
            hideothers();
            showall();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tick.Enabled = true;
            tick.Interval = 300;
            hideothers();
            showall();
        }

        private void FNF_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void soundsONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sounds)
            {
                sounds = false;
                soundsONToolStripMenuItem.Text = "Sounds OFF";
            }
            else
            {
                sounds = true;
                soundsONToolStripMenuItem.Text = "Sounds ON";
            }
        }
    }
}
