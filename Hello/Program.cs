using System;

namespace Hello
{
    public class Program
    {
        static void Main(string[] args)
        {
            string valsting;
            int value;
            var hello = new Program();
            Console.Write("Enter Year: ");
            valsting = Console.ReadLine();
            value = int.Parse(valsting);
            
                        if(hello.IsLeapYear(value)){
                            Console.Write("yay " + value + " Is a Leap Year");

                        }else{
                            Console.Write("nay " + value + " Is not a Leap Year");

                        }
        }

        public bool IsLeapYear(int year){
            if ((year % 4) == 0){
                return true;
            }else{
                return false;
            }
            
        }
    }
}
