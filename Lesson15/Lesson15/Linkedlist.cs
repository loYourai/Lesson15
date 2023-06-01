using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LinkedList<T>
    {
        private Item head;

        // add, get(index), clear, insert
        // lenght/count

        public LinkedList()
        {
            Length = 0;
        }

        public int Length { get; private set; }

        public void Insert(T element, int index)
        {
            if (index < 1 && index > Length)
            {
                throw new ArgumentException("Such index doesn't exist");
            }

            if (head == null)
            {
                throw new ArgumentException("Such index doesn't exist");
            }

            var currentItem = head;
            int i = 1;
            while (i++ < index - 1 && currentItem != null)
            {
                currentItem = currentItem.Next;
            }

            if (currentItem == null) // when 5 items and requested 10
            {
                throw new ArgumentException("Such index doesn't exist");
            }

            var newItem = new Item
            {
                Value = element,
                Next = null
            };

            if (index == 1)
            {
                newItem.Next = head;
                head = newItem;
            }
            else
            {
                var nextItem = currentItem.Next;
                currentItem.Next = newItem;
                newItem.Next = nextItem;
            }

            Length++;
        }

        public int Count()
        {
            if (head == null)
            {
                return 0;
            }

            var currentItem = head;
            int i = 0;
            while (currentItem != null)
            {
                i++;
                currentItem = currentItem.Next;
            }

            return i;
        }

        public void Add(T element)
        {
            if (head == null) // count of elements = 0
            {
                head = new Item
                {
                    Value = element,
                    Next = null
                };
            }
            else
            {
                var nextElement = head.Next;
                var currentElement = head;
                while (nextElement != null)
                {
                    currentElement = nextElement;
                    nextElement = nextElement.Next;
                }

                var newItem = new Item
                {
                    Value = element,
                    Next = null
                };

                currentElement.Next = newItem;
            }

            Length++;
        }

        public T Get(int index)
        {
            if (index < 1)
            {
                throw new InvalidOperationException();
            }

            if (head == null)
            {
                throw new ArgumentException("Such index doesn't exist");
            }

            var currentItem = head;
            int i = 1;
            while (i++ < index && currentItem != null)
            {
                currentItem = currentItem.Next;
            }

            if (currentItem == null) // when 5 items and requested 10
            {
                throw new ArgumentException("Such index doesn't exist");
            }

            return currentItem.Value;
        }

        public void Clear()
        {
            head = null;
            Length = 0;
        }

        private class Item
        {
            public T Value { get; set; }

            public Item Next { get; set; }
        }
    }
}