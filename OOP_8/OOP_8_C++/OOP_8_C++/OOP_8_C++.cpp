#include <iostream>
#include <ctime>
#include <math.h>
#include <stdio.h>
using namespace std;
void Sum(int n,int m,int** arr)
{
	for (int i = 0; i < n; ++i)
	{
		int sum = 0;         
		for (int j = 0; j < m; ++j) {
			sum += arr[i][j];
		}
		cout << sum << endl;
	}
}
int main()
{
	srand(time(NULL));
	int n,m; 
	cin >> n;  
	cin >> m;	
	int** arr = new int* [n];
	for (int i = 0; i < n; ++i) {
		arr[i] = new int[m];
		for (int j = 0; j < m; ++j) {
			arr[i][j] = 100 + rand() % (100-1);
			cout << arr[i][j]<<" ";  
		}
		cout << endl;
	}
	void(*Sumarr)(int n,int m,int** arr);
	Sumarr = Sum;
	Sum(n, m, arr);
	for (int i = 0; i < n; ++i) 
	{  

		delete arr[i];
	}
	delete[] arr;
	system("pause");
}