using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i;
        Random r;

        private void bstart_Click(object sender, EventArgs e)
        {
            i = 1;
            lst.Items.Clear();
            lst.Items.Add("شروع  "+"خانه شما= "+i);
            wset();
            go();

        }

        private void st()
        {
            r = new Random();
            int ri = r.Next(1, 7);
            
            int m = ri + i;
            if (m > 100)
            {
                MessageBox.Show("دوباره");
            }
            else
            {
                i += ri;
                lst.Items.Add("شماره تاس=  " + ri + "     خانه شما = " + i);

                switch (ri)
                {
                    case 1:
                        b1.BackColor = Color.Red;
                        b2.BackColor = Color.White;
                        b3.BackColor = Color.White;
                        b4.BackColor = Color.White;
                        b5.BackColor = Color.White;
                        b6.BackColor = Color.White;
                        break;
                    case 2:
                        b1.BackColor = Color.Red;
                        b2.BackColor = Color.Red;
                        b3.BackColor = Color.White;
                        b4.BackColor = Color.White;
                        b5.BackColor = Color.White;
                        b6.BackColor = Color.White;
                        break;
                    case 3:
                        b1.BackColor = Color.Red;
                        b2.BackColor = Color.Red;
                        b3.BackColor = Color.Red;
                        b4.BackColor = Color.White;
                        b5.BackColor = Color.White;
                        b6.BackColor = Color.White;
                        break;
                    case 4:
                        b1.BackColor = Color.Red;
                        b2.BackColor = Color.Red;
                        b3.BackColor = Color.Red;
                        b4.BackColor = Color.Red;
                        b5.BackColor = Color.White;
                        b6.BackColor = Color.White;
                        break;
                    case 5:
                        b1.BackColor = Color.Red;
                        b2.BackColor = Color.Red;
                        b3.BackColor = Color.Red;
                        b4.BackColor = Color.Red;
                        b5.BackColor = Color.Red;
                        b6.BackColor = Color.White;
                        break;
                    case 6:
                        b1.BackColor = Color.Red;
                        b2.BackColor = Color.Red;
                        b3.BackColor = Color.Red;
                        b4.BackColor = Color.Red;
                        b5.BackColor = Color.Red;
                        b6.BackColor = Color.Red;
                        break;
                }
                test();
            }
        }
        private void test()
        {
                if (i == 3 || i == 30 ||i==32|| i == 41 || i == 59 || i == 74 || i == 81)
                    green();
                else if (i == 10 || i == 13 || i == 46 || i == 65 || i == 78 || i == 91 || i == 95 || i == 98)
                    black();
                else if (i == 5 || i == 22 || i == 35 || i == 40 || i == 57 || i == 61 || i == 84 || i == 84 || i == 89)
                    yellow();
                else if (i == 100) 
                {
                    go();
                    MessageBox.Show("شما برنده شدید....","پایان");
                    wset();
                    i = 1;

                }
            
        }


        private void go()
        {
            switch (i)
            {
                case 1:
                    wset();
                    q1.BackColor = Color.Red;
                    break;
                case 2:
                    wset();
                    q2.BackColor = Color.Red;
                    break;
                case 3:
                    wset();
                    q3.BackColor = Color.Red;
                    break;
                case 4:
                    wset();
                    q4.BackColor = Color.Red;
                    break;
                case 5:
                    wset();
                    q5.BackColor = Color.Red;
                    break;
                case 6:
                    wset();
                    q6.BackColor = Color.Red;
                    break;
                case 7:
                    wset();
                    q7.BackColor = Color.Red;
                    break;
                case 8:
                    wset();
                    q8.BackColor = Color.Red;
                    break;
                case 9:
                    wset();
                    q9.BackColor = Color.Red;
                    break;
                case 10:
                    wset();
                    q10.BackColor = Color.Red;
                    break;
                case 11:
                    wset();
                    q11.BackColor = Color.Red;
                    break;
                case 12:
                    wset();
                    q12.BackColor = Color.Red;
                    break;
                case 13:
                    wset();
                    q13.BackColor = Color.Red;
                    break;
                case 14:
                    wset();
                    q14.BackColor = Color.Red;
                    break;
                case 15:
                    wset();
                    q15.BackColor = Color.Red;
                    break;
                case 16:
                    wset();
                    q16.BackColor = Color.Red;
                    break;
                case 17:
                    wset();
                    q17.BackColor = Color.Red;
                    break;
                case 18:
                    wset();
                    q18.BackColor = Color.Red;
                    break;
                case 19:
                    wset();
                    q19.BackColor = Color.Red;
                    break;
                case 20:
                    wset();
                    q20.BackColor = Color.Red;
                    break;
                case 21:
                    wset();
                    q21.BackColor = Color.Red;
                    break;
                case 22:
                    wset();
                    q22.BackColor = Color.Red;
                    break;
                case 23:
                    wset();
                    q23.BackColor = Color.Red;
                    break;
                case 24:
                    wset();
                    q24.BackColor = Color.Red;
                    break;
                case 25:
                    wset();
                    q25.BackColor = Color.Red;
                    break;
                case 26:
                    wset();
                    q26.BackColor = Color.Red;
                    break;
                case 27:
                    wset();
                    q27.BackColor = Color.Red;
                    break;
                case 28:
                    wset();
                    q28.BackColor = Color.Red;
                    break;
                case 29:
                    wset();
                    q29.BackColor = Color.Red;
                    break;
                case 30:
                    wset();
                    q30.BackColor = Color.Red;
                    break;
                case 31:
                    wset();
                    q31.BackColor = Color.Red;
                    break;
                case 32:
                    wset();
                    q32.BackColor = Color.Red;
                    break;
                case 33:
                    wset();
                    q33.BackColor = Color.Red;
                    break;
                case 34:
                    wset();
                    q34.BackColor = Color.Red;
                    break;
                case 35:
                    wset();
                    q35.BackColor = Color.Red;
                    break;
                case 36:
                    wset();
                    q36.BackColor = Color.Red;
                    break;
                case 37:
                    wset();
                    q37.BackColor = Color.Red;
                    break;
                case 38:
                    wset();
                    q38.BackColor = Color.Red;
                    break;
                case 39:
                    wset();
                    q39.BackColor = Color.Red;
                    break;

                case 40:
                    wset();
                    q40.BackColor = Color.Red;
                    break;
                case 41:
                    wset();
                    q41.BackColor = Color.Red;
                    break;
                case 42:
                    wset();
                    q42.BackColor = Color.Red;
                    break;
                case 43:
                    wset();
                    q43.BackColor = Color.Red;
                    break;
                case 44:
                    wset();
                    q44.BackColor = Color.Red;
                    break;
                case 45:
                    wset();
                    q45.BackColor = Color.Red;
                    break;
                case 46:
                    wset();
                    q46.BackColor = Color.Red;
                    break;
                case 47:
                    wset();
                    q47.BackColor = Color.Red;
                    break;
                case 48:
                    wset();
                    q48.BackColor = Color.Red;
                    break;
                case 49:
                    wset();
                    q49.BackColor = Color.Red;
                    break;
                case 50:
                    wset();
                    q50.BackColor = Color.Red;
                    break;
                case 51:
                    wset();
                    q51.BackColor = Color.Red;
                    break;
                case 52:
                    wset();
                    q52.BackColor = Color.Red;
                    break;
                case 53:
                    wset();
                    q53.BackColor = Color.Red;
                    break;
                case 54:
                    wset();
                    q54.BackColor = Color.Red;
                    break;
                case 55:
                    wset();
                    q55.BackColor = Color.Red;
                    break;
                case 56:
                    wset();
                    q56.BackColor = Color.Red;
                    break;
                case 57:
                    wset();
                    q57.BackColor = Color.Red;
                    break;
                case 58:
                    wset();
                    q58.BackColor = Color.Red;
                    break;
                case 59:
                    wset();
                    q59.BackColor = Color.Red;
                    break;
                case 60:
                    wset();
                    q60.BackColor = Color.Red;
                    break;
                case 61:
                    wset();
                    q61.BackColor = Color.Red;
                    break;
                case 62:
                    wset();
                    q62.BackColor = Color.Red;
                    break;
                case 63:
                    wset();
                    q63.BackColor = Color.Red;
                    break;
                case 64:
                    wset();
                    q64.BackColor = Color.Red;
                    break;
                case 65:
                    wset();
                    q65.BackColor = Color.Red;
                    break;
                case 66:
                    wset();
                    q66.BackColor = Color.Red;
                    break;
                case 67:
                    wset();
                    q67.BackColor = Color.Red;
                    break;
                case 68:
                    wset();
                    q68.BackColor = Color.Red;
                    break;
                case 69:
                    wset();
                    q69.BackColor = Color.Red;
                    break;
                case 70:
                    wset();
                    q70.BackColor = Color.Red;
                    break;
                case 71:
                    wset();
                    q71.BackColor = Color.Red;
                    break;
                case 72:
                    wset();
                    q72.BackColor = Color.Red;
                    break;
                case 73:
                    wset();
                    q73.BackColor = Color.Red;
                    break;
                case 74:
                    wset();
                    q74.BackColor = Color.Red;
                    break;
                case 75:
                    wset();
                    q75.BackColor = Color.Red;
                    break;
                case 76:
                    wset();
                    q76.BackColor = Color.Red;
                    break;
                case 77:
                    wset();
                    q77.BackColor = Color.Red;
                    break;
                case 78:
                    wset();
                    q78.BackColor = Color.Red;
                    break;
                case 79:
                    wset();
                    q79.BackColor = Color.Red;
                    break;
                case 80:
                    wset();
                    q80.BackColor = Color.Red;
                    break;
                case 81:
                    wset();
                    q81.BackColor = Color.Red;
                    break;
                case 82:
                    wset();
                    q82.BackColor = Color.Red;
                    break;
                case 83:
                    wset();
                    q83.BackColor = Color.Red;
                    break;
                case 84:
                    wset();
                    q84.BackColor = Color.Red;
                    break;
                case 85:
                    wset();
                    q85.BackColor = Color.Red;
                    break;
                case 86:
                    wset();
                    q86.BackColor = Color.Red;
                    break;
                case 87:
                    wset();
                    q87.BackColor = Color.Red;
                    break;
                case 88:
                    wset();
                    q88.BackColor = Color.Red;
                    break;
                case 89:
                    wset();
                    q89.BackColor = Color.Red;
                    break;
                case 90:
                    wset();
                    q90.BackColor = Color.Red;
                    break;
                case 91:
                    wset();
                    q91.BackColor = Color.Red;
                    break;
                case 92:
                    wset();
                    q92.BackColor = Color.Red;
                    break;
                case 93:
                    wset();
                    q93.BackColor = Color.Red;
                    break;
                case 94:
                    wset();
                    q94.BackColor = Color.Red;
                    break;
                case 95:
                    wset();
                    q95.BackColor = Color.Red;
                    break;
                case 96:
                    wset();
                    q96.BackColor = Color.Red;
                    break;
                case 97:
                    wset();
                    q97.BackColor = Color.Red;
                    break;
                case 98:
                    wset();
                    q98.BackColor = Color.Red;
                    break;
                case 99:
                    wset();
                    q99.BackColor = Color.Red;
                    break;
                case 100:
                    wset();
                    q100.BackColor = Color.Red;
                    break;
            }

        }
        private void wset()
        {

            q1.BackColor = Color.White;
            q2.BackColor = Color.White;
            q3.BackColor = Color.Green;
            q4.BackColor = Color.White;
            q5.BackColor = Color.Yellow;
            q6.BackColor = Color.White;
            q7.BackColor = Color.White;
            q8.BackColor = Color.White;
            q8.BackColor = Color.White;
            q9.BackColor = Color.White;
            q10.BackColor = Color.Black;
            q11.BackColor = Color.White;
            q12.BackColor = Color.White;
            q13.BackColor = Color.Black;
            q14.BackColor = Color.White;
            q15.BackColor = Color.White;
            q16.BackColor = Color.White;
            q17.BackColor = Color.White;
            q18.BackColor = Color.White;
            q19.BackColor = Color.White;
            q20.BackColor = Color.White;
            q21.BackColor = Color.White;
            q22.BackColor = Color.Yellow;
            q23.BackColor = Color.White;
            q24.BackColor = Color.White;
            q25.BackColor = Color.White;
            q26.BackColor = Color.White;
            q27.BackColor = Color.White;
            q28.BackColor = Color.White;
            q29.BackColor = Color.White;
            q30.BackColor = Color.Green;
            q31.BackColor = Color.White;
            q32.BackColor = Color.Green;
            q33.BackColor = Color.White;
            q34.BackColor = Color.White;
            q35.BackColor = Color.Yellow;
            q36.BackColor = Color.White;
            q37.BackColor = Color.White;
            q38.BackColor = Color.White;
            q39.BackColor = Color.White;
            q40.BackColor = Color.Yellow;
            q41.BackColor = Color.White;
            q42.BackColor = Color.White;
            q43.BackColor = Color.White;
            q44.BackColor = Color.White;
            q45.BackColor = Color.White;
            q46.BackColor = Color.Black;
            q47.BackColor = Color.White;
            q48.BackColor = Color.White;
            q49.BackColor = Color.White;
            q50.BackColor = Color.White;
            q51.BackColor = Color.White;
            q52.BackColor = Color.White;
            q53.BackColor = Color.White;
            q54.BackColor = Color.White;
            q55.BackColor = Color.White;
            q56.BackColor = Color.White;
            q57.BackColor = Color.Yellow;
            q58.BackColor = Color.White;
            q59.BackColor = Color.Green;
            q60.BackColor = Color.White;
            q61.BackColor = Color.Yellow;
            q62.BackColor = Color.White;
            q63.BackColor = Color.White;
            q64.BackColor = Color.White;
            q65.BackColor = Color.Black;
            q66.BackColor = Color.White;
            q67.BackColor = Color.White;
            q68.BackColor = Color.White;
            q69.BackColor = Color.White;
            q70.BackColor = Color.White;
            q71.BackColor = Color.White;
            q72.BackColor = Color.White;
            q73.BackColor = Color.White;
            q74.BackColor = Color.Green;
            q75.BackColor = Color.White;
            q76.BackColor = Color.White;
            q77.BackColor = Color.White;
            q78.BackColor = Color.Black;
            q79.BackColor = Color.White;
            q80.BackColor = Color.White;
            q81.BackColor = Color.Green;
            q82.BackColor = Color.White;
            q83.BackColor = Color.White;
            q84.BackColor = Color.Yellow;
            q85.BackColor = Color.White;
            q86.BackColor = Color.White;
            q87.BackColor = Color.White;
            q88.BackColor = Color.White;
            q89.BackColor = Color.Yellow;
            q90.BackColor = Color.White;
            q91.BackColor = Color.Black;
            q92.BackColor = Color.White;
            q93.BackColor = Color.White;
            q94.BackColor = Color.White;
            q95.BackColor = Color.Black;
            q96.BackColor = Color.White;
            q97.BackColor = Color.White;
            q98.BackColor = Color.Black;
            q99.BackColor = Color.White;
            q100.BackColor = Color.White;
            
        }

        private void bgo_Click(object sender, EventArgs e)
        {
            
            st();
            go();
            lst.SelectedIndex = lst.Items.Count-1;
        }
        private void green()
        {
            
            go();
            Random ran=new Random();
            
            int dd = ran.Next(i, 99);
            lst.Items.Add("");
            int f = dd - i;
            i = dd;
            lst.Items.Add("َخانه سبز   " + i);
            lst.Items.Add("َامتیاز شما= "+f+" خانه شما=" + dd);
            MessageBox.Show("شما موفق به کسب" + f + "  !!!!!امتیاز شدید","خوب ");
            i = dd;
            wset ();
            go();
            test();

        }
        private void yellow()
        {
            
            go();
            lst.Items.Add(" ");
            lst.Items.Add("َخانه زرد   " + i);
            Random ran = new Random();
            int dd = ran.Next(1, 99);

            if (dd > i)
            {
                int f = dd - i;
                lst.Items.Add("َامتیاز شما= " + f + " خانه شما=" + dd);
                MessageBox.Show("شما موفق به کسب" + f + "  !!!!!امتیاز شدید","خوب ");
            }
            else
            {
                int f = i - dd;
                lst.Items.Add("َامتیاز از دست داده شما= " + f + " خانه شما=" + dd);
                MessageBox.Show( "شما " + f + " امتیاز از دست دادید","بد ");
            }
            i = dd;
            wset ();
            go();
            test();
        }
        private void black()
        {
            
            go();
            Random ran = new Random();
            int dd = ran.Next(1, i);
            int f = i-dd;
            lst.Items.Add(" ");
            lst.Items.Add("َخانه سیاه  "+i);
            lst.Items.Add("َامتیاز از دست داده شما= " + f + " خانه شما=" + dd);
            MessageBox.Show("شما " + f + " امتیاز از دست دادید", "بد ");
            i = dd;
            wset ();
            go();
            test();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

    }
}
