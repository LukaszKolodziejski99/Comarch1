using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchCwiczenia;

public class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Substraction(int x, in int y) 
    { 
        return x - y; 
    }

    public int Multiply(int x, in int y)
    {
        return x * y;
    }

    public float Divide (int x, int y)
    {
        if (y == 0) throw new ArgumentException("Dzielenie przez zero!", nameof(y));
        return x / (float)y;
    }

    public int Modulo(int x, int y)
    {
        return x % y;
    }
}
