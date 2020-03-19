#include <iostream>

using namespace std;
void Reduction(int& x)
{
	int b;
	for (int j = 0;j < sizeof(int) * 8 - 1; j++)
	{
	  b = x & (1 << j);
	  if (b > 0)
	  {
		for (int i = 0; i < j + 1; i++)
		x = x ^ (1 << i);
		break;
	  }
	}
		
}
bool compare(int a, int b)
 {  
	int bitA = (a >> sizeof(int) * 8 - 1) & 1;
	int bitB = (b >> sizeof(int) * 8 - 1) & 1;
	if (bitA < bitB)
		return false;
	else if (bitA > bitB)
		return true;
	else
		for (int i = 30; i >= 0; i--) {
			bitA = (a >> i) & 1;
			bitB = (b >> i) & 1;
			if (bitA != bitB && bitA == 0)
				return true;
			else if (bitA != bitB && bitA == 1)
				return false;
		}
}


