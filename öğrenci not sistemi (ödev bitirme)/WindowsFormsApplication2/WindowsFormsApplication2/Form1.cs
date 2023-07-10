using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sPw = (textpw1.Text);
            string sPw2 = (textpw2.Text);
            string sPw3 = (textpw3.Text);
            string sPw4 = (textpw4.Text);
            switch (sPw)
            {
            
                case "A813" :
                case "AQ17" :
                case "7S5B" :
                case "56BG" :
                case "JK25" :
                case "45BQ" :
                    break;
            }
    switch (sPw2){
                case "A13Q" :
                case "AQK2" :
                case "BH16" :
                case "C8BF" :
                case "D4AC" :
                case "F8LU" :
            
                break;
    }
    switch (sPw3){
                case "BCDA" :
                case "YL8Q" :
                case "YU1A" :
                case "FF18" :
                case "AKFE" :
                case "8KR1" :
            break;
    }

    switch (sPw4)
    {
        case "LYKT":
        case "F14U":
        case "FCBT":
        case "1A65":
        case "SL25":
        case "MD12":
            break;
    }
    if (sPw == "")
    {
        MessageBox.Show("1. Boşlukta Eksik Kod Girdiniz");
    }
    else  {
   
        }
    if (sPw2 == "")
    {
        MessageBox.Show("2. Boşlukta Eksik Kod Girdiniz");
    }
    else
    {
    
    }
    if (sPw3 == "")
    {
        MessageBox.Show("3. Boşlukta Eksik Kod Girdiniz");
    }
    else
    {
      
    }
   
            if (sPw4 == "")
    {
        MessageBox.Show("4. Boşlukta Eksik Kod Girdiniz");
    }
    else
    {
        sayfa ab = new sayfa();
        ab.Show();
        this.Hide();
        
    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
             }
        }
