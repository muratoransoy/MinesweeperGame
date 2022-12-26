using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuratOransoyMayın
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList mayinlar = new ArrayList();
        int gPuan = 0;

        private void button1_Click(object sender, EventArgs e)
        {
          
            Button tiklanan = (Button)sender;
            tiklanan.Text = "*".ToString();
            if (int.Parse(tiklanan.Tag.ToString()) == -1)

            {
                tiklanan.BackColor = Color.Red;
                for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                {
                    if (int.Parse(flowLayoutPanel1.Controls[i].Tag.ToString()) == -1)
                    {
                        tiklanan.Text = "*".ToString();
                        flowLayoutPanel1.Controls[i].Enabled = false;
                        flowLayoutPanel1.Controls[i].BackColor = Color.Red;

                    }
                    else
                    {
                        tiklanan.Text = "*".ToString();
                        flowLayoutPanel1.Controls[i].Enabled = false;
                        flowLayoutPanel1.Controls[i].Text = flowLayoutPanel1.Controls[i].Tag.ToString();
                    }
                }
            }
            else
            {
                tiklanan.Text = "*".ToString();
                tiklanan.BackColor = Color.Green;
                gPuan += int.Parse(tiklanan.Tag.ToString());
                label1.Text = "Puan: " + gPuan;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mayinlar.Clear();
            flowLayoutPanel1.Controls.Clear();
            int sayi = 0;
            Random rast = new Random();
            for (int i = 0; i < 4; i++)
            {
            uret:
                sayi = rast.Next(0,50);
                if (mayinlar.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }
            }

            for (int i = 0; i < 50; i++)
            {
                Button button = new Button();
                button.Click += button1_Click;
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 20);
                }
                button.Size = new Size(25, 25);
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mayinlar.Clear();
            flowLayoutPanel1.Controls.Clear();
            int sayi = 0;
            Random rast = new Random();
            for (int i = 0; i < 4; i++)
            {
            uret:
                sayi = rast.Next(0, 50);
                if (mayinlar.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }
            }

            for (int i = 0; i < 50; i++)
            {
                Button button = new Button();
                button.Click += button1_Click;
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 20);
                }
                button.Size = new Size(25, 25);
                flowLayoutPanel1.Controls.Add(button);
            }
            label1.Text = "";
        }
    }
    }

