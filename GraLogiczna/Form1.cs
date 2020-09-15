using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraLogiczna
{
    public partial class Form1 : Form
    {
        private List<Image> obrazki;
        private List<PictureBox> boxy;
        private Random rnd;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            obrazki = new List<Image>();
            boxy = new List<PictureBox>();
            rnd = new Random();
            obrazki.Add(GraLogiczna.Properties.Resources.logo0);
            obrazki.Add(GraLogiczna.Properties.Resources.logo1);
            obrazki.Add(GraLogiczna.Properties.Resources.logo2);
            obrazki.Add(GraLogiczna.Properties.Resources.logo3);
            obrazki.Add(GraLogiczna.Properties.Resources.logo4);
            obrazki.Add(GraLogiczna.Properties.Resources.logo5);
            obrazki.Add(GraLogiczna.Properties.Resources.bonus);
            obrazki.Add(GraLogiczna.Properties.Resources.wild);
            for (int x = 0; x<=2; x++) { 
                for(int y = 0; y <=2; y++) {
                    int r = rnd.Next(obrazki.Count);
                    PictureBox pb = new PictureBox {
                        Dock = DockStyle.Fill,
                        //Image = obrazki[r],
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    tableLayoutPanel1.Controls.Add(pb, x, y);
                    boxy.Add(pb);
                }
            }
            Roll();
            
        }

        private void Roll()
        {
            foreach (PictureBox pictureBox in boxy)
            {
                int r = rnd.Next(obrazki.Count);
                pictureBox.Image = obrazki[r];
            }
        }

        private void RollButtonClick(object sender, EventArgs e)
        {
            Roll();
        }
    }
}
