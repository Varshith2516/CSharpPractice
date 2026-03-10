using System;
namespace BasicCalci{
    class Calci{
        static void add(int a,int b){
            Console.WriteLine("The Addition of numbers is :"+(a+b));
        }
        static void subtract(int a,int b){
            Console.WriteLine("The Subtraction of numbers is :"+(a-b));
        }
        static void multiply(int a,int b){
            Console.WriteLine("The Multiplication of numbers is : "+(a*b));
        }
        static void divide(int a,int b){
            Console.WriteLine("The Division of numbers is: "+(a/b));
        }
        static void Main(string[] args){
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            add(x,y);
            subtract(x,y);
            multiply(x,y);
            divide(x,y);
        }
    }
}
