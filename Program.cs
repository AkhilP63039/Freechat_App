using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client();
            Options o = new Options();
            contact_list l = new contact_list();
           // contact_list_server p = new contact_list_server();
            Console.WriteLine("Enter 1 to add");
            Console.WriteLine("Enter 2 to view");
            Console.WriteLine("Enter 3 to edit");
            Console.WriteLine("Enter 4 to delete");
            int op = int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:o.Add();
                    break;
                case 2:o.view();
                    break;
                case 3:o.edit();
                    break;
                case 4:o.delete();
                    break;

            }
            Console.WriteLine("Contact list");
            l.list();
            Console.WriteLine("Enter a to remove Akhil");
            Console.WriteLine("Enter b to remove nikhil");
            Console.WriteLine("Enter c to remove Lokesh");
            Console.WriteLine("Enter d to remove Prudvi");
            char input = char.Parse(Console.ReadLine());
            string s = input.ToString().ToLower();
            switch (s)
            {
                case "a":
                    l.RemoveParticipant_Akhil();
                    break;
                case "b":
                    l.RemoveParticipant_Nikhil();
                    break;
                case "c":
                    l.RemoveParticipant_Lokesh();
                    break;
                case "d":
                    l.RemoveParticipant_Prudvi();
                    break;
            }
            Console.WriteLine("Contact List after removing participant");
            Console.ReadLine();
        }
    }
}
