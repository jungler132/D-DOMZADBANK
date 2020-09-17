using System;
using System.Collections.Generic;
using System.Text;

namespace ismail_l_programm
{
    public class Client : Person
    {
        public int cash;
        public string decency;
        public int Cash
        {
            get
            {
                return cash;
            }
            set
            { 
                Console.WriteLine("Set client`s current cash -- ");
                value = tryparse();
                cash = value;
            }
        }
        public string Decency
        {
            get
            {
                return decency;
            }
            set
            {
                bool trigger = false;
                do
                {
                    Console.WriteLine("Set client`s current decency press button 1-Respectfull 2-Good 3-Normal 4-Bad 5-Awfull");
                    value = Console.ReadLine();
                    switch (value)
                    {
                        case "1":
                            value = "Respectfull";
                            trigger = true;
                            break;
                        case "2":
                            value = "Good";
                            trigger = true;
                            break;
                        case "3":
                            value = "Normal";
                            trigger = true;
                            break;
                        case "4":
                            value = "Bad";
                            trigger = true;
                            break;
                        case "5":
                            value = "Awfull";
                            trigger = true;
                            break;
                        default:
                            Console.WriteLine("Press right button");
                            break;
                    }
                } while (trigger == false); ;
                    decency = value;
            }   
        }
        public Client(string name, string sur_name, int age, int cash, string decency)
            : base(name, sur_name, age)
        {
            Cash = cash;
            Decency = decency;
        }
        public override void Show_Info()
        {
            Console.WriteLine($"Age -- {Age}");
            Console.WriteLine($"Name  -- {name}");
            Console.WriteLine($"Second name  -- {sur_name}");
            Console.WriteLine($"Current cash  -- {cash} AZN");
            Console.WriteLine($"Current decency  -- {decency}");
        }
    }
}
            
    
    

        
    

