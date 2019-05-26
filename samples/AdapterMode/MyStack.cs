using System;
using System.Collections.Generic;

namespace AdapterMode
{
    public class MyStack<T> : IStack<T>
    {
        private readonly List<T> _list = new List<T>();

        public void Push(T item)
        {
            _list.Add(item);
        }

        public T Pop()
        {
            var item = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return item;
        }

        public void PrintAll()
        {
            Console.WriteLine("Begin Print Stack Item");
            foreach (var item in _list)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("End Print Stack Item");
        }
    }
}