
#include "string.h"
#include "iostream"
#include "vector"
using namespace std;
class SString_
{
	vector <char> s;

public:
	SString_()
	{

	}
	SString_(char* str)
	{
		for (int i = 0; i < strlen(str); i++)
			s.push_back(str[i]);
		s.push_back('\n');
	}
	~SString_()
	{

	}
	void SetStr(char* str)
	{
		for (int i = 0; i < strlen(str); i++)
			s.push_back(str[i]);
		s.push_back('\n');

	}
	void Clear()
	{
		while (s.size() != 0)
			s.pop_back();
	}
	char getChar(int n)
	{
		return s[n];
	}
	void print()
	{
		for (int i = 0; i < s.size(); i++)
			cout << s[i];
	}
	unsigned short getSize()
	{
		return s.size();
	}
	void up()
	{
		for (int i = 0; i < s.size(); i++)
		{
			if (s[i] >= 'a' && s[i] <= 'z') s[i] -= ('a' - 'A');
		}
	}
	bool cmp(SString_ str)
	{

		if (str.getSize() != s.size()) return false;
		for (int i = 0; i < s.size(); i++)
		{
			if (s[i] != str.getChar(i)) return false;
		}

		return true;
	}

};

class Text
{
	vector <SString_> T;
public:
	Text()
	{
	}
	void Init(vector <SString_> Vec)
	{
		for (int i = 0; i < Vec.size(); i++)
			T.push_back(Vec[i]);
	}
	void AddLine(SString_ S)
	{
		T.push_back(S);
	}
	void Delete(int n)
	{
		T.erase(T.begin() + n - 1, T.begin() + n);
	}
	void print()
	{
		for (int i = 0; i < T.size(); i++)
			T[i].print();
	}
	void Upper()
	{
		for (int i = 0; i < T.size(); i++)
			T[i].up();
	}
	int Cmp(SString_ S)
	{
		int count = 0;
		for (int i = 0; i < T.size(); i++)
		{

			if (T[i].cmp(S))
			{
				count++;
			}

		}
		return count;
	}
	void Delete2(int n)
	{
		for (int i = 0; i < T.size(); i++)
		{
			int size = T[i].getSize() - 1;
			if (n == size)
			{
				T.erase(T.begin() + i);
			}

		}
	}
	void Clear()
	{
		for (int i = 0; i < T.size(); i++)
			T[i].Clear();
	}
};

int main()
{
	char text[7][30] = { "1.erewqr","2.fgdfsg","3.fdssgdf","4.fsdtg","5.tgfcfdgxv" };
	vector <SString_> Z;
	for (int i = 0; i < 5; i++)
		Z.push_back(text[i]);
	Text  Q;
	Q.Init(Z);
	cout << "Text" << endl;
	Q.print();
	cout << "---------------" << endl;
	cout << "1.Add line" << endl;
	char addline[16] = "6.bcdnhbedj";
	Q.AddLine(addline);
	Q.print();
	cout << "-----------------" << endl;
	cout << "2.Delete line" << endl;
	cout << "Enter number of line" << endl;
	int number;
	cin >> number;
	Q.Delete(number);
	cout << "Text after change" << endl;
	Q.print();
	cout << "-----------------" << endl;
	cout << "3.Bring the characters to uppercase" << endl;
	Q.Upper();
	Q.print();
	cout << "------------------" << endl;
	char line[16] = "2.FGDFSG";
	cout << "4.The number of identical rows" << endl;
	cout << "Cmp =" << Q.Cmp(line) << endl;
	cout << "---------------" << endl;
	cout << "5.Delete line of a certain length " << endl;
	cout << "Enter size" << endl;
	int n;
	cin >> n;
	Q.Delete2(n);
	Q.print();
	cout << "------------" << endl;
	cout << "6.Clear text" << endl;
	Q.Clear();
	Q.print();
	cout << "\nClear text";



	return 0;
}
