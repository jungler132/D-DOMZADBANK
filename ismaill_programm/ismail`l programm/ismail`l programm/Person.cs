using System;
using System.Collections.Generic;
using System.Text;

namespace ismail_l_programm
{
    public abstract class Person
    {
        public string name;
        public string sur_name;
        public int age;
        public Person(string name, string sur_name, int age)
        {
            Name = name;
            Sur_name = sur_name;
            Age = age;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                Console.WriteLine("Set name --");
                value = valid_check();
                name = value;
            }
        }
        public string Sur_name
        {
            get
            {
                return sur_name;
            }
            set
            {
                Console.WriteLine("Set Second name --");
                value = valid_check();
                sur_name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                Console.WriteLine("Set age --");
                bool trigger = false;
                do
                {
                    value = tryparse();
                    if (value > 17 && value < 81)
                    {
                        age = value;
                        trigger = true;
                    }
                    else
                    {
                        Console.WriteLine("try again");
                        trigger = false;
                    }
                } while (trigger == false);
            }
        }
        public static int tryparse()
            {
                int num1;
                bool triger = false;
                do
                {
                    
                    if (int.TryParse(Console.ReadLine(), out num1) && num1 > 0)
                    {
                        triger = true;
                    }
                    else
                    {
                        Console.WriteLine("wrong number try again");
                        continue;
                    }
                }
                while (triger == false);
                return num1;
            }
        public static string valid_check()
        {
            bool check = true;
            string name;
            do
            {
                name = Console.ReadLine();
                foreach (char a in name)
                {
                    if (a >= '0' && a <= '9')
                    {
                        Console.WriteLine("Try again");
                        check = false;
                        break;
                    }
                    else
                    {
                        check =  true;
                    }
                }
            } while (check == false);
            return name;
        }  
        public abstract void Show_Info();
    }
}
