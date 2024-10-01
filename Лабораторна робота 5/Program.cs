using System;
using Лабораторна_робота_5;

Book book = new Book();
book.SetDimension(5, 5);
book[0, 0].Add("HelloBook");
book[0, 1].Add("SecondBook");

for(int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        for(int k = 0; k < book[i, j].Count; k++)
        {
        Console.WriteLine($"{book[i, j][k]}"); 
        }
    }
}
