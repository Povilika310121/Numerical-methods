using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задача_Коши_Метод_Эйлера
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		// отрезок [0,1]
		private void button1_Click(object sender, EventArgs e)
		{
			this.chart1.Series[0].Points.Clear();
			double h = 0.01;
			int size = Convert.ToInt32(1 / h);
			double[] x = new double[size]; //массив x`ов
			double[] y = new double[size]; //массив у`ов
			x[0] = (double)this.x0.Value;  //начальное условие для х
			y[0] = (double)this.y0.Value;  //начальное условие для у
			int  n = (int)this.n.Value;		//количество итераций

			double func(double a, double b) // функция y`=f(x,y)
			{
				return 6 * a * a + 5 * a * b; 
			}
		
			for (int i = 0; i < n - 1; ++i) //y[i]=y[i-1]+h*f(x[i-1],y[i-1])
			{
				y[i + 1] += h * func(x[i], y[i]);
				x[i+1] += h;
				Console.WriteLine($"{y[i+1]} - {x[i+1]}");
			}
			chart1.ChartAreas[0].AxisX.Minimum = 0;//начало отрезка
			chart1.ChartAreas[0].AxisX.Maximum = 1;//конец отрезка
			chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 0.2;//шаг
			chart1.Series[0].Points.DataBindXY(x, y);//точки
		}	
	}

}
