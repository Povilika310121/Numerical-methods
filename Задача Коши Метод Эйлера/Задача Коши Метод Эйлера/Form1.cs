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
		private void button1_Click(object sender, EventArgs e)
		{
			double func(double a, double b) // функция y`=f(x,y)
			{
				return ((b * b) / 2 - (b / a));
			}

			double func_(double a) // функция y_0=у(x)
			{
				return 2 / (a - a * Math.Log(a));
			}

			this.chart1.Series[0].Points.Clear();
			this.chart1.Series[1].Points.Clear();

			int n = (int)this.n.Value;     //количество итераций
			double[] x = new double[n]; //массив x`ов
			double[] y = new double[n]; //массив у`ов
			double[] x_ = new double[n]; //массив x`ов аналитического способа
			double[] y_ = new double[n]; //массив у`ов аналитического способа
			double h = (double) 1/n; //шаг
			double nevyazka = 0;
			
			x[0] = 1;	//начальное условие для х
			y[0] = 2;   //начальное условие для у
			x_[0] = 1;
			y_[0] = 2;
					
			for (int i = 0; i < n - 1; ++i) 
			{
				y[i + 1] = y[i] + h * func(x[i], y[i]);
				x[i+1] = x[i] + h;
				y_[i + 1] = func_(x_[i]);
				x_[i + 1] = x_[i] + h;
				if (Math.Abs(y_[i + 1] - y[i]) > nevyazka)
					nevyazka = y_[i + 1] - y[i];
			}
			this.textBox5.Text=nevyazka.ToString();
			// отрезок [1,2]
			chart1.ChartAreas[0].AxisX.Minimum = 1;//начало отрезка
			chart1.ChartAreas[0].AxisX.Maximum = 2;//конец отрезка
			chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 0.1;//шаг
			chart1.Series[0].Points.DataBindXY(x, y);//точки численный метод
			chart1.Series[1].Points.DataBindXY(x_, y_);//точки аналитический метод
		}
	}
}
