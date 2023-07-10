using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            y1.Clear();
            y2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yaz1 = int.Parse(y1.Text);
            int yaz2 = int.Parse(y2.Text);
            


            int topla;
           
            float islem;
           
            int sonuc;





            sonuc = yaz1 + yaz2;


            if (rgec.Checked == true)
            {

                if (sonuc / 2 == 10)
                {

                    s1.Text = "80";
                    s2.Text = "80";
                    

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    
                    topla = soz1 + soz2 + sonuc;
                   
                    islem = (float)topla / 4;
                  
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";
                    


                }
                else if (sonuc / 2 == 11)
                {

                    s1.Text = "80";
                    s2.Text = "80";
                 

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                
                    topla = soz1 + soz2 + sonuc;
                   
                    islem = (float)topla / 4;
                   
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";
                    


                }
                else if (sonuc / 2 == 12)
                {

                    s1.Text = "75";
                    s2.Text = "80";
          

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                
                    topla = soz1 + soz2 + sonuc;
                  
                    islem = (float)topla / 4;
                    
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";
                   


                }
                else if (sonuc / 2 == 13)
                {

                    s1.Text = "75";
                    s2.Text = "80";
          

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                
                    topla = soz1 + soz2 + sonuc;
                  
                    islem = (float)topla / 4;
              
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";
                   


                }
                else if (sonuc / 2 == 14)
                {

                    s1.Text = "75";
                    s2.Text = "80";
                

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    
                    topla = soz1 + soz2 + sonuc;
               
                    islem = (float)topla / 4;
                  
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";
                   


                }
                else if (sonuc / 2 == 15)
                {

                    s1.Text = "75";
                    s2.Text = "75";


                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);

                    topla = soz1 + soz2 + sonuc;

                    islem = (float)topla / 4;

                    sonuc1.Text = islem.ToString() + "  ile Geçti.";



                }
                else if (sonuc / 2 == 16)
                {

                    s1.Text = "74";
                    s2.Text = "74";


                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);

                    topla = soz1 + soz2 + sonuc;

                    islem = (float)topla / 4;

                    sonuc1.Text = islem.ToString() + "  ile Geçti.";



                }
                else if (sonuc / 2 == 17)
                {

                    s1.Text = "70";
                    s2.Text = "75";


                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);

                    topla = soz1 + soz2 + sonuc;

                    islem = (float)topla / 4;

                    sonuc1.Text = islem.ToString() + "  ile Geçti.";



                }
                else if (sonuc / 2 == 18)
                {

                    s1.Text = "70";
                    s2.Text = "75";


                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);

                    topla = soz1 + soz2 + sonuc;

                    islem = (float)topla / 4;

                    sonuc1.Text = islem.ToString() + "  ile Geçti.";



                }
                else if (sonuc / 2 == 19)
                {

                    s1.Text = "70";
                    s2.Text = "70";


                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);

                    topla = soz1 + soz2 + sonuc;

                    islem = (float)topla / 4;

                    sonuc1.Text = islem.ToString() + "  ile Geçti.";



                }
                else if (sonuc / 2 == 20)
                {

                    s1.Text = "70";
                    s2.Text = "70";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 21)
                {

                    s1.Text = "70";
                    s2.Text = "70";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 22)
                {

                    s1.Text = "65";
                    s2.Text = "70";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 23)
                {

                    s1.Text = "65";
                    s2.Text = "70";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 24)
                {

                    s1.Text = "60";
                    s2.Text = "75";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 25)
                {

                    s1.Text = "65";
                    s2.Text = "65";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 26)
                {

                    s1.Text = "65";
                    s2.Text = "65";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 27)
                {

                    s1.Text = "60";
                    s2.Text = "65";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 28)
                {

                    s1.Text = "60";
                    s2.Text = "65";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 29)
                {

                    s1.Text = "55";
                    s2.Text = "65";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 30)
                {

                    s1.Text = "60";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 31)
                {

                    s1.Text = "60";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 32)
                {

                    s1.Text = "55";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 33)
                {

                    s1.Text = "55";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 34)
                {

                    s1.Text = "50";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 35)
                {

                    s1.Text = "55";
                    s2.Text = "55";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 36)
                {

                    s1.Text = "55";
                    s2.Text = "55";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 37)
                {

                    s1.Text = "50";
                    s2.Text = "55";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 38)
                {

                    s1.Text = "50";
                    s2.Text = "55";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 39)
                {

                    s1.Text = "50";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 40)
                {

                    s1.Text = "50";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 41)
                {

                    s1.Text = "50";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 42)
                {

                    s1.Text = "45";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 43)
                {

                    s1.Text = "45";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 44)
                {

                    s1.Text = "45";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 45)
                {

                    s1.Text = "45";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 46)
                {

                    s1.Text = "45";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 47)
                {

                    s1.Text = "45";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 48)
                {

                    s1.Text = "45";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 49)
                {

                    s1.Text = "45";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 50)
                {

                    s1.Text = "50";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 51)
                {

                    s1.Text = "50";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 52)
                {

                    s1.Text = "50";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 53)
                {

                    s1.Text = "50";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 54)
                {

                    s1.Text = "50";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 55)
                {

                    s1.Text = "50";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 56)
                {

                    s1.Text = "50";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 57)
                {

                    s1.Text = "50";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 58)
                {

                    s1.Text = "50";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 59)
                {

                    s1.Text = "50";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 60)
                {

                    s1.Text = "60";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 61)
                {

                    s1.Text = "60";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 62)
                {

                    s1.Text = "60";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 63)
                {

                    s1.Text = "60";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 64)
                {

                    s1.Text = "60";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 65)
                {

                    s1.Text = "65";
                    s2.Text = "65";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 66)
                {

                    s1.Text = "65";
                    s2.Text = "65";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 67)
                {

                    s1.Text = "65";
                    s2.Text = "65";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 68)
                {

                    s1.Text = "65";
                    s2.Text = "65";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 69)
                {

                    s1.Text = "65";
                    s2.Text = "70";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 70)
                {

                    s1.Text = "70";
                    s2.Text = "70";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 71)
                {

                    s1.Text = "70";
                    s2.Text = "70";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 72)
                {

                    s1.Text = "70";
                    s2.Text = "70";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 73)
                {

                    s1.Text = "70";
                    s2.Text = "70";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 74)
                {

                    s1.Text = "70";
                    s2.Text = "75";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 75)
                {

                    s1.Text = "85";
                    s2.Text = "85";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 76)
                {

                    s1.Text = "80";
                    s2.Text = "85";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 77)
                {

                    s1.Text = "90";
                    s2.Text = "95";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 78)
                {

                    s1.Text = "90";
                    s2.Text = "95";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 79)
                {

                    s1.Text = "85";
                    s2.Text = "95";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }

                else if (sonuc / 2 == 80)
                {

                    s1.Text = "85";
                    s2.Text = "95";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";


                }

                else if (sonuc / 2 == 81)
                {

                    s1.Text = "90";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";


                }
                else if (sonuc / 2 == 82)
                {

                    s1.Text = "85";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";


                }
                else if (sonuc / 2 == 83)
                {

                    s1.Text = "85";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";


                }
                else if (sonuc / 2 == 84)
                {

                    s1.Text = "85";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";


                }
                else if (sonuc / 2 == 85)
                {

                    s1.Text = "85";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";


                }
                else if (sonuc / 2 == 86)
                {

                    s1.Text = "85";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";


                }
                else if (sonuc / 2 == 87)
                {

                    s1.Text = "85";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";


                }
                else if (sonuc / 2 == 88)
                {

                    s1.Text = "85";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";


                }
                else if (sonuc / 2 == 89)
                {

                    s1.Text = "85";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";


                }
                else if (sonuc / 2 == 90)
                {

                    s1.Text = "85";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 91)
                {

                    s1.Text = "85";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 92)
                {

                    s1.Text = "85";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 93)
                {

                    s1.Text = "85";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 94)
                {

                    s1.Text = "85";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 95)
                {

                    s1.Text = "95";
                    s2.Text = "95";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 96)
                {

                    s1.Text = "95";
                    s2.Text = "95";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 97)
                {

                    s1.Text = "95";
                    s2.Text = "95";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 98)
                {

                    s1.Text = "95";
                    s2.Text = "95";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 99)
                {

                    s1.Text = "95";
                    s2.Text = "95";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
                else if (sonuc / 2 == 100)
                {

                    s1.Text = "95";
                    s2.Text = "100";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Geçti.";

                }
           

            }
            else if (rkal.Checked == true)
            {

                if (sonuc / 2 == 10)
                {

                    s1.Text = "60";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 11)
                {

                    s1.Text = "60";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 12)
                {

                    s1.Text = "60";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 13)
                {

                    s1.Text = "60";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 14)
                {

                    s1.Text = "60";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 15)
                {

                    s1.Text = "50";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 16)
                {

                    s1.Text = "50";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 17)
                {

                    s1.Text = "50";
                    s2.Text = "60";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 18)
                {

                    s1.Text = "45";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 19)
                {

                    s1.Text = "45";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }

                else if (sonuc / 2 == 20)
                {

                    s1.Text = "50";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 21)
                {

                    s1.Text = "50";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 22)
                {

                    s1.Text = "50";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 23)
                {

                    s1.Text = "45";
                    s2.Text = "55";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 24)
                {

                    s1.Text = "45";
                    s2.Text = "55";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 25)
                {

                    s1.Text = "45";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 26)
                {

                    s1.Text = "50";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 27)
                {

                    s1.Text = "40";
                    s2.Text = "50";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 28)
                {

                    s1.Text = "45";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 29)
                {

                    s1.Text = "45";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 30)
                {

                    s1.Text = "45";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 31)
                {

                    s1.Text = "45";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 32)
                {

                    s1.Text = "40";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 33)
                {

                    s1.Text = "40";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 34)
                {

                    s1.Text = "40";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 35)
                {

                    s1.Text = "40";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 36)
                {

                    s1.Text = "40";
                    s2.Text = "40";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 37)
                {

                    s1.Text = "40";
                    s2.Text = "40";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 38)
                {

                    s1.Text = "40";
                    s2.Text = "40";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 39)
                {

                    s1.Text = "30";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 40)
                {

                    s1.Text = "30";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 41)
                {

                    s1.Text = "30";
                    s2.Text = "45";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 42)
                {

                    s1.Text = "30";
                    s2.Text = "40";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 43)
                {

                    s1.Text = "30";
                    s2.Text = "40";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 44)
                {

                    s1.Text = "30";
                    s2.Text = "35";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }
                else if (sonuc / 2 == 45)
                {

                    s1.Text = "30";
                    s2.Text = "35";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 4;
                    sonuc1.Text = islem.ToString() + "  ile Kaldı.";

                }



            }
            else
            {

                MessageBox.Show("Lütfen Seçim Yapınız");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dokasoft.com");
        }
    }
}
