#include <iostream>
#include <cmath>
#include <exception>
using namespace std;

class Example
{
private:
	float a, b, c, d;
public:
	Example()
	{
		a = 0;
		b = 0;
		c = 0;
		d = 1;
	}

	Example(float a, float b, float c, float d)
	{
		this->a = a;
		this->b = b;
		this->c = c;
		this->d = d;
	}

	float Result()
	{
		if (4 * b - c <= 0)
			throw invalid_argument("4 * b - c <= 0\n");
		if (d == 0)
			throw invalid_argument("d == 0\n");
		if (b + c / d - 1 == 0)
			throw invalid_argument("b + c / d - 1 == 0\n");
		return (log10(4 * b - c) * a) / (b + c / d - 1);
	}

	Example operator+(const Example& other)
	{
		return Example(this->a + other.a, this->b + other.b, this->c + other.c, this->d + other.d);
	}

	Example operator-(const Example& other)
	{
		return Example(this->a - other.a, this->b - other.b, this->c - other.c, this->d - other.d);
	}

	Example operator*(const Example& other)
	{
		return Example(this->a * other.a, this->b * other.b, this->c * other.c, this->d * other.d);
	}

	Example operator/(const Example& other)
	{
		if (other.a == 0 || other.b == 0 || other.c == 0 || other.d == 0)
			throw exception("Division by zero\n");
		else
			return Example(this->a / other.a, this->b / other.b, this->c / other.c, this->d / other.d);
	}
};

int main()
{
	const int size = 6;
	int i = 0;
	Example arr[size];
	arr[0] = Example(1, 2, 3, 42);
	arr[1] = Example(2, -1, 2, 36);
	arr[2] = arr[0] - arr[1];
	arr[3] = arr[1] + arr[2];
	arr[4] = arr[2] * arr[3];
	try
	{
		arr[5] = arr[3] / arr[4];
	}
	catch (const exception & ex)
	{
		cout << ex.what();
	}
	while (i < size)
	{
		try
		{
			for (i; i < size; i++)
				cout << "arr[" << i << "] = " << arr[i].Result() << endl;
		}
		catch (const invalid_argument & ex)
		{
			cout << ex.what();
		}
		i++;
	}

	return 0;
}