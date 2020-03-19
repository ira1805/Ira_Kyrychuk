#include <iostream>
#include "Header.h"
using namespace std;
int main()
{
	
	int x, a, b;
	cout << "Enter x:" << endl;
	cin >> x;
	Reduction(x);
	cout <<"X="<< x << endl;
	cout << "Enter a i b:" << endl;
	cin >> a;
	cin >> b;
	int res=compare(a, b);
	if (res == 1)
		cout << "x<y";
	else
		cout << "x>y";

	

	

}
