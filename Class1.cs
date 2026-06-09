using System;

delegate int MyDel(int a, int b);

delegate void MyDel2(int a, int b);


public class MyMath
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Sub(int a, int b)
    {
        return a - b;
    }

    public static int Mul(int a, int b)
    {
        return a * b;
    }

    public static int Div(int a, int b)
    {
        return a / b;
    }


    public static string str;

    public static void Add2(int a, int b)
    {
        str += "\n" + (a + b).ToString();
    }

    public static void Sub2(int a, int b)
    {
        str += "\n" + (a - b).ToString();
    }

    public static void Mul2(int a, int b)
    {
        str += "\n" + (a * b).ToString();
    }

    public static void Div2(int a, int b)
    {
        str += "\n" + (a / b).ToString();
    }
}