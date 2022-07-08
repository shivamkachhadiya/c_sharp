using System;

namespace shivam
{
   
     class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("WELCOME TO BANK....");
            Console.WriteLine("\n 1-> deposit cash\n 2->withdrow cash \n 3->exit");
            Console.WriteLine("enter your choise->");
            int ch=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your choise is->" + ch);
            switch(ch)
            {
                
                case 1:
                    
                        Console.WriteLine("deposit cash->");
                        Console.WriteLine("enter name");
                        string a = (Console.ReadLine());
                        Console.WriteLine("your name is" + a);

                        Console.WriteLine("enter a/c no->");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("your a/c no is" + b);

                    
                        Console.WriteLine("enter amount to deposit->");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("your balance is" + c);
                        
                            Console.WriteLine("your final balance is->" +);
                        
                        
                    

                   


                        




                    break;
                case 2:
                    Console.WriteLine("withdrow cash->");
                    break;
                case 3:
                    Console.WriteLine("exit()");
                    break;



            }

        }
    }
}
