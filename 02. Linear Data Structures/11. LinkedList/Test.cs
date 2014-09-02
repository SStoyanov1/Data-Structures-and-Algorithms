//Implement the data structure linked list. Define a class ListItem<T> that has two fields:
//value (of type T) and NextItem (of type ListItem<T>). Define additionally a class LinkedList<T>
//with a single field FirstElement (of type ListItem<T>).

namespace _11.LinkedList
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            Console.WriteLine(list);
            list.RemoveFirst();
            list.RemoveFirst();
            Console.WriteLine(list);
        }
    }
}
