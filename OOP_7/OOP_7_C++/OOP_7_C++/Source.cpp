#include <iostream>
using namespace std;
class List
{
public:
	class Node
	{
	public:
		Node* next;
		char data;
		Node(char data, Node* next = nullptr)
		{
			this->data = data;
			this->next = next;
		};
		
	};
	Node* head=0;
	int size;
	void push_back(char data)
	{
		if (head == nullptr)
		{
			head = new Node(data);
		}
		else
		{
			Node* current = this->head;
			while (current->next !=nullptr)
			{
				current = current->next;
			}
			current->next = new Node(data);
		}
		size++;
	}
	int get_size()
	{
		return size;
	}
	 char &operator[](const int index)
	 {
		int counter = 0;
		Node* current = this->head;
		while (current != nullptr)
		{
			if (counter == index)
			{
				return current->data;
			}
			current = current->next;
			counter++;
		}
		
	 }
	 int amount(List& list)
	 {
		 int counter = 0;
		 for (int i = 0; i < list.get_size(); i+=2)
		 {
			 if (list[i] =='#')
				 counter++;
		 }
		 return counter;
	 }
	 void erase(int index)
	 {
		 if (index == 0)
		 {
			 Node* tmp = head;
			 head = head->next;
			 delete tmp;
			 size--;
		 }
		 else
		 {
			 Node* previous = this->head;
			 for (int i = 0; i < index - 1; i++)
			 {
				 previous = previous->next;
				 Node* todelete = previous->next;
				 previous->next = todelete->next;
				 delete todelete;
				 size--;

			 }
		 }
	 }
	 void deleteChars(List &list)
	 {
		 for (int i = 0; i < list.get_size(); i++)
		 {
			 if (list[i] > 'a')
				 list.erase(i);
		 }
	 }
	 void print(List lst)
	 {
		 for (int i = 0; i < lst.get_size(); i++)
			 cout << lst[i];
	 }

};

int main()
{
	List lst;
	lst.push_back('s');
	lst.push_back('a');
	lst.push_back('#');
	lst.push_back('s');
	lst.print(lst);
	cout <<"\n-----------------" << endl;
	cout<<lst.amount(lst);
	lst.deleteChars(lst);
	cout << "\n-----------------" << endl;
	lst.print(lst);
	return 0;
}