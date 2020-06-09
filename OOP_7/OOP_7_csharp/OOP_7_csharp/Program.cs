using System;
class List
{
    public Node head = null;
    class Node
    {
        public Node next;
        public char data;

        public Node(char data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }

    public int size;

    public void push_back(char data)
    {
        if (head == null)
        {
            head = new Node(data, null);
        }
        else
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(data, null);
        }
        size++;
    }

    public int get_size()
    {
        return size;
    }

    public char this[int index]
    {
        get
        {
            int counter = 0;
            Node current = head;
            while (current != null)
            {
                if (counter == index)
                {
                    return current.data;
                }
                current = current.next;
                counter++;
            }
            return '?';
        }
        set
        {
            int counter = 0;
            Node current = head;
            while (current != null)
            {
                if (counter == index)
                {
                    current.data = value;
                    return;
                }
                current = current.next;
                counter++;
            }
        }
    }

    public int amount(List list)
    {
        int counter = 0;
        for (int i = 0; i < list.get_size(); i += 2)
        {
            if (list[i] == '#')
            {
                counter++;
            }
        }
        return counter;
    }

    public void erase(int index)
    {
        if (index == 0)
        {
            head = head.next;
            size--;
        }
        else
        {
            Node previous = head;
            for (int i = 0; i < index - 1; i++)
            {
                previous = previous.next;
                previous.next = previous.next.next;
                size--;
            }
        }
    }

    public void deleteChars(List list)
    {
        for (int i = 0; i < list.get_size(); i++)
        {
            if (list[i] > 'a')
            {
                list.erase(i);
            }
        }
    }

    public void print(List lst)
    {
        for (int i = 0; i < lst.get_size(); i++)
        {
            Console.Write(lst[i]);
        }
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        List lst = new List();
        lst.push_back('s');
        lst.push_back('a');
        lst.push_back('#');
        lst.push_back('s');
        lst.print(lst);
        Console.WriteLine();
        Console.WriteLine("-----------------");
        Console.Write(lst.amount(lst));
        lst.deleteChars(lst);
        Console.WriteLine();
        Console.WriteLine("-----------------");
        lst.print(lst);
        Console.WriteLine();
    }
}
