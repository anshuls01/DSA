using System;

namespace Recursion.SimpleRecursion;

public class ProductNTo1
{

    public static int solve(int n)
    {
        if(n==1){return 1;}
        int prod = n*solve(n-1);
        
        return prod;

    }

}
