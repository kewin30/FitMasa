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
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        private void btnBMI_BMR_Click(object sender, EventArgs e)
        {
            BMI_BMR bmi_bmr = new BMI_BMR();
            bmi_bmr.Show();
            this.Hide();
        }

        private void btnStronaGlowna_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btnDodajPrzed_Click(object sender, EventArgs e)
        {
            OpenFileDialog zdjeciePrzed = new OpenFileDialog();
            zdjeciePrzed.ShowDialog();
            var sciezka = zdjeciePrzed.FileName;
            zdjPrzed.Image = Image.FromFile(sciezka);
        }

        private void btnDodajPo_Click(object sender, EventArgs e)
        {
            OpenFileDialog zdjeciePo = new OpenFileDialog();
            zdjeciePo.ShowDialog();
            var sciezka = zdjeciePo.FileName;
            zdjPo.Image = Image.FromFile(sciezka);
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
