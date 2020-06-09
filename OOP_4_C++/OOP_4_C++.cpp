#include <iostream>
using namespace std;
class MyVector
{
private:
	int x, y;
	double length;
public:
	MyVector()
	{
		x = y = 0;
	}
	MyVector(int x, int y)
	{
		this->x = x;
		this->y = y;
		length = sqrt(x ^ 2 + y ^ 2);
	}

	MyVector(const MyVector& other)
	{
		this->x = other.x;
		this->y = other.y;
		length = sqrt(x ^ 2 + y ^ 2);
	}
	double GetLength()
	{
		return length;
	}
	int X()
	{
		return x;
	}
	int Y()
	{
		return y;
	}
	
	friend MyVector operator+(const MyVector& L1, const MyVector& L2);
	friend MyVector operator *(MyVector L1, double n);
};
MyVector operator+(const MyVector& L1, const MyVector& L2)
{
	MyVector rez;
	rez.length = L1.length + L2.length;
	return (rez);


};
 MyVector operator *(MyVector L1, double n)
{
	L1.length = L1.length * n;
	return L1;
}

int main()
{
	MyVector L1(2, 5),L2(3, 6);
	L1.GetLength();
	L1 = L1 * 2;
	MyVector L3;
	L3 = L1 + L2;
	cout << L1.GetLength();
	cout << L3.GetLength();
}