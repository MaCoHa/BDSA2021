using System;

namespace Hello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string valsting;
            int value;
            var hello = new Program();
            Console.Write("Enter Year: ");
            valsting = Console.ReadLine();
            try{
            value = int.Parse(valsting);
            
            
                        if(hello.IsLeapYear(value)){
                            Console.Write("yay " + value + " Is a Leap Year");

                        }else if (value>1581) {

                            Console.Write("Year " + value + " Is less than 1582");
                        }else{
                            
                            Console.Write("nay " + value + " Is not a Leap Year");

                        }
                        }catch(Exception ){
                             Console.Write("not a year");
                                                     
                
            }
        }

        public bool IsLeapYear(int year){
            if(year<1581){
                return false;
            }else if ((year % 4) == 0){
                return true;
            }else{
                return false;
            }
            
        }
    }
}
