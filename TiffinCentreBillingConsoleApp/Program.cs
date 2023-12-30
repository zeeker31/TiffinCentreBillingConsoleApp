using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace TiffinCentreBillingConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double idlyPrice = 30.0;
            double dosaPrice = 50.0;
            double vadaPrice = 20.0;
            double sgtRate = 0.05; // Sales tax rate (5%)
            double cgtRate = 0.1;  // Central GST rate (10%)
            Console.WriteLine("What is your order?(type 'bye' to exit");
            Console.WriteLine("");
            Console.WriteLine("Tiffin Center Menu:");
            Console.WriteLine("1. Idly - Rs" + idlyPrice);
            Console.WriteLine("2. Dosa - Rs" + dosaPrice);
            Console.WriteLine("3. Vada - Rs" + vadaPrice);
            Console.WriteLine("---------------------------");
            
            Console.Write("Enter your choice (1/2/3): ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter the quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Shop name: Hyderabad Tiffin Centre");
            

            double itemPrice = 0.0;

            switch (choice)
            {
                case 1:
                    itemPrice = idlyPrice;
                    break;
                case 2:
                    itemPrice = dosaPrice;
                    break;
                case 3:
                    itemPrice = vadaPrice;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            double subtotal = itemPrice * quantity;
            double sgt = subtotal * sgtRate;
            double cgt = subtotal * cgtRate;
            double grandTotal = subtotal + sgt + cgt;
            Console.WriteLine("GST no: GESD876YHG76");
            Console.WriteLine("Phone No: 9876543210");
            Console.WriteLine("Address");
            Console.WriteLine("\nTiffin Center Bill");
            Console.WriteLine("Item: " + GetItemName(choice));
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Subtotal: Rs" + subtotal);
            Console.WriteLine("Sales Tax (SGT): Rs" + sgt);
            Console.WriteLine("Central GST (CGT): Rs" + cgt);
            Console.WriteLine("Grand Total: Rs" + grandTotal);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        static string GetItemName(int choice)
        {
            switch (choice)
            {
                case 1:
                    return "Idly";
                case 2:
                    return "Dosa";
                case 3:
                    return "Vada";
                default:
                    return "Unknown Item";
            }
        }
    }
    





        }


