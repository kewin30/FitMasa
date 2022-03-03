using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FitMasa
{
    public partial class Produkt : Form
    {
        public event EventHandler<double[]> DodanoProdukt;

        public Produkt()
        {
            InitializeComponent();
        }

        public double[] kalorie = new double[4];
        public double[] bialko = new double[4];
        public double[] wegl = new double[4];
        public double[] tluszcze = new double[4];
        async Task Wyszukaj()
        {

            string nazwa = txtWyszukaj.Text;
            string[] przechowaj = new string[5];
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync($"https://api.edamam.com/auto-complete?app_id=fa3fe418&app_key=3b1045711693696631113ac592759468&q={nazwa}&limit=2");
                var json = await result.Content.ReadAsStringAsync();
                var output = JsonConvert.DeserializeObject<List<dynamic>>(json);
                for (int i = 0; i <= 4; i++)
                {
                    przechowaj[i] = output[i];
                }
            }

            //Pobranie danych

            using (var httpClient = new HttpClient())
            {
                /*var zapytanie1 = await httpClient.GetAsync($"https://api.edamam.com/api/food-database/v2/parser?app_id=fa3fe418&app_key=3b1045711693696631113ac592759468&ingr={przechowaj[0]}&nutrition-type=cooking");
                var zapytanie2 = await httpClient.GetAsync($"https://api.edamam.com/api/food-database/v2/parser?app_id=fa3fe418&app_key=3b1045711693696631113ac592759468&ingr={przechowaj[1]}&nutrition-type=cooking");
                var zapytanie3 = await httpClient.GetAsync($"https://api.edamam.com/api/food-database/v2/parser?app_id=fa3fe418&app_key=3b1045711693696631113ac592759468&ingr={przechowaj[2]}&nutrition-type=cooking");
                var zapytanie4 = await httpClient.GetAsync($"https://api.edamam.com/api/food-database/v2/parser?app_id=fa3fe418&app_key=3b1045711693696631113ac592759468&ingr={przechowaj[3]}&nutrition-type=cooking");


                var json1 = await zapytanie1.Content.ReadAsStringAsync();
                var json2 = await zapytanie2.Content.ReadAsStringAsync();
                var json3 = await zapytanie3.Content.ReadAsStringAsync();
                var json4 = await zapytanie4.Content.ReadAsStringAsync();*/



                var zapytanie = new dynamic[5];
                var json = new dynamic[5];


                for (int i = 0; i <= 4; i++)
                {
                    zapytanie[i] = await httpClient.GetAsync($"https://api.edamam.com/api/food-database/v2/parser?app_id=fa3fe418&app_key=3b1045711693696631113ac592759468&ingr={przechowaj[i]}&nutrition-type=cooking");
                    json[i] = await zapytanie[i].Content.ReadAsStringAsync();

                }

                Root posts1 = JsonConvert.DeserializeObject<Root>(json[0]);
                Root posts2 = JsonConvert.DeserializeObject<Root>(json[1]);
                Root posts3 = JsonConvert.DeserializeObject<Root>(json[2]);
                Root posts4 = JsonConvert.DeserializeObject<Root>(json[3]);
                lblProdukt1.Text = posts1.parsed[0].food.label;
                lblKcal.Text = "Kcal:"+posts1.parsed[0].food.nutrients.ENERC_KCAL.ToString();
                lblBialko.Text = "Bialko:"+posts1.parsed[0].food.nutrients.PROCNT.ToString();
                lblWegl.Text = "Weglowodany:"+posts1.parsed[0].food.nutrients.CHOCDF.ToString();
                lblTluszcze.Text = "Tluszcze:"+posts1.parsed[0].food.nutrients.FAT.ToString();

                lblProdukt2.Text = posts2.parsed[0].food.label;
                lblKcal2.Text = "Kcal:"+posts2.parsed[0].food.nutrients.ENERC_KCAL.ToString();
                lblBialko2.Text = "Bialko:" + posts2.parsed[0].food.nutrients.PROCNT.ToString();
                lblWegl2.Text = "Weglowodany:" + posts2.parsed[0].food.nutrients.CHOCDF.ToString();
                lblTluszcze2.Text = "Tluszcze:" + posts2.parsed[0].food.nutrients.FAT.ToString();

                lblProdukt3.Text = posts3.parsed[0].food.label;
                lblKcal3.Text = "Kcal:"+ posts3.parsed[0].food.nutrients.ENERC_KCAL.ToString();
                lblBialko3.Text = "Bialko:" + posts3.parsed[0].food.nutrients.PROCNT.ToString();
                lblWegl3.Text = "Weglowodany:" + posts3.parsed[0].food.nutrients.CHOCDF.ToString();
                lblTluszcze3.Text = "Tluszcze:" + posts3.parsed[0].food.nutrients.FAT.ToString();

                lblProdukt4.Text = posts4.parsed[0].food.label;
                lblKcal4.Text = "Kcal:"+ posts4.parsed[0].food.nutrients.ENERC_KCAL.ToString();
                lblBialko4.Text = "Bialko:" + posts4.parsed[0].food.nutrients.PROCNT.ToString();
                lblWegl4.Text = "Weglowodany:" + posts4.parsed[0].food.nutrients.CHOCDF.ToString();
                lblTluszcze4.Text = "Tluszcze:" + posts4.parsed[0].food.nutrients.FAT.ToString();

                kalorie[0] = posts1.parsed[0].food.nutrients.ENERC_KCAL/100;
                kalorie[1] = posts2.parsed[0].food.nutrients.ENERC_KCAL/100;
                kalorie[2] = posts3.parsed[0].food.nutrients.ENERC_KCAL/100;
                kalorie[3] = posts4.parsed[0].food.nutrients.ENERC_KCAL/100;

                bialko[0] = posts1.parsed[0].food.nutrients.PROCNT/100;
                bialko[1] = posts2.parsed[0].food.nutrients.PROCNT/100;
                bialko[2] = posts3.parsed[0].food.nutrients.PROCNT/100;
                bialko[3] = posts4.parsed[0].food.nutrients.PROCNT/100;

                wegl[0] = posts1.parsed[0].food.nutrients.CHOCDF/100;
                wegl[1] = posts2.parsed[0].food.nutrients.CHOCDF/100;
                wegl[2] = posts3.parsed[0].food.nutrients.CHOCDF/100;
                wegl[3] = posts4.parsed[0].food.nutrients.CHOCDF/100;

                tluszcze[0] = posts1.parsed[0].food.nutrients.FAT/100;
                tluszcze[1] = posts2.parsed[0].food.nutrients.FAT/100;
                tluszcze[2] = posts3.parsed[0].food.nutrients.FAT/100;
                tluszcze[3] = posts4.parsed[0].food.nutrients.FAT/100;

            }
        }
       
        private void btnSprawdz_Click(object sender, EventArgs e)
        {
            Wyszukaj();
        }


        public class Nutrients
        {
            public double ENERC_KCAL { get; set; }
            public double PROCNT { get; set; }
            public double FAT { get; set; }
            public double CHOCDF { get; set; }
            public double FIBTG { get; set; }
        }

        public class Food
        {
            public string foodId { get; set; }
            public string label { get; set; }
            public Nutrients nutrients { get; set; }
            public string category { get; set; }
            public string categoryLabel { get; set; }
            public string image { get; set; }
        }

        public class Parsed
        {
            public Food food { get; set; }
        }

        public class Root
        {
            public string text { get; set; }
            public List<Parsed> parsed { get; set; }
        }

        private void btnStronaGlowna_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void automat(CheckBox x, NumericUpDown y, int i)
        {
                if (x.Checked == false)
                {
                    kalorie[i] = 0;
                    bialko[i] = 0;
                    wegl[i] = 0;
                    tluszcze[i] = 0;
                }
                else
                {
                    kalorie[i] = Math.Round(kalorie[i] * Convert.ToDouble(y.Value),2);
                    bialko[i] = Math.Round(bialko[i] * Convert.ToDouble(y.Value),2);
                    wegl[i] = Math.Round(wegl[i] * Convert.ToDouble(y.Value),2);
                    tluszcze[i] = Math.Round(tluszcze[i] * Convert.ToDouble(y.Value),2);
                }
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            automat(check1, num1, 0);
            automat(check2, num2, 1);
            automat(check3, num3, 2);
            automat(check4, num4, 3);
            this.Close();
            this.DodanoProdukt?.Invoke(this, new double[] { kalorie[0], bialko[0], wegl[0], tluszcze[0]});
            this.DodanoProdukt?.Invoke(this, new double[] { kalorie[1], bialko[1], wegl[1], tluszcze[1]});
            this.DodanoProdukt?.Invoke(this, new double[] { kalorie[2], bialko[2], wegl[2], tluszcze[2]});
            this.DodanoProdukt?.Invoke(this, new double[] { kalorie[3], bialko[3], wegl[3], tluszcze[3]});


            /* if (check1.Checked == false)
             {
                 kalorie[0] = 0;
                 bialko[0] = 0;
                 wegl[0] = 0;
                 tluszcze[0] = 0;
             }
             else
             {
                 kalorie[0] = kalorie[0] + Convert.ToDouble(num1.Value);
                 bialko[0] = bialko[0] + Convert.ToDouble(num1.Value);
                 wegl[0] = wegl[0] + Convert.ToDouble(num1.Value);
                 tluszcze[0] = tluszcze[0] + Convert.ToDouble(num1.Value);
             }
             if (check2.Checked == false)
             {
                 kalorie[1] = 0;
                 bialko[1] = 0;
                 wegl[1] = 0;
                 tluszcze[1] = 0;
             }
             else
             {
                 kalorie[0] = kalorie[0] + Convert.ToDouble(num1.Value);
                 bialko[0] = bialko[0] + Convert.ToDouble(num1.Value);
                 wegl[0] = wegl[0] + Convert.ToDouble(num1.Value);
                 tluszcze[0] = tluszcze[0] + Convert.ToDouble(num1.Value);
             }
             if (check3.Checked == false)
             {
                 kalorie[2] = 0;
                 bialko[2] = 0;
                 wegl[2] = 0;
                 tluszcze[2] = 0;
             }
             if (check4.Checked == false)
             {
                 kalorie[3] = 0;
                 bialko[3] = 0;
                 wegl[3] = 0;
                 tluszcze[3] = 0;
             }*/
        }

        private void btnZamknij_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
