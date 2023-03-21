using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bitmap;
        public Ellipse ellipse;

        WaveManager waveManager = WaveManager.GetInstance();

        uint radius = 100;
        uint waveSpeed = 100;
        
        public Form1()
        {
            InitializeComponent();
            this.ellipse = new Model.Ellipse(this.pictureBoxImage);
            bitmap = new Bitmap(this.pictureBoxImage.Width, this.pictureBoxImage.Height);
            this.g = Graphics.FromImage(bitmap);
            pictureBoxImage = ellipse.Draw_Ellipse(pictureBoxImage, radius);
            timer1.Interval = 1000 / 50;  // 50 кадров в секунду
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void sTARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double freq;
            double phase;

            if (Double.TryParse(textBoxFreq.Text.Replace('.', ','), out freq) &&
                Double.TryParse(textBoxPhase.Text.Replace('.', ','), out phase))
            {
                if (comboBoxFunc.Text == "cos")
                    phase += 90;
                waveManager.Update(timer1.Interval, waveSpeed, radius, (float)freq,
                    ((float)phase * 2 * (float)Math.PI / 360f) % 720);
                if (!timer1.Enabled)
                {
                    timer1.Start();
                    CloseUI();
                    sTARTToolStripMenuItem.Text = "PAUSE";
                }
                else
                {
                    timer1.Stop();
                    sTARTToolStripMenuItem.Text = "START";
                }

            }
            else
            {
                if (!Double.TryParse(textBoxFreq.Text, out freq))
                    textBoxFreq.Text = "ERROR";
                if (!Double.TryParse(textBoxPhase.Text, out phase))
                    textBoxPhase.Text = "ERROR";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            waveManager.CheckExtremums();
            waveManager.CalculateWaves();
            RefreshImages();

            if (waveManager.waves.Count != 0 || waveManager.GetFuncTime() != 0)
            {
                CloseUI();
            }
            else
            {
                OpenUI();
                waveManager.Reset();
            }
        }
        private void pictureBoxImage_Paint(object sender, PaintEventArgs e)
        {   
            foreach (var wave in waveManager.waves)
            {
                var currentHeight = (float)Math.Sin(wave.Position) * radius * 2;
                Pen pen;
                if (!checkBoxMin.Checked && !wave.IsMax())
                    continue;
                if (!checkBoxMax.Checked && wave.IsMax())
                    continue;

                if (wave.Position < Math.PI / 2)
                {
                    if (wave.IsMax())
                    {
                        pen = Pens.Red;
                    }
                    else
                    {
                        pen = Pens.Blue;
                    }
                        
                }
                else
                {
                    if (!checkBoxSeeBack.Checked)
                        continue;
                    if (wave.IsMax())
                        pen = Pens.Green;
                    else
                        pen = Pens.Gray;
                }
                    
                e.Graphics.DrawEllipse(pen, pictureBoxImage.Width / 2 - currentHeight / 2, pictureBoxImage.Height / 2 - currentHeight / 2, currentHeight, currentHeight);

            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            radius = (uint)trackBar1.Value;
            labelRadius.Text = Convert.ToString(radius);
            this.pictureBoxImage = ellipse.Draw_Ellipse(pictureBoxImage, radius);
            pictureBoxImage.Refresh();
        }


        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / (int)numericUpDown3.Value;
            waveManager.Update(timer1.Interval, waveSpeed, radius);
        }

        private void comboBoxFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = comboBoxFunc.Text;
            textBoxWave_TextChanged(sender, e);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            waveSpeed = (uint)trackBar2.Value;
            try { labelSpeed.Text = "" + waveSpeed; }
            catch (FormatException) { Environment.Exit(0); }
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            waveManager.waves.Clear();
            waveManager.Reset();
            if (timer1.Enabled)
            {
                timer1.Stop();
                sTARTToolStripMenuItem.Text = "START";
            }
                
            OpenUI();
            RefreshImages();
        }

        void CloseUI()
        {
            trackBar1.Hide();
            trackBar2.Hide();
            textBoxFreq.ReadOnly = true;
            textBoxPhase.ReadOnly = true;
            //numericUpDown3.Enabled = false;
            /*checkBoxMax.Enabled = false;
            checkBoxMin.Enabled = false;
            checkBoxSeeBack.Enabled = false;*/
        }
        void OpenUI()
        {
            trackBar1.Show();
            trackBar2.Show();
            textBoxFreq.ReadOnly = false;
            textBoxPhase.ReadOnly = false;
            //numericUpDown3.Enabled = true;
            /*checkBoxMax.Enabled = true;
            checkBoxMin.Enabled = true;
            checkBoxSeeBack.Enabled = true;*/
        }

        void RefreshImages()
        {
            pictureBoxImage.Refresh();
            pictureBoxFunc.Refresh();
        }

        private void checkBoxMax_CheckedChanged(object sender, EventArgs e)
        {
            RefreshImages();
        }

        private void checkBoxMin_CheckedChanged(object sender, EventArgs e)
        {
            RefreshImages();
        }

        private void checkBoxSeeBack_CheckedChanged(object sender, EventArgs e)
        {
            RefreshImages();
        }

        private void pictureBoxFunc_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = e.Graphics;
            var width = pictureBoxFunc.Width;
            var height = pictureBoxFunc.Height;
            var points = waveManager.GetFuncPoints(width, height);
            
            g1.DrawLine(Pens.Red, new Point(0, 0), new Point(width, 0));
            g1.DrawLine(Pens.Blue, new Point(0, height - 1), new Point(width, height - 1));
            g1.DrawLine(Pens.Gray, new Point(0, height / 2), new Point(width, height / 2));
            g1.DrawLines(Pens.Black, points);
        }

        private void textBoxWave_TextChanged(object sender, EventArgs e)
        {
            double freq;
            double phase;

            if (Double.TryParse(textBoxFreq.Text.Replace('.', ','), out freq) &&
                Double.TryParse(textBoxPhase.Text.Replace('.', ','), out phase))
            {
                if (freq > 100)
                {
                    textBoxFreq.Text = "100";
                    freq = 100;
                }
                else if (freq < -100)
                {
                    textBoxFreq.Text = "-100";
                    freq = -100;
                }
                    
                if (comboBoxFunc.Text == "cos")
                    phase += 90;
                waveManager.Update((float)freq, ((float)phase * 2 * (float)Math.PI / 360f) % 720);
                pictureBoxFunc.Refresh();
            }
            
        }
    }
}
