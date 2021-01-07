#include <iostream>
#include <math.h>
using namespace std;

const double eps = 0.001; ///< желаемая точность 

/// N - размерность матрицы; A[N][N] - матрица коэффициентов, F[N] - столбец свободных членов,
/// X[N] - начальное приближение, ответ записывается также в X[N];
void Jacobi(int N, double** A, double* F, double* X)//метод якоби алгоритм из википедии
{
	double* Matr = new double[N];
	double norma; // норма, определяемая как наибольшая разность компонент столбца иксов соседних итераций.
	do {
		for (int i = 0; i < N; i++) {
			Matr[i] = F[i];
			for (int g = 0; g < N; g++) {
				if (i != g)
					Matr[i] -= A[i][g] * X[g];
			}
			Matr[i] /= A[i][i];
		}
		norma = abs(X[0] - Matr[0]);
		for (int h = 0; h < N; h++) {
			if (abs(X[h] - Matr[h]) > norma)
				norma = abs(X[h] - Matr[h]);
			X[h] = Matr[h];
		}
	} while (norma > eps);
	delete[] Matr;
}
int main()
{
	double N, b, eps;
	int k;
	do {
		cout << "Kol-vo uravnenii = ";
		cin >> N;
		double** A = new double* [N];
		for (int i = 0; i < N; i++) //заполняем массив коэффициентов
		{
			A[i] = new double[N];
			for (int j = 0; j < N; j++) 
			{
				cout << "A[" << i << "][" << j << "] = ";
				cin >> A[i][j];
			}
		}
		double* F = new double [N];
		for (int i = 0; i < N; i++)//массив правых частей уравнений
		{
			cout << "F[" << i << "] = ";
			cin >> F[i];
		}
		double* X = new double[N];
		
	    Jacobi(N, A, F, X);
		for (int i = 0; i < N; i++)//вывод ответа 
			cout << "X[" << i << "]=" << X[i] << endl;
		cout << "Exit 9 -> ";
		cin >> k;
	} while (k != 9);

	system("pause");
	return 0;
}
