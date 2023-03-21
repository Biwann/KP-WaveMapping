using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Model
{
    public class WaveManager
    {
        private static WaveManager singlton = null;

        private WaveManager() { }
        public static WaveManager GetInstance()
        {
            if (singlton == null)
                singlton = new WaveManager();
            return singlton;
        }

        public List<Wave> waves = new List<Wave>();
        int timerInterval;
        float speed;
        uint radius;

        float functionTime = 0;
        float waveFreq;
        float wavePhase;

        public Point[] GetFuncPoints(int pictureWidth, int pictureHeight)
        {
            float time = 1f / 100;
            var width = pictureWidth / 2;
            Point[] points = new Point[width + 1];
            for (int i = 0; i <= width; i++)
            {
                double y = Math.Sin(waveFreq * (functionTime - (width - i) * time) + wavePhase);
                points[i] = new Point(i , (int)(pictureHeight / 2 - y * pictureHeight / 2));
            }
            return points;
        }
        public float GetFuncTime()
        {
            return functionTime;
        }
        public void Reset()
        {
            functionTime = 0;
        }
        public void Update(int _timerInterval, float _speed, uint _radius)
        {
            timerInterval = _timerInterval;
            speed = _speed;
            radius = _radius;
        }
        public void Update(float _waveFreq, float _wavePhase)
        {
            waveFreq = _waveFreq;
            wavePhase = _wavePhase;
        }
        public void Update(int _timerInterval, float _speed, uint _radius, float _waveFreq, float _wavePhase)
        {
            timerInterval = _timerInterval;
            speed = _speed;
            radius = _radius;
            waveFreq = _waveFreq;
            wavePhase = _wavePhase;
        }

        public void CheckExtremums()
        {
            float time = (float)timerInterval / 1000f;
            float derivativeWas = waveFreq * (float)Math.Cos(waveFreq * (functionTime) + wavePhase);
            float derivativeNow = waveFreq * (float)Math.Cos(waveFreq * (functionTime + time) + wavePhase);
            float eps = (float)10e-6;

            if (Math.Abs(derivativeWas) < eps)
                derivativeWas = 0;
            if (Math.Abs(derivativeNow) < eps)
                derivativeNow = 0;

            if (Math.Sign(derivativeWas) != Math.Sign(derivativeNow))
            {
                if (Math.Sign(derivativeWas) < 0 || Math.Sign(derivativeNow) > 0)
                    waves.Add(new Wave(false));
                else if (Math.Sign(derivativeWas) > 0 || Math.Sign(derivativeNow) < 0)
                    waves.Add(new Wave(true));
            }

            functionTime += time;
            //Debug.WriteLine(functionTime);
        }
        public void CalculateWaves()
        {
            for (int i = 0; i < waves.Count; )
            {
                Wave wave = waves[i];
                wave.Position += speed / 1000f * (float)timerInterval / radius;
                if (waves[i].Position >= Math.PI)
                    waves.RemoveAt(i);
                else
                    i++;
            }
        }
    }
    public class Wave
    {
        public float Position = 0;
        readonly private bool isMax;

        public Wave(bool _isMax)
        {
            this.isMax = _isMax;
        }

        public bool IsMax()
        {
            return isMax;
        }
        
    }

    public class Ellipse
    {
        Graphics g;
        public Bitmap bitmap;

        public Ellipse(PictureBox pictureBoxImage)
        {
            bitmap = new Bitmap(pictureBoxImage.Width, pictureBoxImage.Height);
            this.g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
        }

        public PictureBox Draw_Ellipse(PictureBox pictureBoxImage, uint Radius)
        {
            renew_bitmap(pictureBoxImage);
            g.DrawLine(Pens.Black, 0, (bitmap.Size.Height) / 2, bitmap.Size.Width, (bitmap.Size.Height) / 2);
            g.DrawLine(Pens.Black, bitmap.Size.Width / 2, 0, (bitmap.Size.Width) / 2, bitmap.Size.Height);
            g.DrawLine(Pens.Black, bitmap.Size.Width / 2, 0, (bitmap.Size.Width) / 2, bitmap.Size.Height);
            g.DrawLine(Pens.Black, bitmap.Size.Width / 2 + 80, 0, (bitmap.Size.Width) / 2 - 80, bitmap.Size.Height);
            g.DrawEllipse(Pens.Black, (bitmap.Size.Width) / 2 - Radius, (bitmap.Size.Height) / 2 - Radius, 2 * Radius, 2 * Radius);
            g.DrawEllipse(Pens.Black, (bitmap.Size.Width) / 2 - Radius, (bitmap.Size.Height) / 2 - Radius / 2, 2 * Radius, Radius);

            pictureBoxImage.Image = bitmap;

            return pictureBoxImage;
        }

        PictureBox renew_bitmap(PictureBox pictureBoxImage)
        {
            pictureBoxImage.Image = null;
            pictureBoxImage.BackColor = Color.White;
            bitmap.Dispose();
            g.Clear(Color.White);
            bitmap = new Bitmap(pictureBoxImage.Width, pictureBoxImage.Height);
            this.g = Graphics.FromImage(bitmap);
            pictureBoxImage.Image = bitmap;
            return pictureBoxImage;
        }
    }
}
