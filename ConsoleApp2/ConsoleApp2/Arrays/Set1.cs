using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp2.Arrays
{
    internal class Set1
    {
        public static void SetMake()
        {
            SortedSet<String> set = new SortedSet<String>();
             for(int i = 10; i > 0; i--)
            {
                set.Add(i.ToString());
            }
             foreach(String i in set){
                Console.WriteLine(i);
            }

        }

        public static void TestQueue()
        {
            Queue q = new Queue();
            Random r = new Random();
            int x = 0;
            q.Enqueue(25);
            Console.Write(25 + " ");
            for (int i = 0; i < 10; i++)
            {
                x = r.Next(100);
                q.Enqueue(x);
            }
            Console.WriteLine("");
            int count = q.Count;
            Console.WriteLine("Count=" + count);
            for (int i = 0; i < count; i++)
            {
                Console.Write(q.Peek() + " ");
                // Peek reads the first object in the queue 
                // without removing the object
            }
            Console.WriteLine("");
            count = q.Count;
            Console.WriteLine("Count After Peek =" + count);
            Console.WriteLine("Contains 25-" + q.Contains(25));
            for (int i = 0; i < 5; i++)
            {
                Console.Write(q.Dequeue() + " ");
            }
            Console.WriteLine("");
            count = q.Count;
            Console.WriteLine("Count After Dequeue=" + count);
        }
        
            public static void HashtableDemo()
            {
                Hashtable ht = new Hashtable();
                Console.WriteLine("Count " + ht.Count);
                Console.WriteLine("IsFixedSize " + ht.IsFixedSize);
                ht.Add("id", 123);
                ht.Add("name", "Gates");
                Console.WriteLine("Count " + ht.Count);
                ht.Add("sal", 15000);
                ht.Add("r1", new Random().Next());
                ht.Add("IsDirector", false);
                ht.Add("Address", null);
                // ht.Add("name", "Bill");// Runtime Error duplicate key 
                Console.WriteLine("Count " + ht.Count);
                Console.WriteLine(ht["sal"]);
                Console.WriteLine("ContainsKey(r1) " + ht.ContainsKey("r1"));
                Console.WriteLine("ContainsKey(name) " + ht.ContainsKey("name"));



                foreach (object k in ht.Keys)
                    Console.WriteLine(k + "--" + ht[k]);
            }

        public static void EmpDictionaryDemo()
        {
            Dictionary<int, Emp> empMap = new Dictionary<int, Emp>();
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empMap.Add(e.ID, e);
            }
            Emp e1 = new Emp() { ID = 12345, Name = "Venkat", Salary = 1000000 };
            empMap.Add(15, e1);
            empMap.Add(16, e1);



            Console.WriteLine("Count " + empMap.Count);
            Console.WriteLine("ContainsKey(5) " + empMap.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empMap.ContainsKey(15));
        }

        public static void TestSortedListOfEmp(object orderedlist)
        {
            SortedList<int, Emp> empsortlist = new SortedList<int, Emp>();
            Random r1 = new Random();
            Emp e1 = new Emp() { ID = r1.Next(100), Name = "John", Salary = r1.NextDouble() * 5000 };
            Emp e2 = new Emp() { ID = r1.Next(100), Name = "Sam", Salary = r1.NextDouble() * 5000 };
            Emp e3 = new Emp() { ID = r1.Next(100), Name = "Ajith", Salary = r1.NextDouble() * 5000 };
            Emp e4 = new Emp() { ID = r1.Next(100), Name = "Ellango", Salary = r1.NextDouble() * 5000 };
            Emp e5 = new Emp() { ID = r1.Next(100), Name = "Basker", Salary = r1.NextDouble() * 5000 };
            if (!empsortlist.ContainsKey(e1.ID))
                empsortlist.Add(e1.ID, e1);
            if (!empsortlist.ContainsKey(e2.ID))
                empsortlist.Add(e2.ID, e2);
            if (!empsortlist.ContainsKey(e3.ID))
                empsortlist.Add(e3.ID, e3);
            if (!empsortlist.ContainsKey(e4.ID))
                empsortlist.Add(e4.ID, e4);
            if (!empsortlist.ContainsKey(e5.ID))
                empsortlist.Add(e5.ID, e5);



            Console.WriteLine("Count " + empsortlist.Count);
            Console.WriteLine(" Capacity " + empsortlist.Capacity);



            foreach (var emp in empsortlist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
            Console.WriteLine("===================");
             var orderedlist1 = empsortlist.OrderBy(tkey => tkey.Value.Name);
            foreach (var emp in orderedlist1)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
            Console.WriteLine("===================");
            var desclist = empsortlist.OrderByDescending(tkey => tkey.Value.Name);
            foreach (var emp in desclist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
        }
    }
    internal class Emp
    {
        public int ID;
        public string Name;
        public double Salary;
    }
    }
