using System;
using System.Collections.Generic;
using System.Text;

namespace ismail_l_programm
{
    class Employee : Person
    {
        public int sallary;
        public string position;
        public int Sallary
        {
            get
            {
                return sallary;
            }
            set
            {
                Console.WriteLine("Set employee`s sallary --");
                value = tryparse();
                sallary = value;
            }
        }
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                bool trigger = false;
                do
                {
                    Console.WriteLine("Set client`s current decency press button 1-Financial Analyst 2-Personal Financial Adviser 3-Relationship Manager 4-Accountant 5-Auditor");
                    value = Console.ReadLine();
                    switch (value)
                    {
                        case "1":
                            value = "Financial Analyst";
                            trigger = true;
                            break;
                        case "2":
                            value = "Personal Financial Adviser";
                            trigger = true;
                            break;
                        case "3":
                            value = "Relationship Manager";
                            trigger = true;
                            break;
                        case "4":
                            value = "Accountant";
                            trigger = true;
                            break;
                        case "5":
                            value = "Auditor";
                            trigger = true;
                            break;
                        default:
                            Console.WriteLine("Press right button");
                            break;
                    }
                } while (trigger == false); ;
                position = value;
            }
        }
        public Employee(string name, string sur_name,int age, int sallary,string position)
            : base(name, sur_name, age)
        {
            Sallary = sallary;
            Position = position;
        }
        public override void Show_Info()
        {
            Console.WriteLine($"Age -- {Age}");
            Console.WriteLine($"Name  -- {name}");
            Console.WriteLine($"Second name  -- {sur_name}");
            Console.WriteLine($"Sallary  -- {sallary} AZN");
            Console.WriteLine($"Position  -- {position}");
        }
    }
}
