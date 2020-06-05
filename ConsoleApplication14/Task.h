#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <vector>
#include <functional>
#include <queue>
using namespace std;
class Company 
{
public:
	priority_queue<Task, vector<Task>, ComparePrior> Q;//queue of priorities
	vector<Task> tasks;
	vector<Task> inProcess;
	int n;//number of tasks
	int maxWorkers;//number of workers

	void readTasks()// function that reads the task
	{
		for (int i = 0; i < n; ++i) {
			int t, priority;
			string s;
			scanf("%d %d", &t, &priority);
			cin >> s;
			Task temp;
			if (t < 0 && priority < 0)
				cout<<("You entered incorrect data\n");
			else
			{
				temp.time = t;//initial time
				temp.timeLeft = t;//remaining time
				temp.priority = priority;//task priority
				temp.text = s;//task condition
				temp.status = "UNSTARTED";//the initial status of the task
				this->tasks.push_back(temp);//throw the task at the end of the queue
			}
		}
	}

	void fillQueue() // function that fills the queue with priority tasks
	{
		for (Task task : tasks) 
		{
			this->Q.push(task);
		}
	}

	void runTasks() 
	{
		scanf("%d %d", &n, &maxWorkers);
		if (n < 0 && maxWorkers < 0)
			cout << ("You entered incorrect data\n");
		this->readTasks();// function that reads the task
		this->fillQueue();// function that fills the queue with priority tasks

		int freeWorkers = maxWorkers;

		while (1) 
		{
			while (freeWorkers != 0 && !Q.empty())
				//the cycle works as long as there are free workersand the queue is not empty
			{
				Task temp = Q.top();
				this->Q.pop();
				temp.status = "UNFINISHED";
				printf("Started Task with priority %d, will take %d to finish.\n", temp.priority, temp.time);
				cout << temp.text << endl;
				this->inProcess.push_back(temp);
				freeWorkers--;
			}

			for (int i = 0; i < inProcess.size(); i++)
			{
				if (inProcess[i].status == "UNFINISHED") 
				{
					this->inProcess[i].timeLeft--;
					if (inProcess[i].timeLeft == 0)
					{
						this->inProcess[i].status = "FINISHED";
						cout << "Ended Task: " + inProcess[i].text << endl;
						freeWorkers++;
					}
				}
			}

			bool flag = true;
			for (Task t : inProcess)
			{
				if (t.status == "UNFINISHED")
				{
					flag = false;
				}
			}
			if (flag) 
			{
				break;
			}

		}


	}
};
