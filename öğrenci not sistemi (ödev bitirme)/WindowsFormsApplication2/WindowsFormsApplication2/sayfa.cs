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
    public partial class sayfa : Form
    {
        public sayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void s1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            int yaz1 = int.Parse(y1.Text);
            int yaz2 = int.Parse(y2.Text);
            int yaz3 = int.Parse(y3.Text);
           

            int topla;
            float islem;
            int sonuc;




            
            sonuc = yaz1 + yaz2 + yaz3;
           
        
            if (rgec.Checked == true)
            {
                
                  
               
                 if(sonuc / 3 == 15){
                   
                    s1.Text = "90";
                    s2.Text = "90";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 5;
                    sonuc1.Text = islem.ToString() +  "  ile Geçti.";

                }
                              else if(sonuc / 3 == 16){
                   
                    s1.Text = "90";
                    s2.Text = "85";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 5;
                    sonuc1.Text = islem.ToString() +  "  ile Geçti.";

                
                              }
                 else if (sonuc / 3 == 17)
                 {

                     s1.Text = "87";
                     s2.Text = "87";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 18)
                 {

                     s1.Text = "85";
                     s2.Text = "85";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 19)
                 {

                     s1.Text = "85";
                     s2.Text = "85";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 20)
                 {

                     s1.Text = "80";
                     s2.Text = "85";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 21)
                 {

                     s1.Text = "80";
                     s2.Text = "80";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 22)
                 {

                     s1.Text = "80";
                     s2.Text = "80";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 23)
                 {

                     s1.Text = "80";
                     s2.Text = "80";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 24)
                 {

                     s1.Text = "75";
                     s2.Text = "80";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }

                else if (sonuc / 3 == 25)
                {

                    s1.Text = "70";
                    s2.Text = "80";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 5;
                    sonuc1.Text = islem.ToString() +  "  ile Geçti.";

                }
                 else if (sonuc / 3 == 26)
                 {

                     s1.Text = "70";
                     s2.Text = "75";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 27)
                 {

                     s1.Text = "70";
                     s2.Text = "75";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 28)
                 {

                     s1.Text = "70";
                     s2.Text = "70";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 29)
                 {

                     s1.Text = "70";
                     s2.Text = "70";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                    else if (sonuc / 3 == 30)
                {

                    s1.Text = "65";
                    s2.Text = "70";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 5;
                    sonuc1.Text = islem.ToString() +  "  ile Geçti.";
                    
                    }
                 else if (sonuc / 3 == 31)
                 {

                     s1.Text = "65";
                     s2.Text = "65";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 32)
                 {

                     s1.Text = "65";
                     s2.Text = "65";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 33)
                 {

                     s1.Text = "60";
                     s2.Text = "65";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 34)
                 {

                     s1.Text = "60";
                     s2.Text = "65";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 <= 35)
                 {

                     s1.Text = "60";
                     s2.Text = "60";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 36)
                 {

                     s1.Text = "60";
                     s2.Text = "60";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 37)
                 {

                     s1.Text = "55";
                     s2.Text = "60";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 38)
                 {

                     s1.Text = "55";
                     s2.Text = "55";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 39)
                 {

                     s1.Text = "55";
                     s2.Text = "55";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                    else if (sonuc / 3 == 40)
                {

                    s1.Text = "50";
                    s2.Text = "55";

                    int soz1 = int.Parse(s1.Text);
                    int soz2 = int.Parse(s2.Text);
                    topla = soz1 + soz2 + sonuc;
                    islem = (float)topla / 5;
                    sonuc1.Text = islem.ToString() +  "  ile Geçti.";
                    
                    }
                 else if (sonuc / 3 == 41)
                 {

                     s1.Text = "50";
                     s2.Text = "50";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 42)
                 {

                     s1.Text = "50";
                     s2.Text = "50";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 43)
                 {

                     s1.Text = "50";
                     s2.Text = "50";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 44)
                 {

                     s1.Text = "50";
                     s2.Text = "50";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 45)
                 {

                     s1.Text = "50";
                     s2.Text = "50";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 50)
                 {

                     s1.Text = "55";
                     s2.Text = "55";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 51)
                 {

                     s1.Text = "55";
                     s2.Text = "55";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 52)
                 {

                     s1.Text = "55";
                     s2.Text = "55";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 53)
                 {

                     s1.Text = "55";
                     s2.Text = "55";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 54)
                 {

                     s1.Text = "55";
                     s2.Text = "55";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }  
                 else if (sonuc / 3 == 55)
                    {

                        s1.Text = "55";
                        s2.Text = "60";

                        int soz1 = int.Parse(s1.Text);
                        int soz2 = int.Parse(s2.Text);
                        topla = soz1 + soz2 + sonuc;
                        islem = (float)topla / 5;
                        sonuc1.Text = islem.ToString() +  "  ile Geçti.";
                    
                    }
                 else if (sonuc / 3 == 56)
                 {

                     s1.Text = "55";
                     s2.Text = "55";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 57)
                 {

                     s1.Text = "55";
                     s2.Text = "55";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 58)
                 {

                     s1.Text = "55";
                     s2.Text = "60";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 59)
                 {

                     s1.Text = "55";
                     s2.Text = "55";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }  

                    else if (sonuc / 3 == 60)
                    {

                        s1.Text = "65";
                        s2.Text = "65";
                       
                        int soz1 = int.Parse(s1.Text);
                        int soz2 = int.Parse(s2.Text);
                        topla = soz1 + soz2 + sonuc;
                        islem = (float)topla / 5;
                        sonuc1.Text = islem.ToString() +  "  ile Geçti.";
                    
                    }

                 else if (sonuc / 3 == 61)
                 {

                     s1.Text = "65";
                     s2.Text = "65";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }

                 else if (sonuc / 3 == 62)
                 {

                     s1.Text = "65";
                     s2.Text = "65";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }

                 else if (sonuc / 3 == 63)
                 {

                     s1.Text = "65";
                     s2.Text = "65";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }

                 else if (sonuc / 3 == 64)
                 {

                     s1.Text = "65";
                     s2.Text = "65";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }


                 else if (sonuc / 3 == 65)
                 {

                     s1.Text = "65";
                     s2.Text = "70";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }

                 else if (sonuc / 3 == 66)
                 {

                     s1.Text = "65";
                     s2.Text = "70";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }

                 else if (sonuc / 3 == 67)
                 {

                     s1.Text = "65";
                     s2.Text = "70";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 68)
                 {

                     s1.Text = "65";
                     s2.Text = "70";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 69)
                 {

                     s1.Text = "65";
                     s2.Text = "70";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                    else if (sonuc / 3 == 70)
                    {

                        s1.Text = "75";
                        s2.Text = "75";

                        int soz1 = int.Parse(s1.Text);
                        int soz2 = int.Parse(s2.Text);
                        topla = soz1 + soz2 + sonuc;
                        islem = (float)topla / 5;
                        sonuc1.Text = islem.ToString() +  "  ile Geçti.";
                    
                    
                    }
                 else if (sonuc / 3 == 71)
                 {

                     s1.Text = "75";
                     s2.Text = "75";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 72)
                 {

                     s1.Text = "75";
                     s2.Text = "75";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 73)
                 {

                     s1.Text = "75";
                     s2.Text = "75";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 74)
                 {

                     s1.Text = "75";
                     s2.Text = "75";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }

                 else if (sonuc / 3 == 75)
                 {

                     s1.Text = "75";
                     s2.Text = "80";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 76)
                 {

                     s1.Text = "75";
                     s2.Text = "80";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 77)
                 {

                     s1.Text = "75";
                     s2.Text = "80";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 78)
                 {

                     s1.Text = "75";
                     s2.Text = "80";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                 else if (sonuc / 3 == 79)
                 {

                     s1.Text = "75";
                     s2.Text = "80";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";


                 }
                    else if (sonuc / 3 == 80)
                    {

                        s1.Text = "80";
                        s2.Text = "80";

                        int soz1 = int.Parse(s1.Text);
                        int soz2 = int.Parse(s2.Text);
                        topla = soz1 + soz2 + sonuc;
                        islem = (float)topla / 5;
                        sonuc1.Text = islem.ToString() + "  ile Geçti.";
                    
                    }
                 else if (sonuc / 3 == 81)
                 {

                     s1.Text = "80";
                     s2.Text = "80";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 82)
                 {

                     s1.Text = "80";
                     s2.Text = "80";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 83)
                 {

                     s1.Text = "80";
                     s2.Text = "80";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 84)
                 {

                     s1.Text = "80";
                     s2.Text = "80";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 85)
                 {

                     s1.Text = "80";
                     s2.Text = "80";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 85)
                 {

                     s1.Text = "85";
                     s2.Text = "85";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 86)
                 {

                     s1.Text = "85";
                     s2.Text = "85";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 87)
                 {

                     s1.Text = "85";
                     s2.Text = "85";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 88)
                 {

                     s1.Text = "85";
                     s2.Text = "85";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 89)
                 {

                     s1.Text = "85";
                     s2.Text = "85";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                    else if (sonuc / 3 == 90)
                    {

                        s1.Text = "90";
                        s2.Text = "90";

                        int soz1 = int.Parse(s1.Text);
                        int soz2 = int.Parse(s2.Text);
                        topla = soz1 + soz2 + sonuc;
                        islem = (float)topla / 5;
                        sonuc1.Text = islem.ToString() +  "  ile Geçti.";
                    
                    }
                 else if (sonuc / 3 == 91)
                 {

                     s1.Text = "90";
                     s2.Text = "90";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 92)
                 {

                     s1.Text = "90";
                     s2.Text = "90";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 93)
                 {

                     s1.Text = "90";
                     s2.Text = "90";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 94)
                 {

                     s1.Text = "90";
                     s2.Text = "90";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 95)
                 {

                     s1.Text = "90";
                     s2.Text = "95";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 96)
                 {

                     s1.Text = "90";
                     s2.Text = "95";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 97)
                 {

                     s1.Text = "90";
                     s2.Text = "95";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 98)
                 {

                     s1.Text = "90";
                     s2.Text = "95";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }
                 else if (sonuc / 3 == 99)
                 {

                     s1.Text = "90";
                     s2.Text = "95";

                     int soz1 = int.Parse(s1.Text);
                     int soz2 = int.Parse(s2.Text);
                     topla = soz1 + soz2 + sonuc;
                     islem = (float)topla / 5;
                     sonuc1.Text = islem.ToString() + "  ile Geçti.";

                 }

                    else if (sonuc / 3 == 100)
                    {

                        s1.Text = "100";
                        s2.Text = "100";

                        int soz1 = int.Parse(s1.Text);
                        int soz2 = int.Parse(s2.Text);
                        topla = soz1 + soz2 + sonuc;
                        islem = (float)topla / 5;
                        sonuc1.Text = islem.ToString() +  "  ile Geçti.";
                    
                    }

            }
                    else if (rkal.Checked == true) {

                        if (sonuc / 3 <= 10)
                        {

                            s1.Text = "60";
                            s2.Text = "60";

                            int soz1 = int.Parse(s1.Text);
                            int soz2 = int.Parse(s2.Text);
                            topla = soz1 + soz2 + sonuc;
                            islem = (float)topla / 5;
                            sonuc1.Text = islem.ToString() +  "  ile Kaldı.";
                        
                        }

                        else if (sonuc / 3 <= 20)
                        {

                            s1.Text = "45";
                            s2.Text = "45";

                            int soz1 = int.Parse(s1.Text);
                            int soz2 = int.Parse(s2.Text);
                            topla = soz1 + soz2 + sonuc;
                            islem = (float)topla / 5;
                            sonuc1.Text = islem.ToString() +  "  ile Kaldı.";
                        
                        }
                        else if (sonuc / 3 <= 30)
                        {

                            s1.Text = "40";
                            s2.Text = "45";

                            int soz1 = int.Parse(s1.Text);
                            int soz2 = int.Parse(s2.Text);
                            topla = soz1 + soz2 + sonuc;
                            islem = (float)topla / 5;
                            sonuc1.Text = islem.ToString() + "  ile Kaldı.";
                        
                        }
                        else if (sonuc / 3 <= 40)
                        {

                            s1.Text = "40";
                            s2.Text = "40";

                            int soz1 = int.Parse(s1.Text);
                            int soz2 = int.Parse(s2.Text);
                            topla = soz1 + soz2 + sonuc;
                            islem = (float)topla / 5;
                            sonuc1.Text = islem.ToString() +  "  ile Kaldı.";
                        
                        }
                        else if (sonuc / 3 <= 50)
                        {

                            s1.Text = "30";
                            s2.Text = "40";

                            int soz1 = int.Parse(s1.Text);
                            int soz2 = int.Parse(s2.Text);
                            topla = soz1 + soz2 + sonuc;
                            islem = (float)topla / 5;
                            sonuc1.Text = islem.ToString() +  "  ile Kaldı.";
                        
                        }
                               
                   
                                                              
                           }
                    else
                    {

                        MessageBox.Show("Lütfen Seçim Yapınız");
                    }
            }
        
            
           
        



        private void sayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            y1.Clear();
            y2.Clear();
            y3.Clear();
          


        }
    }
}
