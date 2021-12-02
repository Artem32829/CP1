using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[5] { 1, 2, -3, 4, -5 };
            //int result = SortArray(arr);
            //Console.WriteLine(SortArray(arr));
            //TablePerson();


            //List<Person> people = new List<Person>();            
            //WorkWithHTadle(TablePerson(AddPerson(people, 0)));  


            //Queue<Person> numbers = new Queue<Person>();
            //SearchQue(numbers, "asd");

            //Hashtable hashtable = new Hashtable();
            //List(hashtable);
        }
        public static int BinarySearch(int[] arr, int value)
        {
            int lest = 0;
            int right = arr.Length - 1;
            int mid;
            while(lest<=right)
            {
                mid = ((right - lest) / 2) + lest;
                if(value == arr[mid])
                {
                    return mid;
                }
                else if(value < arr[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    lest = mid + 1;
                }
            }
            return -1;
        }
        public static int SortArray(int[]arr)
        {
            for(int i = 0; i < arr.Length - 1; ++i)
            {
                int max = arr.Length;
                int index_max = 0;
                for(int j = 0; j < arr.Length - i; ++j)
                {
                    if(arr[j] > max)
                    {
                        max = arr[j];
                        index_max = j;
                    }
                }
                int temp = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = max;
                arr[index_max] = temp;
                Console.WriteLine(arr[index_max]);
            }            
            return 0;          
            
        }
        public static List<Person> AddPerson(List<Person> people, int a)
        {
            
            while (a!=2)
            {
                string name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());
                people.Add(new Person() { Name = name, Age = age }) ;
                return AddPerson(people, a + 1);                                     
            }           
            
            return people;            
        }
        public static Hashtable TablePerson(List<Person> people)
        {
            Console.WriteLine("Таблица Person");
            int a = 0;
            Hashtable hashtable = new Hashtable();
            foreach (Person person in people)
            {
                ++a;
                Console.WriteLine("{0}: Имя = {1}, Возраст = {2}", a, person.Name, person.Age);
                hashtable.Add(person.Name, person.Age);                
            }
            return hashtable;            
        }

        public static void WorkWithHTadle(Hashtable hashtable)
        {
            int a = 0;
            Console.WriteLine("Remove Key");
            string RemoveKey = Console.ReadLine();
            if(hashtable.ContainsKey(RemoveKey))
            {
                var SaveValue = hashtable[RemoveKey];                
                hashtable.Remove(RemoveKey);
                Console.WriteLine("New Key");
                string newName = Console.ReadLine();
                hashtable.Add(newName, SaveValue);
            }
            else
            {
                Console.WriteLine("Not found");
            }
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine("{0}: Имя = {1}, Возраст = {2}", ++a, de.Key, de.Value);
            }
        }       
        public static bool SearchQue(Queue<Person> numbers, string a)      
        {
            Queue<Person> numbers2 = new Queue<Person>();
            numbers.Enqueue(new Person() {Name = "asf", Age = 21 });
            numbers.Enqueue(new Person() { Name = "asff", Age = 21 });
            numbers.Enqueue(new Person() { Name = "asd", Age = 21 });
            numbers.Enqueue(new Person() { Name = "asv", Age = 21 });
            Person person = new Person();
                while(numbers.Count != 0)
                {
                    person = numbers.Dequeue();
                    if(person.Name == a)
                    {
                        Console.WriteLine(person.Name);
                        return true;
                    }
                    else
                    {                        
                        Console.WriteLine("-");     
                    
                    }
                
            }            
          
            return false;
            
        }
        //public static HashSet<string> AddItem(HashSet<string> vs, int count = 0)
        //{
        //    Console.WriteLine("Items:");
        //    while(count!=2)
        //    {
        //        string item = Console.ReadLine();
        //        vs.Add(item);
        //        return AddItem(vs);
        //    }
        //    return vs;
            
        //}
        //public static void List()
        //{           
        //    HashSet<>            
        //}
        public void Search(int[] list, int serach_poit, int start_poit)
        {
            
        }
    }
}
