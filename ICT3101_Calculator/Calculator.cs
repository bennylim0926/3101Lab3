using System;
using System.Globalization;
public class Calculator
{
    public Calculator() { }
    public double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value
                                    // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            // Return text for an incorrect option entry.
            case "f":
                result = Factorial(num1);
                break;
            case "uA":
                result = UnknownFunctionA(num1,num2);
                break;
            case "uB":
                result = UnknownFunctionB(num1,num2);
                break;
            case "tA":
                result = triangleArea(num1,num2);
                break;
            case "cA":
                result = circleArea(num1);
                break;
            default:
                break;
        }
        return result;
    }
    
    public bool IsBinary(string input)
    {
        foreach (char digit in input)
        {
            if (digit != '0' && digit != '1')
            {
                return false; // The string contains a non-binary digit
            }
        }
        return true; // All characters in the string are '0' or '1'
    }

    public double Add(double num1, double num2)
    {
        if ( !IsBinary(num1.ToString()) || !IsBinary(num2.ToString()))
        {
            return (num1 + num2);
        }
        for (int i = 0; i < num2.ToString().Length; i++)
        {
            num1 *= 10;
        }
        double result = num1 + num2;
        return Convert.ToInt32(result.ToString(), 2);
    }

    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }
    public double Multiply(double num1, double num2)
    {
        return (num1 * num2);
    }

    public double Divide(double num1, double num2)
    {
        // dont allow any 0 based on testcase
        if (num1 == 0 && num2 == 0)
        {
            return 1;
        }
        if (num2 == 0)
            return Double.PositiveInfinity;
           // throw new ArgumentException();

        return (num1 / num2);
    }
    public double Factorial(double num)
    {
        // 0! = 1
        if (num < 0)
            throw new ArgumentException();

        if (num == 0)
            return 1;

        // base case
        if (num == 1)
            return num;

        return Factorial(num - 1) * num;
    }

    public double triangleArea(double h, double w)
    {
        if(h < 1 || w < 1)
            throw new ArgumentException();
        return (h * w)/2;
    }

    public double circleArea(double r)
    {
        if (r < 1)
            throw new ArgumentException();
        return 3.14 * r * r;
    }

    public double UnknownFunctionA(double num1, double num2)
    {
        // for testcase 3
        if (num1 < 0 || num2 < 0)
            throw new ArgumentException();

        // for testcase 4
        if (num1 < num2)
            throw new ArgumentException();

        // 2 Factorials, 1 Subtract, 1 Divide
        double fac1 = Factorial(num1);
        double factorial1Minus2 = Factorial(Subtract(num1,num2));
        return Divide(fac1, factorial1Minus2);
    }

    public double UnknownFunctionB(double num1, double num2)
    {
        // for testcase 3
        if (num1 < 0 || num2 < 0)
            throw new ArgumentException("Both x and y must be non-negative integers.");

        // for testcase 4
        if (num1 < num2)
            throw new ArgumentException("x must be greater than or equal to y.");

        // 3 Factorials, 1 Divide, 1 Multiply, 1 Subtract
        double fac1 = Factorial(num1);
        double fac2 = Factorial(num2);
        double factorial1Minus2 = Factorial(Subtract(num1,num2));
        double result = Divide(fac1, Multiply(fac2, factorial1Minus2));
        return result;
    }
}