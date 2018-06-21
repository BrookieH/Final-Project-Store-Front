using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Final_Project_Store_Front.Properties
{
    public partial class StoreFront : UserControl
    {
        public StoreFront()
        {
            InitializeComponent();
            Refresh();
        }

        private void comeinButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Open = new SoundPlayer(Properties.Resources.Open);
            Open.Play();

            System.Threading.Thread.Sleep(100);

            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen sf = new GameScreen();
            f.Controls.Add(sf);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Close = new SoundPlayer(Properties.Resources.Exit);
            Close.Play();

            System.Threading.Thread.Sleep(220);

            Application.Exit();
        }

        private void StoreFront_Paint(object sender, PaintEventArgs e)
        {

            //Brush
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush purpleBrush = new SolidBrush(Color.Lavender);
            SolidBrush blueBrush = new SolidBrush(Color.LightBlue);

            //Pens

            Pen bluePen = new Pen(Color.LightBlue, 5);
            Pen GreenPen = new Pen(Color.GreenYellow, 3);

            //Prices Side bar background
            e.Graphics.FillRectangle(blackBrush, 550, 250, 320, 270);

            //Flower Design
            e.Graphics.DrawLine(GreenPen, 135, 507, 135, 290);

            e.Graphics.FillEllipse(blueBrush, 95, 255, 34, 34);
            e.Graphics.FillEllipse(blueBrush, 140, 255, 34, 34);
            e.Graphics.FillEllipse(blueBrush, 118, 231, 34, 34);
            e.Graphics.FillEllipse(blueBrush, 118, 279, 34, 34);
            e.Graphics.FillEllipse(purpleBrush, 124, 260, 24, 24);

        }
    }
}
