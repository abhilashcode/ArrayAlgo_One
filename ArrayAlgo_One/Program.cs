using System;
using System.Linq;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Generic;
namespace ArrayAlgo_One
{
    class Program
    {
        static void CheckIfSumEqualsTo(int[] _array, int sum)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[0] + _array[i] == sum)
                {
                    Console.WriteLine("Sum is exist");
                }
            }
        }
        static void ReverseArray(int[] _array)
        {
            int[] _reversed_array = new int[_array.Length];
            for (int i = 0; i < _array.Length; i++)
            {
                _reversed_array[i] = _array[_array.Length - 1 - i];
            }
            foreach (var item in _reversed_array)
            {
                Console.Write("{0}", item);
            }
        }
        static void MinMaxArraySwap(int[] _array)
        {
            int maxPos = 0;
            int minPos = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[maxPos] <= _array[i])
                {
                    maxPos = i;
                }
                else if (_array[minPos] >= _array[i])
                {
                    minPos = i;
                }
            }
            Console.WriteLine("Min is {0}, Max is {1}", _array[minPos], _array[maxPos]);
            int temp = _array[minPos];
            _array[minPos] = _array[maxPos];
            _array[maxPos] = temp;
            Console.WriteLine("Swaped Array is :");
            foreach (var item in _array)
            {
                Console.Write("{0} ", item);
            }
        }
        static void DictionaryCheck()
        {
            IDictionary<int, int> _dict = new Dictionary<int, int>();
            _dict.Add(1, 1);
            _dict.Add(2, 2);
            _dict.Add(3, 3);
            foreach (var item in _dict)
            {
                Console.WriteLine("{0}, {1}", item.Key, item.Value);
            }
            var _dict_two = new Dictionary<int, string>();
            _dict_two.Add(1, "Abhi");
            _dict_two.Add(2, "Ramesh");
            bool flag = _dict.ContainsKey(1);
            bool flag2 = _dict_two.ContainsKey(2);
        }
        static void FindMajorityOfElement(int [] _array)
        {
            if(_array.Length <= 2)
            {
                Console.WriteLine("No Majority here");
                return; 
            }
            else
            {
                int majority = _array.Length / 2;
                Dictionary<int, int> _dict = new Dictionary<int, int>();

                foreach (var item in _array)
                {
                    if (_dict.ContainsKey(item))
                    {
                        if(_dict[item] > majority)
                        {
                            Console.WriteLine("{0}", _dict[item]);
                            return;
                        }
                        else
                        {
                            _dict[item]++;
                        }
                    }
                    else
                    {
                        _dict.Add(item, 1);
                    }
                }
                Console.WriteLine("No majority here");
            }
            
        }
        static void MergeSortedArray(int[] _array1, int[] _array2)
        {
            int[] _result = new int[_array1.Length + _array2.Length];
            
        }
        static void InsertElementToArrayAtPosition(int[] _array, int _position, int _element)
        {
            int[] _result = new int[_array.Length + 1];
            int inserted = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                if(_position == i)
                {
                    _result[i] = _element;                
                    inserted = 1;
                    _result[i + inserted] = _array[i];
                }
                else
                {
                    _result[i+ inserted] = _array[i];
                }
            }

            foreach (var item in _result)
            {
                Console.WriteLine("{0} ", item);
            }
        }

        static void CheckPosition()
        {
            int z = 0;
            int c = z;
            int c1 = z;
            int c2 = z;
        }
        
        static void CheckPosition2()
        {
            int x1 = 0;
            int y1 = 0;
        }

        public void Method()
        {
            int fields = 0;
            int field2 = 0;
            int field3 = 0;
            int field4 = 0;
        }
        static void Main(string[] args)
        {
            
            int[] _checkArray1 = { 3, 0, 1, 8, 0, 7, 15,12, 17 };
            DictionaryCheck();
            MinMaxArraySwap(new int[] { 4, 1, 3, 7, 4, 8 });
            InsertElementToArrayAtPosition(new int[] { 1,2,3,4,6,7 }, 1, 5);
            Console.Write("Hi");
            Console.Write("Bye");
        }
    }
}
