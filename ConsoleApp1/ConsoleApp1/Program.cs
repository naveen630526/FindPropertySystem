using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSP.UI
{
    class Program
    {
        public static void PropertyMenu()
        {
            Console.WriteLine("\t\t\t\tFind Property System");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("1:Owner");
            Console.WriteLine("2:Customer");
        }
        public static void PropertyMain()
        {
            int choice = 1;
            do
            {
                Console.WriteLine("Please Enter 1 for owner and 2 for customer ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: Owner();
                        break;
                    case 2: //Customer();
                        break;
                    default:
                        Console.WriteLine("You Entered The wrong choice");
                        break;
                }

            } while (choice != -1);
        }
        public static void Owner()
        {
            Console.WriteLine("\t\t\t\tOwner Menu");
            Console.WriteLine("=============================================");
            Console.WriteLine("1: Add Property");
            Console.WriteLine("2: Edit Property");
            Console.WriteLine("3: Delete Property");
            Console.WriteLine("4: Users who have shown interest in your listings");
            int choice;
            Console.WriteLine("\nEnter your Choice");
            choice = int.Parse(Console.ReadLine());
            do
            {
                switch (choice)
                {
                    case 1://Owner.AddProperty();
                        break;
                    case 2://Owner.EditProperty();
                        break;
                    case 3: //Owner.DeleteProperty();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("You Entered a wrong choice");
                        break;

                }

            } while (choice != -1);
        }
        public static void Main()
        {
            PropertyMenu();
            PropertyMain();
        }
    }
   
}