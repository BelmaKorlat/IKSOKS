using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezba2810
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int brojac { get; set; }
        private void NapraviPotez(object sender)
        {
            if(sender is Button)
            {
                var dugme = sender as Button;
                if (dugme.Text == String.Empty)
                {
                    if (brojac % 2 == 0)
                    {
                        dugme.Text = "X";
                    }
                    else
                    {
                        dugme.Text = "O";
                    }
                    if (brojac % 2 == 0)
                    {
                        label1.Text = Igrac1; 
                    }
                    else
                    {
                        label1.Text = Igrac2;
                    }
                }
            }
            if (KrajIgre())
                StatusDugmica(false);
            brojac++;
        }

        private void StatusDugmica(bool omoguceno, bool resettext = false, bool resetColor = false)
        {
            foreach (var control in Controls)
            {
                if (control is Button)
                {
                    var kontrola = control as Button;
                    if (kontrola != button10)
                    {
                        kontrola.Enabled = omoguceno;
                        if (resettext)
                            kontrola.Text = String.Empty;
                        if(resetColor)
                            kontrola.BackColor=default(Color);
                    }
                }
            }
            brojac = 0;
        }

        private bool KrajIgre()
        {
            return ProvjeriRed() || ProvjeriKolonu() || ProvjeriDijagonalu();
        }
        private bool Provjera(Button button1, Button button2, Button button3)
        {
            if(button1.Text != "" && button1.Text == button2.Text && button1.Text == button3.Text)
            {
                button1.BackColor = button2.BackColor = button3.BackColor = Color.DarkSlateBlue;
                return true;
            }
            return false;
        }

        private bool ProvjeriDijagonalu()
        {
            return Provjera(button1, button5, button9) ||
              Provjera(button3, button5, button7);
        }

        private bool ProvjeriKolonu()
        {
            return Provjera(button1, button4, button7) ||
              Provjera(button2, button5, button8) ||
              Provjera(button3, button6, button9);
        }

        private bool ProvjeriRed()
        {
            return Provjera(button1, button2, button3) ||
                Provjera(button4, button5, button6) ||
                Provjera(button7, button8, button9);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PonovnoUcitavanjeImena();
            StatusDugmica(true, true, true);
        }
        public string Igrac1 { get; set; }
        public string Igrac2 { get; set; }

        frmIgraci formica = new frmIgraci();
        private void PonovnoUcitavanjeImena()
        {
            formica.ShowDialog();
            Igrac1 = formica.Igrac1;
            Igrac2 = formica.Igrac2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PonovnoUcitavanjeImena();
        }
    }
}
