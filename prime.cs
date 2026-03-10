using System;
namespace Prime{
    class IsPrime{
        public static void Main(string[] args){
            int num = Convert.ToInt32(Console.ReadLine());
            if(num<=1){
                Console.WriteLine("Enter a Positive Number");
            }
            else if(num == 2){
                Console.WriteLine("It is prime");
            }
            else{
                bool isPrime = true;
                for(int i=2;i<num/2;i++){
                    if(num%i==0){
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime){
                    Console.WriteLine("Prime Number");
                }
                else{
                    Console.WriteLine("Not a Prime Number");
                }
            }
        }
    }
}
