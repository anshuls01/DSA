using System;
using System.Net;

namespace Recursion.SimpleRecursion;

//Reverse a number wihtout converting to string
public class ReverseNumber
{

    public static int sum = 0;
    public static void solve(int number)
    {
        //startegy first seprate the number digit by digit and then combine -> divide and coinquer
        if(number%10==0)
        {
            return;
        }
        
        int reminder = number%10;
        sum = sum*10 + reminder;
        solve(number/10);
        //Console.WriteLine(num);
        //Console.WriteLine(num);
        //return number;  
    }
}
