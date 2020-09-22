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
            int noweSaldo;
            Int32.TryParse(saldoBox.Text, out noweSaldo);
            noweSaldo -= Int32.Parse(stawkaBox.Text);
            if(noweSaldo < 0)
            {
                MessageBox.Show("Jesteś biedny, wybijaj!", "Bieda", MessageBoxButtons.OK);
                return;
            }
            saldoBox.Text = noweSaldo.ToString();
            foreach (PictureBox pictureBox in boxy)
            {
                int r = rnd.Next(99);
                if (r < 25) pictureBox.Image = obrazki[0];
                if (r >= 25 && r < 50) pictureBox.Image = obrazki[1];
                if (r >= 50 && r < 65) pictureBox.Image = obrazki[2];
                if (r >= 65 && r < 77) pictureBox.Image = obrazki[3];
                if (r >= 77 && r < 86) pictureBox.Image = obrazki[4];
                if (r >= 86 && r < 91) pictureBox.Image = obrazki[5];
                if (r >= 91 && r < 96) pictureBox.Image = obrazki[6];
                if (r >= 96 && r < 100) pictureBox.Image = obrazki[7];
            }
            Sprawdz();
        }

        private void RollButtonClick(object sender, EventArgs e)
        {
            Roll();
        }
        private int Mnoznik(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            int mnoznik = 0;
            if(pb1.Image == pb2.Image && pb2.Image == pb3.Image) //wszystkie takie same
            {
                if (pb1.Image == obrazki[0] || pb1.Image == obrazki[1]) mnoznik = 1;
                if (pb1.Image == obrazki[2]) mnoznik = 2;
                if (pb1.Image == obrazki[3]) mnoznik = 3;
                if (pb1.Image == obrazki[4]) mnoznik = 4;
                if (pb1.Image == obrazki[5]) mnoznik = 5;
            }
            if(pb1.Image == obrazki[6] || pb2.Image == obrazki[6] || pb3.Image == obrazki[6]) // jest wild 
            {
                if(pb1.Image == obrazki[6])
                {
                    if(pb2.Image == pb3.Image)
                    {
                        if (pb2.Image == obrazki[0] || pb2.Image == obrazki[1]) mnoznik = 1;
                        if (pb2.Image == obrazki[2]) mnoznik = 2;
                        if (pb2.Image == obrazki[3]) mnoznik = 3;
                        if (pb2.Image == obrazki[4]) mnoznik = 4;
                        if (pb2.Image == obrazki[5]) mnoznik = 5;
                    }
                }
                if (pb2.Image == obrazki[6])
                {
                    if (pb1.Image == pb3.Image)
                    {
                        if (pb1.Image == obrazki[0] || pb1.Image == obrazki[1]) mnoznik = 1;
                        if (pb1.Image == obrazki[2]) mnoznik = 2;
                        if (pb1.Image == obrazki[3]) mnoznik = 3;
                        if (pb1.Image == obrazki[4]) mnoznik = 4;
                        if (pb1.Image == obrazki[5]) mnoznik = 5;
                    }
                }
                if (pb3.Image == obrazki[6])
                {
                    if (pb2.Image == pb1.Image)
                    {
                        if (pb2.Image == obrazki[0] || pb2.Image == obrazki[1]) mnoznik = 1;
                        if (pb2.Image == obrazki[2]) mnoznik = 2;
                        if (pb2.Image == obrazki[3]) mnoznik = 3;
                        if (pb2.Image == obrazki[4]) mnoznik = 4;
                        if (pb2.Image == obrazki[5]) mnoznik = 5;
                    }
                }
            }
            return mnoznik;
        }
        private void Sprawdz()
        {
            int mnoznik = 0;
            PictureBox pb1;
            PictureBox pb2;
            PictureBox pb3;
            //sprawdzanie rzędów
            for (int i = 0; i <= 2; i++)
            {
                pb1 = tableLayoutPanel1.GetControlFromPosition(0, i) as PictureBox;
                pb2 = tableLayoutPanel1.GetControlFromPosition(1, i) as PictureBox;
                pb3 = tableLayoutPanel1.GetControlFromPosition(2, i) as PictureBox;
                mnoznik += Mnoznik(pb1, pb2, pb3);
            }
            //skosy
            pb1 = tableLayoutPanel1.GetControlFromPosition(0, 0) as PictureBox;
            pb2 = tableLayoutPanel1.GetControlFromPosition(1, 1) as PictureBox;
            pb3 = tableLayoutPanel1.GetControlFromPosition(2, 2) as PictureBox;
            mnoznik += Mnoznik(pb1, pb2, pb3);
            pb1 = tableLayoutPanel1.GetControlFromPosition(2, 0) as PictureBox;
            pb2 = tableLayoutPanel1.GetControlFromPosition(1, 1) as PictureBox;
            pb3 = tableLayoutPanel1.GetControlFromPosition(0, 2) as PictureBox;
            mnoznik += Mnoznik(pb1, pb2, pb3);
            //policzony mnoznik
            if (mnoznik > 0)
            {
                int wygrana = 0;
                Int32.TryParse(stawkaBox.Text, out wygrana);
                wygrana *= mnoznik;
                wygranaBox.Text = wygrana.ToString();
                int saldo = 0;
                Int32.TryParse(saldoBox.Text, out saldo);
                saldoBox.Text = (saldo + wygrana).ToString();
            }
            else wygranaBox.Text = "0";
            
        }

        private void StawkaPlusButtonClick(object sender, EventArgs e)
        {
            int nowastawka = 0;
            Int32.TryParse(stawkaBox.Text, out nowastawka);
            nowastawka ++;
            stawkaBox.Text = nowastawka.ToString();
        }

        private void StawkaMinusButtonClick(object sender, EventArgs e)
        {
            int nowastawka = 0;
            Int32.TryParse(stawkaBox.Text, out nowastawka);
            nowastawka--;
            if (nowastawka < 1) nowastawka = 1;
            stawkaBox.Text = nowastawka.ToString();
        }
    }
}
