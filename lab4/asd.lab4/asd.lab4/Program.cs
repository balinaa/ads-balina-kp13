using System;
using static System.Console;

namespace asd.lab4
{
    class SLNode
    {
        public int data;
        public SLNode next { get; set; }
        public SLNode(int data)
        {
            this.data = data;
        }
    }
    class List
    {
        public SLNode t;
        public List()
        {
            this.t = null;
        }
        public bool AddLast(int data)
        {
            if (t == null)
            {
                t = new SLNode(data);
                t.next = t;
            }
            else
            {
                SLNode newnode = new SLNode(data);
                newnode.next = t.next;
                t.next = newnode;
                t = newnode;
            }
            return true;
        }
        public bool AddFirst(int data)
        {
            if (t == null)
            {
                t = new SLNode(data);
                t.next = t;
            }
            else
            {
                SLNode newNode = new SLNode(data);
                newNode.next = t.next;
                t.next = newNode;
            }
            return true;
        }
        public bool AddAtPosition(int data, int pos) 
        {
            int Count = GetCount();
            if (t == null || pos <= 0 || pos > Count)
          
            {
                return AddFirst(data);
            }
            else if (pos == Count) 
            {
                return AddLast(data);
            }
            else
            {
                SLNode current = t;
                for (int i = 0; i < pos; i++)
                {
                    current = current.next;
                }
                SLNode newNode = new SLNode(data);
                newNode.next = current.next;
                current.next = newNode;

            }
            return true;
        }
        public bool DeleteFirst()
        {
            if (t == null)
            {
                WriteLine("Список пустий");
                return false;
            }
            else if (t.next == t)
            {
                t = null;
            }
            else
            {
                t.next = t.next.next;
            }
            return true;
        }
        public bool DeleteLast()
        {
            if (t == null)
            {
                WriteLine("Список пустий");
                return false;
            }
            else if (t.next == t)
            {
                t = null;
            }
            else
            {
                SLNode current = t.next;
                while (current.next != t)
                {
                    current = current.next;
                }
                current.next = t.next;
                t = current;

            }
            return true;
        }
        public bool DeleteAtPosition(int pos) 
        {
            int Count = GetCount();
            if (t == null || pos >= Count || pos < 0)
                return false;
            else if (t.next == t)
            {
                t = null;
            }
            else if (pos == 0)
            {
                return DeleteFirst();
            }
            else if (pos == Count - 1)
            {
                return DeleteLast();
            }
            else
            {
                SLNode current = t;
                for (int i = 0; i < pos; i++)
                {
                    if (current.next == t && i != pos - 1)
                    {
                        return false;
                    }
                    current = current.next;
                }
                current.next = current.next.next;
            }
            return true;
        }
        public bool AddBeforeMid(int data)
        {
            int Count = GetCount();
            int pos = Count / 2;
            if (Count % 2 == 1)
            {
                pos++;
            }
            return AddAtPosition(data, pos);
        }
        public void GenerateList(int num)
        {
            Random rand = new Random();
            t = null;
            for (int i = 0; i < num; i++)
            {
                AddFirst(rand.Next(-99, 100));
            }
        }
        public void Print()
        {
            if (t == null)
            {
                WriteLine("Список пустий");
                return;
            }
            SLNode current = t.next;
            while (current != t)
            {
                Write(current.data + ", ");
                current = current.next;
            }
            WriteLine(t.data);
        }
        public int GetCount()
        {
            if (t == null)
                return 0;
            int count = 1;
            SLNode current = t.next;
            while (current != t)
            {
                count++;
                current = current.next;
            }
            return count;
        }

    }
    class Program
        {
            static void Main(string[] args)
            {
            List list = new List();
            while (true)
            {
                WriteLine("допомога:\n1.  добавити останній\n2.  добавити перший\n3. добавити на позицію\n4.  вилучити перший\n5.  вилучити останній\n6.  вилучити з позиції\n7.  додати вузол перед першим із другої половини\n8.  генерувати список з N вузлів з випадковими даними\n9.  вивод списку\n10. вихід");
                int request = 9;
                Write("номер команди: ");
                try
                {
                    request = Int32.Parse(ReadLine());

                }
                catch
                {
                    WriteLine("помилка");
                    break;
                }

                int data = 0, pos = 0;
                if (request == 1)
                {
                    try { Write("число у вузлі: "); data = Int32.Parse(ReadLine()); }
                    catch
                    {
                        WriteLine("помилка");
                        break;
                    }
                    list.AddLast(data);
                }
                else if (request == 2)
                {
                    try { Write("число у вузлі: "); data = Int32.Parse(ReadLine()); }
                    catch
                    {
                        WriteLine("помилка");
                        break;
                    }
                    list.AddFirst(data);

                }
                else if (request == 3)
                {
                    try { Write("число у вузлі: "); data = Int32.Parse(ReadLine()); Write("position: "); pos = Int32.Parse(ReadLine()); }
                    catch
                    {
                        WriteLine("помилка");
                        break;
                    }
                    list.AddAtPosition(data, pos);
                }
                else if (request == 4)
                {
                    list.DeleteFirst();
                }
                else if (request == 5)
                {
                    list.DeleteLast();
                }
                else if (request == 6)
                {
                    try { Write("позиція: "); pos = Int32.Parse(ReadLine()); }
                    catch
                    {
                        WriteLine("помилка");
                        break;
                    }
                    list.DeleteAtPosition(pos);
                }
                else if (request == 7)
                {
                    try { Write("число у вузлі: "); data = Int32.Parse(ReadLine()); }
                    catch
                    {
                        WriteLine("помилка");
                        break;
                    }
                    list.AddBeforeMid(data);
                }
                else if (request == 8)
                {
                    try { Write("кол-во вузлів: "); data = Int32.Parse(ReadLine()); }
                    catch
                    {
                        WriteLine("помилка");
                        break;
                    }
                    list.GenerateList(data);
                }
                else if (request == 9)
                {
                    list.Print();
                }
                else if (request == 10)
                {
                    break;
                }
                Clear();
                WriteLine("Список:");
                list.Print();

                }
            }
    }
}

