using C_Pattern;
using System;
using System.ComponentModel;
/*
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
ArrayCode.program();
ArrayCode.displayArray();*/
//ArrayCode.reverseOrder();
int [] arr = { 6, 5,4,3,2,1,8,10,12,56,96};
string str = "hello world";
int num = 987654321;
//ArrayCode.reverseArray2(arr);
//ArrayCode.average(arr);
//ArrayCode.maxValue(arr);
//ArrayCode.minValue(arr);
//ArrayCode.ArrayAsInputValue();
//ArrayCode.evenOddCount(arr);
//ArrayCode.ArrayAscOrDSC(arr);
//ArrayCode.SearchEle(arr);
//ArrayCode.secondLargest(arr);
//ArrayCode.secondSmallestNum(arr);
//ArrayCode.remDuplicate(arr);
//ArrayCode.rotateArr(arr, 4);
//stringCodes.revString();
//stringCodes.countChar();
//stringCodes.removeDuplicateChar(str);
//stringCodes.WordCount();
//stringCodes.numCount();
//stringCodes.numDate();
//LambdaExpressionCode.LambdaExp();
//LambdaExpressionCode.sumOfAllIntger();
//C_InterviewProgram.primeOrNot(8);
//C_InterviewProgram.revString(str);
//C_InterviewProgram.revNum(num);
//C_InterviewProgram.StringLength(str);
//C_InterviewProgram.Fibonnaci(8);
//Console.WriteLine(C_InterviewProgram.Factorial(5));
//C_InterviewProgram.swapNum();
//C_InterviewProgram.sumOfNum();
//C_InterviewProgram.evenOdd(num);
//C_InterviewProgram.palindrome(str);
//Console.WriteLine(C_InterviewProgram.SwapCase(str));
//Class1 obj = new Class1();
//obj.Run(); // calls delegate , prints message
/*
C_InterviewProgram.add();
C_InterviewProgram.EvenOdd();
Encapsulation d = new Encapsulation();

	d.set(102,"Jyoti");
Console.WriteLine(d.get());
Class3 obj = new Class3();
obj.Duplicate();
ArrayListProgram Arr = new ArrayListProgram();
Arr.SortingArr();*/
//Class4.countSpecialCharDigit();
//Class5.countCharSpDigit();
//reverseEachWordOfString.revWord();
//Class6.CapAndSmall();
//Class7.CapstoSmall();
/*Class8 c = new Class8(9, 8);
Console.WriteLine(c.add());
Console.WriteLine(c.sub());
Console.WriteLine(c.mul());
Console.WriteLine(c.div());*/
//Class9 n = new Class9(9);
//checkPalindrome palindrome = new checkPalindrome(121);
//Class10 c = new Class10(123698547);
//Class11 class11 = new Class11(153);
//Class12 c = new Class12(23, 45);
//Class13 c = new Class13(5);
//Class14 c = new Class14(96);
//Class15 c = new Class15(100);
//Class16 c = new Class16("gaikwad");
//Class16 c1 = new Class16("madam");
/*int[] ans = Class17.asc(arr);
foreach(int a in ans)
 Console.WriteLine(a);
int[] ans1 = Class17.dsc(arr);
Console.WriteLine(string.Join(" ,", ans1));*/
Console.WriteLine(Class18.maxNum(arr));
Console.WriteLine(Class18.minNum(arr));
Console.WriteLine(Class18.thirdMinNum(arr));


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

