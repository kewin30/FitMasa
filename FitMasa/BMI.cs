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
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            int waga = Convert.ToInt32(numWaga1.Value);
            double wzrost = Convert.ToInt32(numWzrost1.Value);
            double metry = wzrost / 100;
            double BMI = 0;
            BMI = waga / (metry * metry);
            if (BMI > 0 && BMI <= 18.4)
                wynikL.Text = $"Twoja wartosc BMI wynosi {Math.Round(BMI,2)}, masz niedowage!";
            else if(BMI > 18.5 && BMI <= 24.9)
                wynikL.Text = $"Twoja wartosc BMI wynosi {Math.Round(BMI, 2)}, masz wage prawidlowa";
            else if (BMI > 25 && BMI <= 29.9)
                wynikL.Text = $"Twoja wartosc BMI wynosi {Math.Round(BMI, 2)}, masz nadwage";
            else if (BMI > 30 && BMI <= 34.9)
                wynikL.Text = $"Twoja wartosc BMI wynosi {Math.Round(BMI, 2)}, masz otylosc!!";
            else if (BMI >= 35 )
                wynikL.Text = $"Twoja wartosc BMI wynosi {Math.Round(BMI, 2)}, masz skrajna otylosc!! Pojdz do lekarza";
        }

        private void btnStronaGlowna_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
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
    }
}
