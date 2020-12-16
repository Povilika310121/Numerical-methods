#include <iostream>
//Задание 7 метод деления отрезка попалам для нелинейных уравнений
using namespace std;

double func(double x) //искомая функция
{
	return sin(x) + 1 - x;
}

double sign(double x) //знак функции в точке х
{
	if (x < 0)
		return -1;
	if (x == 0)
		return 0;
	return 1;
}

double bisection_method(double a, double b, double (*func)(double), double eps) 
{
	if (func(a) == 0)
		return a;
	if (func(b) == 0)
		return b;
	double m;
	while (b - a > eps) //пока длина отрезка больше точности
	{
		double dx = (b - a) / 2;
		m = a + dx; //Точка х в середине отрезка:
		if (sign(func(a)) != sign(func(m))) //если знаки в начале отрезка и середине отличаются
			b = m; //то конец отрезка переносится на середину [a,m]
		else
			a = m;//иначе на начало [m,b]
	}
	return m;
}

int main() 
{
	double a, b, eps;
	cout << "a = ";
	cin >> a;
	cout << "b = ";
	cin >> b;
	cout << "eps = ";
	cin >> eps;

	cout << "x = " << bisection_method(a, b, func, eps)<<endl;
	system("pause");
	return 0;
}