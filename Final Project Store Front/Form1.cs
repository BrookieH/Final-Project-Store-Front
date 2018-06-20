using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Final_Project_Store_Front.Properties;

namespace Final_Project_Store_Front
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            StoreFront sf = new StoreFront();
            f.Controls.Add(sf);

        }
    }
}
