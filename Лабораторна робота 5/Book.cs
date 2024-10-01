using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;


namespace Лабораторна_робота_5
{
    internal class Book
    {
        private static int _width;
        private static int _length;
        private List<string>[,] _listArray;
        public int Length => _listArray.Length;

        public void SetDimension(int width, int length)
        {
            _width = width;
            _length = length;
            _listArray = new List<string>[_width, _length];

            for(int i = 0; i < _width; i++)
            {
                for(int j = 0; j < _length; j++)
                {
                    _listArray[i, j] = new List<string>();
                }
            }
        }

        public List<string> this[int index1, int index2]
        {
            get => _listArray[index1, index2];
            set => _listArray[index1, index2] = value;
        }

        public void PrintSize()
        {
            Console.WriteLine($"Width of array: {_width}");
            Console.WriteLine($"Length of array: {_length}");
        }
    }
}
