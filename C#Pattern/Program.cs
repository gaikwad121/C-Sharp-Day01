﻿using System;
using System.ComponentModel;
pattern2(4);
squarePattern(4);
alphabetpattern(4);
NoPattern(3);
starPattern(4);
pattern(4);
noPattern(4);
floyds(4);
pattern1(4);
pattern5(4);
HellowMultiply();
static void HellowMultiply()
{
    int num = 5;
for(int i = 0; i <= num; i++)
    {
        for (int j = 1; j <= num; j++)
        {
            if (i == j || i+j == num + 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");

            }
        }
            Console.WriteLine();
        }
    }


/*     1
    1 2 1
  1 2 3 2 1
1 2 3 4 3 2 1*/
static void pattern5(int n)
{
    for(int i = 1; i <= n; i++)
    {
    for(int j  = 1; j <= n - i; j++)
        {
            Console.Write(" ");
        }
for(int j = 1; j <= i; j++)
        {
            Console.Write(j);
        }
for(int j = i - 1; j >= 1; j--)
        {
            Console.Write(j);
          
        }
        Console.WriteLine();
    }
}
/*1 1 1 1
    2 2 2
       3 3
         4
*/
static void pattern1(int n)
{
for(int i = 0; i <n; i++)
    {
for(int j = 0; j <i; j++)
        {
            Console.Write(" ");
        }
for(int j = 0; j <n - i; j++)
        {
            Console.Write(i+1);
        }
        Console.WriteLine();
    }
}
/*Floyd's Triangle pattern
1
2 3
4 5 6
7 8 9 10 */
static void floyds(int n)
{
    int count = 1;
for(int i = 1; i <= n; i++)
    {
for(int j = 1; j <= i; j++)
        {
            Console.Write(count+" ");
            count++;
        }
        Console.WriteLine();
    }

}
/*
1
1 2
1 2 3
1 2 3 4*/
static void noPattern(int n)
{
    for(int i = 1; i <= n; i++)
    {
    for(int j = 1; j <= i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
}
/*
1
2 2
3 3 3
4 4 4 4*/
static void pattern(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

}
/*
*
**
***
****
*/
void starPattern(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
/*
1 2 3
4 5 6
7 8 9*/
void NoPattern(int n)
{
    int count = 1;
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            Console.Write(count + " ");
            count++;
        }


        Console.WriteLine();
    }
}

/*
* A B C D
* A B C D
* A B C D
* A B C D
* 
*/
void alphabetpattern(int n)
{

    for (int i = 1; i <= n; i++)
    {
        char ch = 'A';
        for (int j = 1; j <= n; j++)
        {
            Console.Write((char)ch);
            ch++;
        }
        Console.WriteLine();
    }
}
/*/2.
****
****
****
****
*/
void squarePattern(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    Console.ReadLine();
}

/*
 * 
1 2 3 4
1 2 3 4
1 2 3 4
1 2 3 4*/
void pattern2(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
    Console.ReadLine();

}

