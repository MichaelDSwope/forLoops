using System;


namespace forLoops
{

    class Program
    {

        static void ProcessRequest()
        {
            int num, sum = 0;
            Console.WriteLine(" >> Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
            Console.WriteLine(">>" + sum);
        }

        static void Main(string[] args)
        {

            bool theyWantToContinue = true;
            
            while (theyWantToContinue)
            {
                ProcessRequest();

                Console.WriteLine("Would you like to continue?. y / n");
                if(Console.ReadLine().Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    theyWantToContinue = false;
                    Console.WriteLine("Good Bye!");
                }
            }
        }
    }   
}

     
            
           
           

    
    

        
       
    