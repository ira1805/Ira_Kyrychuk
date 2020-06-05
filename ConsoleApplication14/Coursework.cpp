#i#define _CRT_SECURE_NO_WARNINGS
nclude <iostream>
#include <vector>
#include <functional>
#include <queue>
#include "Task.h"
using namespace std;

struct Task
{
	int priority;// a variable that serves to maintain priority
	string status;//task status
	string text;//task name
	int time;//a variable that serves to maintain time
	int timeLeft;//a variable that serves to maintain the remaining time
};

struct ComparePrior
{
	bool operator()(Task const& t1, Task const& t2)
	{
		// return "true" if "t1" is ordered
		// before "t2", for example:
		return t1.priority > t2.priority;
	}
};


int main() 
{
	cout << "Good day. Your planner greets you." << endl << " If you want to have time quickly and do a good job, you need to give tasks to all employees.To do this, you need :" << endl <<"1. Enter the number of tasks and the number of workers" << endl << "2. Execution time and priority" << endl << "3. It is good to describe the essence of the task" << endl;
    Company c;
	c.runTasks();
	return 0;
}