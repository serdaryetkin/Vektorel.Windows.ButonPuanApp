using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Vektorel.UtilityLib;

namespace Vektorel.Windows.ButonPuanApp
{

    public partial class Form2 : Form
    {
        private Form1 form1;
        Random rnd = new Random();
        Button btn = new Button();
        int sure = 5;
        int count = 0;
        List<int> skorlar = new List<int>();
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void ButonKacir(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - btn.Width), rnd.Next(this.ClientSize.Height - btn.Height));

        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            btn1.Location = new Point(rnd.Next(this.ClientSize.Width - btn1.Width), rnd.Next(this.ClientSize.Height - btn1.Height));
        }

        private string butontext(object button)
        {
            btn.Text = rnd.Next(50).ToString();
            return btn.Text;
        }
        private void TmrSure_Tick(object sender, EventArgs e)
        {
            sure--;
            this.Text = sure.ToString();
            if (sure == 0)
            {
                skorlar.Add(count);
                tmrSure.Stop();
                DialogResult cvp = MessageBox.Show($"Süreniz doldu.Puanınız:{count}\nYeniden Oynamak İstiyor musunuz?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cvp == DialogResult.Yes)
                {
                    sure = 3;
                    count = 0;
                    butontext(btn1);
                    this.Size = new Size(300, 300);
                    tmrSure.Start();
                }
                else
                {
                    int maxscore = MaxScore(skorlar);
                    DosyaIslemleri.DosyaYazdir($"{DateTime.Now} tarihinde en yüksek skorunuz:{maxscore}", "skorlar.txt");
                    MessageBox.Show($"Oyun bitti.En yüksek skorunuz:{maxscore}");
                    btn1.Text = ":)";
                    btn1.Enabled = false;
                }
            }

            int MaxScore(List<int> skorlar)
            {
                int max = 0;
                if (skorlar.Count != 0)
                {
                    foreach (int item in skorlar)
                    {
                        if (item > max)
                        {
                            max = item;
                        }
                    }
                }
                return max;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
                tmrSure.Start();
        }

        
    }
}
