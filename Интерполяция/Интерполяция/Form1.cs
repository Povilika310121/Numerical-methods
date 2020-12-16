using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Интерполяция
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();//sin
            this.chart1.Series[1].Points.Clear();//polinom
            this.chart1.Series[2].Points.Clear();//чебышевские

            double a = (double)numericUpDown2.Value;//начало отрезка
            double b = (double)numericUpDown1.Value;//конец отрезка
            double h = (double)numericUpDown3.Value;//шаг сетки
            int stepenPolinom = (int)numericUpDown4.Value - 1;//степень полинома
            double n, n1;
            n = a;
            n1 = a;
            int size = Convert.ToInt32((b - a) / h) + 1;//количество точек

            double[] x_m = new double[size];//для функции
            double[] y_m = new double[size];

            double[] x_ma = new double[size];//для лагранжа
            double[] y_ma = new double[size];

            double[] x_ch = new double[stepenPolinom + 1];//чебышевские
            double[] y_ch = new double[size];

            //изначальная функция
            for (int i = 0; i < size; i++)
            {
                x_m[i] = n;
                y_m[i] = Math.Abs(n);
                n += h;
                Console.WriteLine($"x_m={x_m[i]}->{y_m[i]}");
            }

            //х`ы для полинома ЧЕБЫ 
            for (int i = 1; i <= stepenPolinom + 1; i++)
            {
                x_ch[i - 1] = Math.Cos(Math.PI * (2 * i - 1) / (2 * (stepenPolinom + 1)));
                Console.WriteLine($"i-1={i - 1} -> {x_ch[i - 1]} ");
            }

            n1 = a - h;
            for (int step = 0; step < size; step++)
            {
                double l = 0.0, l_ch = 0.0;
                x_ma[step] = n1 + h;             //х`ы для полинома лагранжа 
                n1 += h;
                for (int i = 0; i <= stepenPolinom; i++)
                {
                    double p = 1.0;
                    double p_ch = 1.0;
                    for (int j = 0; j <= stepenPolinom; j++)
                    {
                        if (j != i)
                        {
                            p *= ((n1 - (a + ((b - a) / stepenPolinom) * j)) / ((a + ((b - a) / stepenPolinom) * i) - (a + ((b - a) / stepenPolinom) * j)));
                            p_ch *= ((n1 - x_ch[j]) / (x_ch[i] - x_ch[j]));
                        }
                    }
                    l += p * Math.Abs(a + ((b - a) / stepenPolinom) * i);
                    l_ch += p_ch * Math.Abs(x_ch[i]);
                }
                y_ma[step] = l;
                y_ch[step] = l_ch;
            }
            chart1.ChartAreas[0].AxisX.Minimum = a;
            chart1.ChartAreas[0].AxisX.Maximum = b;

            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = h;

            chart1.Series[0].Points.DataBindXY(x_m, y_m);
            chart1.Series[1].Points.DataBindXY(x_m, y_ma);
            chart1.Series[2].Points.DataBindXY(x_m, y_ch);
        }
        //ПОСТРОИТЬ ЧЕБЫШЕВСКИЕ ДЛЯ [-1,1]

    }
}
