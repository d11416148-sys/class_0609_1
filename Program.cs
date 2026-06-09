using Microsoft.VisualBasic;

namespace Exercise_0609_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDel hander;

            hander = new MyDel(MyMath.Add);

            Console.WriteLine(hander(10, 20));

            hander = new MyDel(MyMath.Sub);
            Console.WriteLine(hander(10, 20));

            hander = new MyDel(MyMath.Mul);
            Console.WriteLine(hander(10, 20));

            hander = new MyDel(MyMath.Div);
            Console.WriteLine(hander(10, 20));

            MyDel2 hander2;

            hander2 = new MyDel2(MyMath.Add2);

            hander2 += new MyDel2(MyMath.Sub2);

            hander2 += new MyDel2(MyMath.Mul2);

            hander2 += new MyDel2(MyMath.Div2);

            hander2(10, 20);

            Console.WriteLine(MyMath.str);


            hander2 -= new MyDel2(MyMath.Sub2);

            hander2 -= new MyDel2(MyMath.Div2);

            MyMath.str = "";

            hander2(10, 20);

            Console.WriteLine(MyMath.str);
        }
    }
}