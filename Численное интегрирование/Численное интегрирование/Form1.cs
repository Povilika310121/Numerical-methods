using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Численное_интегрирование
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double f(double x)
        {
            double f = Math.Sin(2*x-2.1)/(x*x+1);
            return f;        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown2.Value;
            double steps = (double)numericUpDown3.Value;//количество точек
            double accurasy = (double)numericUpDown4.Value;//точность

            double result, result1;
            int count = 0;
            double F = (f(a) + f(b)) / 2;
            result  = F;
            result1 = F;
           
            double  step = (double)((b - a) / steps);//промежутотк между точками
            double Sstep = step;
            for (int i = 1; i < steps - 1; ++i)
                result += f(a + i * step);
            result *= step;
            count++;

            while (Math.Abs(result - result1) > accurasy)
            {
                result1 = result;
                step = step / 2;
                steps = (int)((b - a) / step);
                for (int i = 1; i < steps - 1; ++i)
                    result += f(a + i * step);
                result *= step;
                count++;
            }

            double Sresult,  S1result1;
            int Scount = 0; 
            Sresult = S1result1=0;
            for (int i = 1; i <= steps ; ++i)
                Sresult += f(a + (i - 1) * Sstep) + 4 * f(a + (i - 0.5) * Sstep) + f(a + i * Sstep);
            Sresult *= (Sstep / 6);
            Scount++;
            while (Math.Abs(Sresult - S1result1) > accurasy)
            {
                S1result1 = Sresult;
                Sstep = Sstep / 2;
                steps = (int)((b - a) / Sstep);
                for (int i = 1; i <= steps ; ++i)
                    Sresult += f(a + (i-1) * Sstep)+4* f(a + (i - 0.5) * Sstep)+ f(a + i * Sstep);
                Sresult *= (Sstep/6);
                Scount++;
            }
            Console.WriteLine($"Кол-во иттераций Трапеции {count}");
            Console.WriteLine($"Кол-во иттераций Simpson {Scount}");
            textBox1.Text = result.ToString();
            Simpson.Text = Sresult.ToString();
        }
    }
}
