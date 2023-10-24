using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_uygulaması2_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            int kaldi = 0, duz = 0, tesekkur = 0, takdir = 0;
            lbNotlar.Items.Clear();
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
               int puan = rnd.Next(0,100);
               lbNotlar.Items.Add(puan);
                kaldi = 0;
                duz = 0;
                tesekkur = 0;
                takdir = 0;
            }
        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            int kaldi = 0, duz = 0, tesekkur = 0, takdir = 0;
            for (int i = 0; i < lbNotlar.Items.Count; i++)
            {
                int puan = Convert.ToInt32(lbNotlar.Items[i]); // i sırasındaki notu alır.
                if (puan <50)
                {
                    kaldi++;
                }
                else if (puan >=50 && puan <80)
                {
                    duz++;
                }
                else if (puan >=80 && puan <90)
                {
                    tesekkur++;
                }
                else if (puan >= 90 && puan < 100)
                {
                    takdir++;
                }

                lblKalan.Text = "kalan öğrenci:" + kaldi;
                lblDuz.Text = "düz geçen öğrenci:" + duz;
                lblTesekkur.Text = "teşekkür alan öğrenci:" + tesekkur;
                lblTakdir.Text = "takdir alan öğrenci:" + takdir;

                btnDurum.Enabled = false;
            }
        }
    }
}
