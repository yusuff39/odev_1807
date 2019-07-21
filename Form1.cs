using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loto_Test3
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Random rnd = new Random();

        #region timer_degiskenler
        int syc_10ms = 1;
        int syc_t1 = 1;
        int syc_t2 = 1;
        int syc_t3 = 1;
        int syc_t4 = 1;
        int syc_t5 = 0;
        int syc_t6 = 0;
        int syc_t7 = 0;
        #endregion

        #region yeni_sayi
        int m_x = 6;
        int m_y = 10;
        int[,] y = new int[6, 10];
        int[] y_x = new int[6];
        int[] y_y = new int[10];

        int ba = 0;
        int bb = 0;

        int bd = 0;

        int zz = 0;
        int zx = 0;
       

        int y_xx = 0;
        #endregion

        #region sayac_yavaslatma


        int a = 1;
        int b = 1;
        int c = 1;
        #endregion

        #region form1
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        private void Timer1_Tick(object sender, EventArgs e)
        {
            #region _timer_
            syc_10ms++;

            if (syc_10ms % 4 == 0) { syc_t1++; }
            if (syc_10ms % 9 == 0) { syc_t2++; }
            if (syc_10ms % 14 == 0) { syc_t3++; }
            if (syc_10ms % 19 == 0) { syc_t4++; }
            if (syc_10ms % 24 == 0) { syc_t5++; }
            if (syc_10ms % 49 == 0) { syc_t6++; }
            if (syc_10ms % 99 == 0) { syc_t7++; }
            #endregion

            #region deger_atama
            if (ba < m_x)
            {
                if (bb < m_y)
                {
                    zx = rnd.Next(0, 50);

                    #region dizi_icersinde_ayni_Sayi?gelmemeli
                    if (bb == 0)
                    {
                        y[ba, bb] = zx;
                        y_y[bb] = zx;
                        bb++;
                        zz++;
                    }
                    else if ((bb > 0) && (Array.IndexOf(y_x, zx) == -1))
                    {
                        y[ba, bb] = zx;
                        y_y[bb] = zx;
                        bb++;
                        zz++;
                    }
                    #endregion
                }
                else
                {
                    ba++; bb = 0;
                }
            }
            #endregion

            #region screen
            if ((zz == 60) && (bd < (m_y)))
            {
                #region txtx1
                //txtx1.Text
                if ((syc_t5 % (a) == 0))
                {
                    y_xx = 0;
                    if (bd == 0)
                    {
                        txtx1_1.Text = (y[y_xx, bd]).ToString();
                        txtx1_2.Text = ("#").ToString();
                        txtx1_3.Text = ("#").ToString();
                        txtx1_4.Text = ("#").ToString();
                        txtx1_5.Text = ("#").ToString();
                    }
                    else if (bd == 1)
                    {
                        txtx1_1.Text = (y[y_xx, bd]).ToString();
                        txtx1_2.Text = (y[0, bd - 1]).ToString();
                        txtx1_3.Text = ("#").ToString();
                        txtx1_4.Text = ("#").ToString();
                        txtx1_5.Text = ("#").ToString();
                    }
                    else if (bd == 2)
                    {
                        txtx1_1.Text = (y[y_xx, bd]).ToString();
                        txtx1_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx1_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx1_4.Text = ("#").ToString();
                        txtx1_5.Text = ("#").ToString();
                    }
                    else if (bd == 3)
                    {
                        txtx1_1.Text = (y[y_xx, bd]).ToString();
                        txtx1_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx1_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx1_4.Text = (y[y_xx, bd - 3]).ToString();
                        txtx1_5.Text = ("#").ToString();
                    }
                    else if ((bd > 3) && (bd < 8))
                    {
                        txtx1_1.Text = (y[y_xx, bd]).ToString();
                        txtx1_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx1_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx1_4.Text = (y[y_xx, bd - 3]).ToString();
                        txtx1_5.Text = (y[y_xx, bd - 4]).ToString();
                    }
                    else if (bd == 8)
                    {
                        txtx1_1.Text = ("#").ToString();
                        txtx1_2.Text = (y[y_xx, bd]).ToString();
                        txtx1_3.Text = (y[y_xx, bd - 1]).ToString();
                        txtx1_4.Text = (y[y_xx, bd - 2]).ToString();
                        txtx1_5.Text = (y[y_xx, bd - 3]).ToString();
                    }
                    else if (bd == 9)
                    {
                        txtx1_1.Text = ("#").ToString();
                        txtx1_2.Text = ("#").ToString();
                        txtx1_3.Text = (y[y_xx, bd]).ToString();
                        txtx1_4.Text = (y[y_xx, bd - 1]).ToString();
                        txtx1_5.Text = (y[y_xx, bd - 2]).ToString();
                    }
                }
                #endregion

                #region txtx2
                //txtx2.Text
                if ( (syc_t4 % (a) == 0))
                {
                    y_xx = 1;
                    if (bd == 0)
                    {
                        txtx2_1.Text = (y[y_xx, bd]).ToString();
                        txtx2_2.Text = ("#").ToString();
                        txtx2_3.Text = ("#").ToString();
                        txtx2_4.Text = ("#").ToString();
                        txtx2_5.Text = ("#").ToString();
                    }
                    else if (bd == 1)
                    {
                        txtx2_1.Text = (y[y_xx, bd]).ToString();
                        txtx2_2.Text = (y[0, bd - 1]).ToString();
                        txtx2_3.Text = ("#").ToString();
                        txtx2_4.Text = ("#").ToString();
                        txtx2_5.Text = ("#").ToString();
                    }
                    else if (bd == 2)
                    {
                        txtx2_1.Text = (y[y_xx, bd]).ToString();
                        txtx2_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx2_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx2_4.Text = ("#").ToString();
                        txtx2_5.Text = ("#").ToString();
                    }
                    else if (bd == 3)
                    {
                        txtx2_1.Text = (y[y_xx, bd]).ToString();
                        txtx2_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx2_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx2_4.Text = (y[y_xx, bd - 3]).ToString();
                        txtx2_5.Text = ("#").ToString();
                    }
                    else if ((bd > 3) && (bd < 8))
                    {
                        txtx2_1.Text = (y[y_xx, bd]).ToString();
                        txtx2_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx2_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx2_4.Text = (y[y_xx, bd - 3]).ToString();
                        txtx2_5.Text = (y[y_xx, bd - 4]).ToString();
                    }
                    else if (bd == 8)
                    {
                        txtx2_1.Text = ("#").ToString();
                        txtx2_2.Text = (y[y_xx, bd]).ToString();
                        txtx2_3.Text = (y[y_xx, bd - 1]).ToString();
                        txtx2_4.Text = (y[y_xx, bd - 2]).ToString();
                        txtx2_5.Text = (y[y_xx, bd - 3]).ToString();
                    }
                    else if (bd == 9)
                    {
                        txtx2_1.Text = ("#").ToString();
                        txtx2_2.Text = ("#").ToString();
                        txtx2_3.Text = (y[y_xx, bd]).ToString();
                        txtx2_4.Text = (y[y_xx, bd - 1]).ToString();
                        txtx2_5.Text = (y[y_xx, bd - 2]).ToString();
                    }
                }
                #endregion

                #region txtx3
                //txtx3.Text
                if ((syc_t3 % (a + 2) == 0))
                {
                    y_xx = 2;
                    if (bd == 0)
                    {
                        txtx3_1.Text = (y[y_xx, bd]).ToString();
                        txtx3_2.Text = ("#").ToString();
                        txtx3_3.Text = ("#").ToString();
                        txtx3_4.Text = ("#").ToString();
                        txtx3_5.Text = ("#").ToString();
                    }
                    else if (bd == 1)
                    {
                        txtx3_1.Text = (y[y_xx, bd]).ToString();
                        txtx3_2.Text = (y[0, bd - 1]).ToString();
                        txtx3_3.Text = ("#").ToString();
                        txtx3_4.Text = ("#").ToString();
                        txtx3_5.Text = ("#").ToString();
                    }
                    else if (bd == 2)
                    {
                        txtx3_1.Text = (y[y_xx, bd]).ToString();
                        txtx3_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx3_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx3_4.Text = ("#").ToString();
                        txtx3_5.Text = ("#").ToString();
                    }
                    else if (bd == 3)
                    {
                        txtx3_1.Text = (y[y_xx, bd]).ToString();
                        txtx3_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx3_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx3_4.Text = (y[y_xx, bd - 3]).ToString();
                        txtx3_5.Text = ("#").ToString();
                    }
                    else if ((bd > 3) && (bd < 8))
                    {
                        txtx3_1.Text = (y[y_xx, bd]).ToString();
                        txtx3_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx3_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx3_4.Text = (y[y_xx, bd - 3]).ToString();
                        txtx3_5.Text = (y[y_xx, bd - 4]).ToString();
                    }
                    else if (bd == 8)
                    {
                        txtx3_1.Text = ("#").ToString();
                        txtx3_2.Text = (y[y_xx, bd]).ToString();
                        txtx3_3.Text = (y[y_xx, bd - 1]).ToString();
                        txtx3_4.Text = (y[y_xx, bd - 2]).ToString();
                        txtx3_5.Text = (y[y_xx, bd - 3]).ToString();
                    }
                    else if (bd == 9)
                    {
                        txtx3_1.Text = ("#").ToString();
                        txtx3_2.Text = ("#").ToString();
                        txtx3_3.Text = (y[y_xx, bd]).ToString();
                        txtx3_4.Text = (y[y_xx, bd - 1]).ToString();
                        txtx3_5.Text = (y[y_xx, bd - 2]).ToString();
                    }
                }
                #endregion

                #region txtx4
                //txtx4.Text
                if ( (syc_t4 % (a ) == 0))
                {
                    y_xx = 3;
                    if (bd == 0)
                    {
                        txtx4_1.Text = (y[y_xx, bd]).ToString();
                        txtx4_2.Text = ("#").ToString();
                        txtx4_3.Text = ("#").ToString();
                        txtx4_4.Text = ("#").ToString();
                        txtx4_5.Text = ("#").ToString();
                    }
                    else if (bd == 1)
                    {
                        txtx4_1.Text = (y[y_xx, bd]).ToString();
                        txtx4_2.Text = (y[0, bd - 1]).ToString();
                        txtx4_3.Text = ("#").ToString();
                        txtx4_4.Text = ("#").ToString();
                        txtx4_5.Text = ("#").ToString();
                    }
                    else if (bd == 2)
                    {
                        txtx4_1.Text = (y[y_xx, bd]).ToString();
                        txtx4_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx4_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx4_4.Text = ("#").ToString();
                        txtx4_5.Text = ("#").ToString();
                    }
                    else if (bd == 3)
                    {
                        txtx4_1.Text = (y[y_xx, bd]).ToString();
                        txtx4_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx4_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx4_4.Text = (y[y_xx, bd - 3]).ToString();
                        txtx4_5.Text = ("#").ToString();
                    }
                    else if ((bd > 3) && (bd < 8))
                    {
                        txtx4_1.Text = (y[y_xx, bd]).ToString();
                        txtx4_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx4_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx4_4.Text = (y[y_xx, bd - 3]).ToString();
                        txtx4_5.Text = (y[y_xx, bd - 4]).ToString();
                    }
                    else if (bd == 8)
                    {
                        txtx4_1.Text = ("#").ToString();
                        txtx4_2.Text = (y[y_xx, bd]).ToString();
                        txtx4_3.Text = (y[y_xx, bd - 1]).ToString();
                        txtx4_4.Text = (y[y_xx, bd - 2]).ToString();
                        txtx4_5.Text = (y[y_xx, bd - 3]).ToString();
                    }
                    else if (bd == 9)
                    {
                        txtx4_1.Text = ("#").ToString();
                        txtx4_2.Text = ("#").ToString();
                        txtx4_3.Text = (y[y_xx, bd]).ToString();
                        txtx4_4.Text = (y[y_xx, bd - 1]).ToString();
                        txtx4_5.Text = (y[y_xx, bd - 2]).ToString();
                    }
                }
                #endregion

                #region txtx5
                //txtx5.Text
                if ((syc_t7 % (a) == 0))
                {
                    y_xx = 4;
                    if (bd == 0)
                    {
                        txtx5_1.Text = (y[y_xx, bd]).ToString();
                        txtx5_2.Text = ("#").ToString();
                        txtx5_3.Text = ("#").ToString();
                        txtx5_4.Text = ("#").ToString();
                        txtx5_5.Text = ("#").ToString();
                    }
                    else if (bd == 1)
                    {
                        txtx5_1.Text = (y[y_xx, bd]).ToString();
                        txtx5_2.Text = (y[0, bd - 1]).ToString();
                        txtx5_3.Text = ("#").ToString();
                        txtx5_4.Text = ("#").ToString();
                        txtx5_5.Text = ("#").ToString();
                    }
                    else if (bd == 2)
                    {
                        txtx5_1.Text = (y[y_xx, bd]).ToString();
                        txtx5_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx5_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx5_4.Text = ("#").ToString();
                        txtx5_5.Text = ("#").ToString();
                    }
                    else if (bd == 3)
                    {
                        txtx5_1.Text = (y[y_xx, bd]).ToString();
                        txtx5_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx5_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx5_4.Text = (y[y_xx, bd - 3]).ToString();
                        txtx5_5.Text = ("#").ToString();
                    }
                    else if ((bd > 3) && (bd < 8))
                    {
                        txtx5_1.Text = (y[y_xx, bd]).ToString();
                        txtx5_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx5_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx5_4.Text = (y[y_xx, bd - 3]).ToString();
                        txtx5_5.Text = (y[y_xx, bd - 4]).ToString();
                    }
                    else if (bd == 8)
                    {
                        txtx5_1.Text = ("#").ToString();
                        txtx5_2.Text = (y[y_xx, bd]).ToString();
                        txtx5_3.Text = (y[y_xx, bd - 1]).ToString();
                        txtx5_4.Text = (y[y_xx, bd - 2]).ToString();
                        txtx5_5.Text = (y[y_xx, bd - 3]).ToString();
                    }
                    else if (bd == 9)
                    {
                        txtx5_1.Text = ("#").ToString();
                        txtx5_2.Text = ("#").ToString();
                        txtx5_3.Text = (y[y_xx, bd]).ToString();
                        txtx5_4.Text = (y[y_xx, bd - 1]).ToString();
                        txtx5_5.Text = (y[y_xx, bd - 2]).ToString();
                    }
                }
                #endregion

                #region txtx6
                //txtx6.Text
                if ( (syc_t6 % a == 0))
                {
                    y_xx = 5;
                    if (bd == 0)
                    {
                        txtx6_1.Text = (y[y_xx, bd]).ToString();
                        txtx6_2.Text = ("#").ToString();
                        txtx6_3.Text = ("#").ToString();
                        txtx6_4.Text = ("#").ToString();
                        txtx6_5.Text = ("#").ToString();

                    }
                    else if (bd == 1)
                    {
                        txtx6_1.Text = (y[y_xx, bd]).ToString();
                        txtx6_2.Text = (y[0, bd - 1]).ToString();
                        txtx6_3.Text = ("#").ToString();
                        txtx6_4.Text = ("#").ToString();
                        txtx6_5.Text = ("#").ToString();
                    }
                    else if (bd == 2)
                    {
                        txtx6_1.Text = (y[y_xx, bd]).ToString();
                        txtx6_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx6_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx6_4.Text = ("#").ToString();
                        txtx6_5.Text = ("#").ToString();
                    }
                    else if (bd == 3)
                    {
                        txtx6_1.Text = (y[y_xx, bd]).ToString();
                        txtx6_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx6_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx6_4.Text = (y[y_xx, bd - 3]).ToString();
                        txtx6_5.Text = ("#").ToString();
                    }
                    else if ((bd > 3) && (bd < 8))
                    {
                        txtx6_1.Text = (y[y_xx, bd]).ToString();
                        txtx6_2.Text = (y[y_xx, bd - 1]).ToString();
                        txtx6_3.Text = (y[y_xx, bd - 2]).ToString();
                        txtx6_4.Text = (y[y_xx, bd - 3]).ToString();
                        txtx6_5.Text = (y[y_xx, bd - 4]).ToString();
                    }
                    else if (bd == 8)
                    {
                        txtx6_1.Text = ("#").ToString();
                        txtx6_2.Text = (y[y_xx, bd]).ToString();
                        txtx6_3.Text = (y[y_xx, bd - 1]).ToString();
                        txtx6_4.Text = (y[y_xx, bd - 2]).ToString();
                        txtx6_5.Text = (y[y_xx, bd - 3]).ToString();
                    }
                    else if (bd == 9)
                    {
                        txtx6_1.Text = ("#").ToString();
                        txtx6_2.Text = ("#").ToString();
                        txtx6_3.Text = (y[y_xx, bd]).ToString();
                        txtx6_4.Text = (y[y_xx, bd - 1]).ToString();
                        txtx6_5.Text = (y[y_xx, bd - 2]).ToString();
                    }
                }
                #endregion

                bd++;
            }
            else if (zz > 60) { this.timer1.Stop(); }
            #endregion
        }

        #region button1
        private void Button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
#endregion