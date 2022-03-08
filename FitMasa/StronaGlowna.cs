using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitMasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnBMI_BMR_Click(object sender, EventArgs e)
        {
            BMI_BMR bmi_bmr = new BMI_BMR();
            bmi_bmr.Show();
            this.Hide();
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            progress.Show();
            this.Hide();
        }

        private void btnDania_Click(object sender, EventArgs e)
        {
            Dania dania = new Dania();
            dania.Show();
            this.Hide();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
        private double kalorieS = 0;
        private double wegleS = 0;
        private double tluszczeS = 0;
        private double bialkoS = 0;
        public void DodajSniadanie(object sender, double[] makro)
        {
            this.Show();
            kalorieS += makro[0];
            bialkoS += makro[1];
            wegleS += makro[2];
            tluszczeS += makro[3];

            lKcalL.Text = "Kalorie: " + kalorieS.ToString();
            lWeglS.Text = "Weglowodany: " + wegleS.ToString();
            lTlusS.Text = "Tluszcze: " + tluszczeS.ToString();
            lBialkS.Text = "Bialko: " + bialkoS.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*double kalorie = Convert.ToDouble(Produkt.kalorie[0] + Produkt.kalorie[1]+ Produkt.kalorie[2] + Produkt.kalorie[3]);
            double wegle = Convert.ToDouble(Produkt.wegl[0] + Produkt.wegl[1]+ Produkt.wegl[2] + Produkt.wegl[3]);
            double tluszcze = Convert.ToDouble(Produkt.tluszcze[0] + Produkt.tluszcze[1]+ Produkt.tluszcze[2] + Produkt.tluszcze[3]);
            double bialko = Convert.ToDouble(Produkt.bialko[0] + Produkt.bialko[1]+ Produkt.bialko[2] + Produkt.bialko[3]);

            lKcalL.Text = "Kalorie: "+kalorie.ToString();
            lWeglS.Text = "Weglowodany: "+wegle.ToString();
            lTlusS.Text = "Tluszcze: "+tluszcze.ToString();
            lBialkS.Text= "Bialko: "+bialko.ToString();*/
        }

        private void btnDodajO_Click(object sender, EventArgs e)
        {
            Produkt produkt = new Produkt();
            produkt.DodanoProdukt += DodajSniadanie;

            this.Hide();
            produkt.Show();
        }

        private void btnDodajS_Click_1(object sender, EventArgs e)
        {
           Produkt produkt = new Produkt();
           produkt.DodanoProdukt += DodajSniadanie;

            this.Hide();
            produkt.Show();
        }

        private void btnDodajK_Click(object sender, EventArgs e)
        {
            Produkt produkt = new Produkt();
            produkt.DodanoProdukt += DodajSniadanie;

            this.Hide();
            produkt.Show();
        }

        private void btnDodajDS_Click(object sender, EventArgs e)
        {
            Produkt produkt = new Produkt();
            produkt.DodanoProdukt += DodajSniadanie;

            this.Hide();
            produkt.Show();
        }

        private void btnDodajP_Click(object sender, EventArgs e)
        {
            Produkt produkt = new Produkt();
            produkt.DodanoProdukt += DodajSniadanie;

            this.Hide();
            produkt.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void DodajListe(object sender, double[] makro)
        {
            this.Show();
            tescik[0] = makro[0];
            lblSniadN.Text = tescik[0].ToString();

        }
        public List<double> tescik = new List<double>();
        private void TEST_Click(object sender, EventArgs e)
        {
            Produkt produkt = new Produkt();
            produkt.listaEvent += DodajListe;
        }
    }
}
