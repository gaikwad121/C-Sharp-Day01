using System;
namespace project;
class Pattern
{
    static void Main()
    {
        pattern(4);
        squarePattern(4);
        alphabetpattern(4);
    }
    /* /3.
     * /*
  * A B C D
  * A B C D
  * A B C D
  * A B C D
  * 
  */
    static void alphabetpattern(int n)
    {
        
        for(int i = 1; i <= n; i++)
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
    static void squarePattern(int n)
    {
        for(int i = 1; i <= n; i++)
        {
        for(int j = 1; j <= n; j++)
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
    static void pattern(int n)
    {
        for(int i = 1; i <= n; i++)
        {
        for(int j = 1; j <= n; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();

    }
}

