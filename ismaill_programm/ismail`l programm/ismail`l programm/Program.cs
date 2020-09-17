using System;

namespace ismail_l_programm
{
    class Program
    {
        static int tryparse_1()
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
        static void Main(string[] args)
        {
            bool switcher = false;
            do
            {
                Console.WriteLine("Choose object to create 1-Client 2-Employee press 5 to close programm");
                int selection = tryparse_1();
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Client INFO");
                        Client client = new Client("","",0,0,"");
                        client.Show_Info();
                        switcher = true;
                        break;
                    case 2:
                        Console.WriteLine("Employee INFO");
                        Employee employee = new Employee("","",0,0,"");
                        employee.Show_Info();
                        switcher = true;
                        break;
                    case 5:
                        switcher = true;
                        break;
                    default:
                        Console.WriteLine("Choose correct object");
                        break;
                }
            } while (switcher == false);
            Console.ReadKey();
        }
    }
}
