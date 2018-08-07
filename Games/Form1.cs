using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Games
{
    public partial class Form1 : Form
    {
        int incarcari,rand1,b,c=-1;
        int s1=0, s2=0, s3=0, s4=0, s5=0, s6=0, s7=0, s8=0, s9=0,move=0,S,x,Tstation;
        int[] culori=new int[100];
        int termen=1, elem=1;
        Random rand = new Random();
        string a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button1.Enabled = false;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            textBox1.Text = "Scrie numarul";
            button2.Visible = true;
            button2.Enabled = true;
            Random random = new Random();
            int x = random.Next(0, 1001);
            rand1 = x;
            incarcari = 0;
            Inapoi.Visible = true;
            Inapoi.Enabled = true;
            label3.Visible = true;
            label3.Text = "Scrie un numar :";
            button3.Visible = false;
            button3.Enabled = false;
            DansulCulorilor.Enabled = false;
            DansulCulorilor.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            b = Convert.ToInt32(a);
            if (c != b)
            {
                incarcari++;
            }
            a = textBox1.Text;
            b = Convert.ToInt32(a);
            
            if (b == rand1)
            {
                label3.Text = "Ai ghicit doar din " + incarcari + " incercari!";
                c = -1;
            }
            if (b < rand1)
            {
                label3.Text = "Prea mic!";
            }
            if (b > rand1)
            {
                label3.Text = "Prea mare!";
            }
            c = b;
        }

        private void Inapoi_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button1.Enabled = true;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox1.Enabled = false;
            button2.Visible = false;
            button2.Enabled = false;
            Inapoi.Visible = false;
            Inapoi.Enabled = false;
            label3.Visible = false;
            button3.Visible = true;
            button3.Enabled = true;
            multiplayer.Visible = false;
            multiplayer.Enabled = false;
            B1.Visible = false;
            B1.Enabled = false;
            B2.Visible = false;
            B2.Enabled = false;
            B3.Visible = false;
            B3.Enabled = false;
            B4.Visible = false;
            B4.Enabled = false;
            B5.Visible = false;
            B5.Enabled = false;
            B6.Visible = false;
            B6.Enabled = false;
            B7.Visible = false;
            B7.Enabled = false;
            B8.Visible = false;
            B8.Enabled = false;
            B9.Visible = false;
            B9.Enabled = false;
            B1.Image = Properties.Resources.back;
            B2.Image = Properties.Resources.back;
            B3.Image = Properties.Resources.back;
            B4.Image = Properties.Resources.back;
            B5.Image = Properties.Resources.back;
            B6.Image = Properties.Resources.back;
            B7.Image = Properties.Resources.back;
            B8.Image = Properties.Resources.back;
            B9.Image = Properties.Resources.back;
            Win.Visible = false;
            DansulCulorilor.Enabled = true;
            DansulCulorilor.Visible = true;
            C1.Visible = false;
            C1.Enabled = false;
            C2.Visible = false;
            C2.Enabled = false;
            C3.Visible = false;
            C3.Enabled = false;
            C4.Visible = false;
            C4.Enabled = false;
            ColorIndicator.Visible = false;
            pictureBox1.Visible = false;
            label3.Location = new Point(95,197);
            pictureBox2.Visible = false;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DansulCulorilor.Enabled = false;
            DansulCulorilor.Visible = false;
            button1.Visible = false;
            button1.Enabled = false;
            button3.Visible = false;
            button3.Enabled = false;
            Inapoi.Visible = true;
            Inapoi.Enabled = true;
            multiplayer.Visible = true;
            multiplayer.Enabled = true;
        }

        private void multiplayer_Click(object sender, EventArgs e)
        {
            multiplayer.Visible = false;
            multiplayer.Enabled = false;
            B1.Visible = true;
            B1.Enabled = true;
            B2.Visible = true;
            B2.Enabled = true;
            B3.Visible = true;
            B3.Enabled = true;
            B4.Visible = true;
            B4.Enabled = true;
            B5.Visible = true;
            B5.Enabled = true;
            B6.Visible = true;
            B6.Enabled = true;
            B7.Visible = true;
            B7.Enabled = true;
            B8.Visible = true;
            B8.Enabled = true;
            B9.Visible = true;
            B9.Enabled = true;
            s1 = 0; s2 = 0; s3 = 0; s4 = 0; s5 = 0; s6 = 0; s7 = 0; s8 = 0; s9 = 0;
            move = 0;
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (s1 == 0)
            {
                move++;
                if (move % 2 == 1)
                {
                    B1.Image = Properties.Resources.X;
                    s1 = 1;
                }
                else
                {
                    B1.Image = Properties.Resources.O;
                    s1 = 2;
                }
                if ((s1 == s2 && s2 == s3) || (s1 == s4 && s1 == s7) || (s1 == s5 && s1 == s9))
                {
                    B1.Visible = false;
                    B1.Enabled = false;
                    B2.Visible = false;
                    B2.Enabled = false;
                    B3.Visible = false;
                    B3.Enabled = false;
                    B4.Visible = false;
                    B4.Enabled = false;
                    B5.Visible = false;
                    B5.Enabled = false;
                    B6.Visible = false;
                    B6.Enabled = false;
                    B7.Visible = false;
                    B7.Enabled = false;
                    B8.Visible = false;
                    B8.Enabled = false;
                    B9.Visible = false;
                    B9.Enabled = false;
                    if (move % 2 == 1)
                    {
                        Win.Text = "Castigatorul este: X";
                        Win.Visible = true;
                       
                    }
                    else
                    {
                        Win.Text = "Castigatorul este: 0";
                        Win.Visible = true;
                        
                    }
                }
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (s2 == 0)
            {
                move++;
                if (move % 2 == 1)
                {
                    B2.Image = Properties.Resources.X;
                    s2 = 1;
                }
                else
                {
                    B2.Image = Properties.Resources.O;
                    s2 = 2;
                }
                if ((s1 == s2 && s2 == s3) || (s2 == s5 && s2 == s8))
                {
                    B1.Visible = false;
                    B1.Enabled = false;
                    B2.Visible = false;
                    B2.Enabled = false;
                    B3.Visible = false;
                    B3.Enabled = false;
                    B4.Visible = false;
                    B4.Enabled = false;
                    B5.Visible = false;
                    B5.Enabled = false;
                    B6.Visible = false;
                    B6.Enabled = false;
                    B7.Visible = false;
                    B7.Enabled = false;
                    B8.Visible = false;
                    B8.Enabled = false;
                    B9.Visible = false;
                    B9.Enabled = false;
                    if (move % 2 == 1)
                    {
                        Win.Text = "Castigatorul este: X";
                        Win.Visible = true;
                       
                    }
                    else
                    {
                        Win.Text = "Castigatorul este: 0";
                        Win.Visible = true;
                        
                    }
                }
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (s3 == 0)
            {
                move++;
                if (move % 2 == 1)
                {
                    B3.Image = Properties.Resources.X;
                    s3 = 1;
                }
                else
                {
                    B3.Image = Properties.Resources.O;
                    s3 = 2;
                }
            }
            if ((s1 == s2 && s2 == s3) || (s3 == s6 && s3 == s9) || (s3 == s5 && s3 == s7))
            {
                B1.Visible = false;
                B1.Enabled = false;
                B2.Visible = false;
                B2.Enabled = false;
                B3.Visible = false;
                B3.Enabled = false;
                B4.Visible = false;
                B4.Enabled = false;
                B5.Visible = false;
                B5.Enabled = false;
                B6.Visible = false;
                B6.Enabled = false;
                B7.Visible = false;
                B7.Enabled = false;
                B8.Visible = false;
                B8.Enabled = false;
                B9.Visible = false;
                B9.Enabled = false;
                if (move % 2 == 1)
                {
                    Win.Text = "Castigatorul este: X";
                    Win.Visible = true;
                    
                }
                else
                {
                    Win.Text = "Castigatorul este: 0";
                    Win.Visible = true;
                   
                }
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (s4 == 0)
            {
                move++;
                if (move % 2 == 1)
                {
                    B4.Image = Properties.Resources.X;
                    s4 = 1;
                }
                else
                {
                    B4.Image = Properties.Resources.O;
                    s4 = 2;
                }
            }
            if ((s4 == s5 && s4 == s6) || (s1 == s4 && s1 == s7))
            {
                B1.Visible = false;
                B1.Enabled = false;
                B2.Visible = false;
                B2.Enabled = false;
                B3.Visible = false;
                B3.Enabled = false;
                B4.Visible = false;
                B4.Enabled = false;
                B5.Visible = false;
                B5.Enabled = false;
                B6.Visible = false;
                B6.Enabled = false;
                B7.Visible = false;
                B7.Enabled = false;
                B8.Visible = false;
                B8.Enabled = false;
                B9.Visible = false;
                B9.Enabled = false;
                if (move % 2 == 1)
                {
                    Win.Text = "Castigatorul este: X";
                    Win.Visible = true;
                    
                }
                else
                {
                    Win.Text = "Castigatorul este: 0";
                    Win.Visible = true;
                   
                }
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (s5 == 0)
            {
                move++;
                if (move % 2 == 1)
                {
                    B5.Image = Properties.Resources.X;
                    s5 = 1;
                }
                else
                {
                    B5.Image = Properties.Resources.O;
                    s5 = 2;
                }
            }
            if ((s4 == s5 && s5 == s6) || (s2 == s5 && s5 == s8) || (s1 == s5 && s5 == s9)|| (s3 == s5 && s5 == s7))
            {
                B1.Visible = false;
                B1.Enabled = false;
                B2.Visible = false;
                B2.Enabled = false;
                B3.Visible = false;
                B3.Enabled = false;
                B4.Visible = false;
                B4.Enabled = false;
                B5.Visible = false;
                B5.Enabled = false;
                B6.Visible = false;
                B6.Enabled = false;
                B7.Visible = false;
                B7.Enabled = false;
                B8.Visible = false;
                B8.Enabled = false;
                B9.Visible = false;
                B9.Enabled = false;
                if (move % 2 == 1)
                {
                    Win.Text = "Castigatorul este: X";
                    Win.Visible = true;
                    
                }
                else
                {
                    Win.Text = "Castigatorul este: 0";
                    Win.Visible = true;
                    
                }
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (s6 == 0)
            {
                move++;
                if (move % 2 == 1)
                {
                    B6.Image = Properties.Resources.X;
                    s6 = 1;
                }
                else
                {
                    B6.Image = Properties.Resources.O;
                    s6 = 2;
                }
            }
            if ((s4 == s5 && s5 == s6) || (s3 == s6 && s6 == s9))
            {
                B1.Visible = false;
                B1.Enabled = false;
                B2.Visible = false;
                B2.Enabled = false;
                B3.Visible = false;
                B3.Enabled = false;
                B4.Visible = false;
                B4.Enabled = false;
                B5.Visible = false;
                B5.Enabled = false;
                B6.Visible = false;
                B6.Enabled = false;
                B7.Visible = false;
                B7.Enabled = false;
                B8.Visible = false;
                B8.Enabled = false;
                B9.Visible = false;
                B9.Enabled = false;
                if (move % 2 == 1)
                {
                    Win.Text = "Castigatorul este: X";
                    Win.Visible = true;
                    
                }
                else
                {
                    Win.Text = "Castigatorul este: 0";
                    Win.Visible = true;
                   
                }
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (s7 == 0)
            {
                move++;
                if (move % 2 == 1)
                {
                    B7.Image = Properties.Resources.X;
                    s7 = 1;
                }
                else
                {
                    B7.Image = Properties.Resources.O;
                    s7 = 2;
                }
            }
            if ((s7 == s8 && s8 == s9) || (s1 == s4 && s1 == s7)||(s7 == s5 && s7 == s3))
            {
                B1.Visible = false;
                B1.Enabled = false;
                B2.Visible = false;
                B2.Enabled = false;
                B3.Visible = false;
                B3.Enabled = false;
                B4.Visible = false;
                B4.Enabled = false;
                B5.Visible = false;
                B5.Enabled = false;
                B6.Visible = false;
                B6.Enabled = false;
                B7.Visible = false;
                B7.Enabled = false;
                B8.Visible = false;
                B8.Enabled = false;
                B9.Visible = false;
                B9.Enabled = false;
                if (move % 2 == 1)
                {
                    Win.Text = "Castigatorul este: X";
                    Win.Visible = true;
                    
                }
                else
                {
                    Win.Text = "Castigatorul este: 0";
                    Win.Visible = true;
                    
                }
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (s8 == 0)
            {
                move++;
                if (move % 2 == 1)
                {
                    B8.Image = Properties.Resources.X;
                    s8 = 1;
                }
                else
                {
                    B8.Image = Properties.Resources.O;
                    s8 = 2;
                }
            }
            if ((s7 == s8 && s8 == s9) || (s8 == s5 && s5 == s2))
            {
                B1.Visible = false;
                B1.Enabled = false;
                B2.Visible = false;
                B2.Enabled = false;
                B3.Visible = false;
                B3.Enabled = false;
                B4.Visible = false;
                B4.Enabled = false;
                B5.Visible = false;
                B5.Enabled = false;
                B6.Visible = false;
                B6.Enabled = false;
                B7.Visible = false;
                B7.Enabled = false;
                B8.Visible = false;
                B8.Enabled = false;
                B9.Visible = false;
                B9.Enabled = false;
                if (move % 2 == 1)
                {
                    Win.Text = "Castigatorul este: X";
                    Win.Visible = true;
                   
                }
                else
                {
                    Win.Text = "Castigatorul este: 0";
                    Win.Visible = true;
                    
                }
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (s9 == 0)
            {
                move++;
                if (move % 2 == 1)
                {
                    B9.Image = Properties.Resources.X;
                    s9 = 1;
                }
                else
                {
                    B9.Image = Properties.Resources.O;
                    s9 = 2;
                }
            }
            if ((s7 == s8 && s8 == s9) || (s9 == s6 && s6 == s3) || (s9 == s5 && s1 == s9))
            {
                B1.Visible = false;
                B1.Enabled = false;
                B2.Visible = false;
                B2.Enabled = false;
                B3.Visible = false;
                B3.Enabled = false;
                B4.Visible = false;
                B4.Enabled = false;
                B5.Visible = false;
                B5.Enabled = false;
                B6.Visible = false;
                B6.Enabled = false;
                B7.Visible = false;
                B7.Enabled = false;
                B8.Visible = false;
                B8.Enabled = false;
                B9.Visible = false;
                B9.Enabled = false;
                if (move % 2 == 1)
                {
                    Win.Text = "Castigatorul este: X";
                    Win.Visible = true;
                    
                }
                else
                {
                    Win.Text = "Castigatorul este: 0";
                    Win.Visible = true;
                    
                }
            }

        }

        private void DansulCulorilor_Click(object sender, EventArgs e)
        {
            Inapoi.Visible = true;
            Inapoi.Enabled = true;
            button1.Visible = false;
            button1.Enabled = false;
            button3.Visible = false;
            button3.Enabled = false;
            DansulCulorilor.Enabled = false;
            DansulCulorilor.Visible = false;
            termen = 1;
            elem = 0;
            x = 0;
            culori[1] = rand.Next(1, 5);
            C1.Visible = true;
            C1.Enabled = false;
            C2.Visible = true;
            C2.Enabled = false;
            C3.Visible = true;
            C3.Enabled = false;
            C4.Visible = true;
            C4.Enabled = false;
            ColorIndicator.Visible = true;
            ColorLoop.Enabled = true;
            
        }
        private void C1_Click(object sender, EventArgs e)
        {
            elem++;
            S = 1;
            if (S == culori[elem])
            {
                if (elem == termen)
                {
                    if (termen == 10)
                    {
                        C1.Enabled = false;
                        C2.Enabled = false;
                        C3.Enabled = false;
                        C4.Enabled = false;
                        C1.Visible = false;
                        C2.Visible = false;
                        C3.Visible = false;
                        C4.Visible = false;
                        label3.Location = new Point(40, 85);
                        pictureBox2.Visible = true;
                        pictureBox2.Image = Properties.Resources.einstein;
                        label3.Visible = true;
                        label3.Text = "Ai castigat!"+"\n"+"Ai o memorie EXTRAORDINARA!";
                        ColorIndicator.Visible = false;
                    }
                    else
                    {
                        elem = 0;
                        culori[++termen] = rand.Next(1, 5);
                        C1.Enabled = false;
                        C2.Enabled = false;
                        C3.Enabled = false;
                        C4.Enabled = false;
                        x = 1;
                        Tstation = 1;
                        ColorLoop.Enabled = true;
                    }
                }
            }
            else
            {
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
                C4.Enabled = false;
                C1.Visible = false;
                C2.Visible = false;
                C3.Visible = false;
                C4.Visible = false;
                label3.Visible = true;
                label3.Text = "Ai pierdut!";
                ColorIndicator.Visible = false;
                pictureBox1.Image = Properties.Resources.Sad_face;
                pictureBox1.Visible = true;
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            elem++;
            S = 2;
            if (S == culori[elem])
            {
                if (elem == termen)
                {
                    if (termen == 10)
                    {
                        C1.Enabled = false;
                        C2.Enabled = false;
                        C3.Enabled = false;
                        C4.Enabled = false;
                        C1.Visible = false;
                        C2.Visible = false;
                        C3.Visible = false;
                        C4.Visible = false;
                        label3.Location = new Point(40, 85);
                        label3.Visible = true;
                        pictureBox2.Visible = true;
                        pictureBox2.Image = Properties.Resources.einstein;
                        label3.Text = "Ai castigat!" + "\n" + "Ai o memorie EXTRAORDINARA!";
                        ColorIndicator.Visible = false;
                    }
                    else
                    {
                        elem = 0;
                        culori[++termen] = rand.Next(1, 5);
                        C1.Enabled = false;
                        C2.Enabled = false;
                        C3.Enabled = false;
                        C4.Enabled = false;
                        x = 1;
                        Tstation = 1;
                        ColorLoop.Enabled = true;
                    }
                }
            }
            else
            {
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
                C4.Enabled = false;
                C1.Visible = false;
                C2.Visible = false;
                C3.Visible = false;
                C4.Visible = false;
                label3.Visible = true;
                label3.Text = "Ai pierdut!";
                ColorIndicator.Visible = false;
                pictureBox1.Image = Properties.Resources.Sad_face;
                pictureBox1.Visible = true;
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            elem++;
            S = 3;
            if (S == culori[elem])
            {
                if (elem == termen)
                {
                    if (termen == 10)
                    {
                        C1.Enabled = false;
                        C2.Enabled = false;
                        C3.Enabled = false;
                        C4.Enabled = false;
                        C1.Visible = false;
                        C2.Visible = false;
                        C3.Visible = false;
                        C4.Visible = false;
                        label3.Location = new Point(40, 85);
                        label3.Visible = true;
                        pictureBox2.Visible = true;
                        pictureBox2.Image = Properties.Resources.einstein;
                        label3.Text = "Ai castigat!" + "\n" + "Ai o memorie EXTRAORDINARA!";
                        ColorIndicator.Visible = false;
                    }
                    else
                    {
                        elem = 0;
                        culori[++termen] = rand.Next(1, 5);
                        C1.Enabled = false;
                        C2.Enabled = false;
                        C3.Enabled = false;
                        C4.Enabled = false;
                        x = 1;
                        Tstation = 1;
                        ColorLoop.Enabled = true;
                    }
                }
            }
            else
            {
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
                C4.Enabled = false;
                C1.Visible = false;
                C2.Visible = false;
                C3.Visible = false;
                C4.Visible = false;
                label3.Visible = true;
                label3.Text = "Ai pierdut!";
                ColorIndicator.Visible = false;
                pictureBox1.Image = Properties.Resources.Sad_face;
                pictureBox1.Visible = true;
            }
        }

        private void C4_Click(object sender, EventArgs e)
        {
            elem++;
            S = 4;
            if (S == culori[elem])
            {
                if (elem == termen)
                {
                    if (termen == 10)
                    {
                        C1.Enabled = false;
                        C2.Enabled = false;
                        C3.Enabled = false;
                        C4.Enabled = false;
                        C1.Visible = false;
                        C2.Visible = false;
                        C3.Visible = false;
                        C4.Visible = false;
                        pictureBox2.Visible = true;
                        pictureBox2.Image = Properties.Resources.einstein;
                        label3.Location = new Point(40, 85);
                        label3.Visible = true;
                        label3.Text = "Ai castigat!" + "\n" + "Ai o memorie EXTRAORDINARA!";
                        ColorIndicator.Visible = false;
                    }
                    else
                    {
                        elem = 0;
                        culori[++termen] = rand.Next(1, 5);
                        C1.Enabled = false;
                        C2.Enabled = false;
                        C3.Enabled = false;
                        C4.Enabled = false;
                        x = 1;
                        Tstation = 1;
                        ColorLoop.Enabled = true;
                    }
                }
            }
            else
            {
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
                C4.Enabled = false;
                C1.Visible = false;
                C2.Visible = false;
                C3.Visible = false;
                C4.Visible = false;
                label3.Visible = true;
                label3.Text = "Ai pierdut!";
                ColorIndicator.Visible = false;
                pictureBox1.Image = Properties.Resources.Sad_face;
                pictureBox1.Visible = true;
            }
        }

        private void ColorLoop_Tick(object sender, EventArgs e)
        {
            ColorIndicator.ForeColor = Color.Black;
            ColorIndicator.Text = "Indicator";
            if (Tstation % 2 == 1)
            {
                if (x < termen + 1)
                {
                    if (culori[x] == 1)
                    {
                        ColorIndicator.ForeColor = Color.Red;
                        ColorIndicator.Text = "ROSU!";
                    }
                    if (culori[x] == 2)
                    {
                        ColorIndicator.ForeColor = Color.Blue;
                        ColorIndicator.Text = "ALBASTRU!";
                    }
                    if (culori[x] == 3)
                    {
                        ColorIndicator.ForeColor = Color.Green;
                        ColorIndicator.Text = "Verde!";
                    }
                    if (culori[x] == 4)
                    {
                        ColorIndicator.ForeColor = Color.Yellow;
                        ColorIndicator.Text = "Galben!";
                    }
                    x++;

                }
                else
                {
                    C1.Enabled = true;
                    C2.Enabled = true;
                    C3.Enabled = true;
                    C4.Enabled = true;
                    ColorIndicator.ForeColor = Color.Black;
                    ColorIndicator.Text = "Indicator";
                    ColorLoop.Enabled = false;
                }
            }
            Tstation++;
        }
    }
}
