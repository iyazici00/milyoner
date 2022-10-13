using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimRezilOlmakIster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttona_Click(object sender, EventArgs e)
        {
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            Buttonnextquestion.Enabled = true;
            buttonA.Enabled = false;
            seçim = 0;

        }

        private void buttonb_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            Buttonnextquestion.Enabled = true;
            buttonB.Enabled = false;
            seçim = 1;

        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            buttonB.Enabled = true;
            buttonA.Enabled = true;
            buttonD.Enabled = true;
            Buttonnextquestion.Enabled = true;
            buttonC.Enabled = false;
            seçim = 2;



        }

        private void buttond_Click(object sender, EventArgs e)
        {
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonA.Enabled = true;
            Buttonnextquestion.Enabled = true;
            buttonD.Enabled = false;
            seçim = 3;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearBoard();
        }



        internal int ClickCount = 0;
        internal int cevap = 0;
        internal int seçim;
        private void Buttonnextquestion_Click(object sender, EventArgs e)
        {
            ClearBoard();
            ClickCount++;
            if (cevap == seçim)
            {
                IncreaseTrue();
            }
            else
            {
                IncreaseFalse();
            }
            if (ClickCount == 5)
            {
                panel1.Visible = false;
                panel2.Visible = false;

                MessageBox.Show("Oyun Bitti puanınız: " + label13.Text);
                this.Close();
            }
            switch (ClickCount)
            {
                case 1:
                    GetSoru2();
                    break;
                case 2:
                    GetSoru3();
                    break;
                case 3:
                    GetSoru4();
                    break;
                case 4:
                    GetSoru5();
                    break;
                default:
                    break;
            }
        }

        private void GetSoru2()
        {

            richTextBox1.Text = "Türkiyenin başkenti neresidir?";
            buttonA.Text = "ANKARA";
            buttonB.Text = "İSTANBUL";
            buttonC.Text = "BURSA";
            buttonD.Text = "BAYBURT";
            cevap = 0;
            
            label1.Text = Convert.ToString(int.Parse(label1.Text) + 1);
        }
        private void GetSoru3()
        {
            richTextBox1.Text = "İstanbulun en kalabalık ilçesi neresidir?";
            buttonA.Text = "Sultanbeyli";
            buttonB.Text = "Esenyurt";
            buttonC.Text = "Kadıköy";
            buttonD.Text = "Çekmeköy";
            cevap = 1;
            
            label1.Text = Convert.ToString(int.Parse(label1.Text) + 1);
        }
        private void GetSoru4()
        {
            richTextBox1.Text = "Rezillik kelimesinde kaç adet 'i' harfi vardır?";
            buttonA.Text = "2";
            buttonB.Text = "1";
            buttonC.Text = "4";
            buttonD.Text = "5";
            cevap = 0;
            
            label1.Text = Convert.ToString(int.Parse(label1.Text) + 1);
        }
        private void GetSoru5()
        {
            richTextBox1.Text = "GO TO kullanırsak ne olur?";
            buttonA.Text = "Hepsi";
            buttonB.Text = "Ünlü bir yazılımcı olursunuz";
            buttonC.Text = "Hiçbirşey olmaz";
            buttonD.Text = "Rezil olursunuz";
            cevap = 3;

            label1.Text = Convert.ToString(int.Parse(label1.Text) + 1);
        }
        private void ClearBoard()
        {
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonA.Enabled = true;
            buttonD.Enabled = true;
            Buttonnextquestion.Enabled = false;
        }
        private void IncreaseTrue()
        {
            label2.Text = Convert.ToString(int.Parse(label2.Text) + 1);
            label13.Text = Convert.ToString(int.Parse(label13.Text) + 5);
        }
        private void IncreaseFalse()
        {
            label3.Text = Convert.ToString(int.Parse(label3.Text) + 1);
            label13.Text = Convert.ToString(int.Parse(label13.Text) - 5);
        }



    }
}




