using System;
namespace Voting{
    class Program {
        static void Main() {
            int age = 12;
            if(age >=18){
                Console.WriteLine("He is Elgible for Voting.");
            }
            else{
                Console.WriteLine("He is minor man,wait until "+(18-age)+" years.");
            }
        }
    }
}
