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
    public partial class BMR : Form
    {
        public BMR()
        {
            InitializeComponent();
        }

        private void wynikBMR(double wynik)
        {
            if (rbtnZnikoma.Checked == true)
            {
                wynikL.Text = "Wynik BMR: " + wynik * 1.2;
            }
            else if (rbtnUmiarkowana.Checked == true)
            {
                wynikL.Text = "Wynik BMR: " + wynik * 1.55;
            }
            else if (rbtnMala.Checked == true)
            {
                wynikL.Text = "Wynik BMR: " + wynik * 1.375;
            }
            else if (rbtnDuza.Checked == true)
            {
                wynikL.Text = "Wynik BMR: " + wynik * 1.725;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int waga = Convert.ToInt32(numWaga.Value);
            int wzrost = Convert.ToInt32(numWzrost.Value);
            int wiek = Convert.ToInt32(numWiek.Value);
            if (rbtnK.Checked == true)
            {
                double wynik = 0;
                if (wiek >= 1 && wzrost >= 60 && waga >= 10)
                {
                    wynik = 655 + (9.6 * waga) + (1.8 * wzrost) - (4.7 * wiek);
                }
                if (rbtnTycie.Checked == true)
                {
                    wynikBMR(wynik + 150);
                }
                else if (rbtnUtrzymanie.Checked == true)
                {
                    wynikBMR(wynik);
                }
                else if (rbtnSchudnac.Checked == true)
                {
                    wynikBMR(wynik - 150);
                }

            }
            else if (rbtnM.Checked == true)
            {
                double wynik = 0;
                if (wiek >= 1 && wzrost >= 60 && waga >= 10)
                {
                    wynik = 66 + (13.7 * waga) + (5 * wzrost) - (6.8 * wiek);
                }
                if (rbtnTycie.Checked == true)
                {
                    wynikBMR(wynik + 200);
                }
                else if (rbtnUtrzymanie.Checked == true)
                {
                    wynikBMR(wynik);
                }
                else if (rbtnSchudnac.Checked == true)
                {
                    wynikBMR(wynik-200);
                }
            }
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
