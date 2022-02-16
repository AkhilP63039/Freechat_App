using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Freechat_App
{
    public class Client
    {
        #region Registration Method
        public void registration()
        {
            string name = Console.ReadLine();
            long ph = long.Parse(Console.ReadLine());
        }
        #endregion

        #region Messaging
        public void SendMessage()
        {
            Console.WriteLine("Type here....");
            string msg = Console.ReadLine();
            Console.WriteLine("Message stored in server");
        }
        #endregion
    }

    public class contact_list
    {

        List<string> chi = new List<string>();
        string a = "Akhil";
        string b = "Akash";
        string c = "Lokesh";
        string d = "Prudhvi";

        #region Removing Participants Methods
        public void list()
        {
            chi.Add(a);
            chi.Add(b);
            chi.Add(c);
            chi.Add(d);
            foreach (string st in chi)
            {
                Console.WriteLine(st);
            }



        }
        public void RemoveParticipant_Akhil()
        {
            chi.Remove(a);
            foreach (string st in chi)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();

        }
        public void RemoveParticipant_Akash()
        {
            chi.Remove(b);

            foreach (string st in chi)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();

        }
        public void RemoveParticipant_Lokesh()
        {
            chi.Remove(c);
            foreach (string st in chi)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();

        }
        public void RemoveParticipant_Prudhvi()
        {
            chi.Remove(d);
            foreach (string st in chi)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();

        }

    }

    public class remove
    {
        public void removing()
        {


            contact_list l = new contact_list();
            l.list();
            Console.WriteLine("Enter a to remove Akhil");
            Console.WriteLine("Enter b to remove Akash");
            Console.WriteLine("Enter c to remove Lokesh");
            Console.WriteLine("Enter d to remove Prudhvi");
            char input = char.Parse(Console.ReadLine());
            string s = input.ToString().ToLower();
            switch (s)
            {
                case "a":
                    l.RemoveParticipant_Akhil();
                    break;
                case "b":
                    l.RemoveParticipant_Akash();
                    break;
                case "c":
                    l.RemoveParticipant_Lokesh();
                    break;
                case "d":
                    l.RemoveParticipant_Prudhvi();
                    break;
            }
            Console.WriteLine("contact List after removing participant");
            l.list();
        }
    }

    #endregion

}










public class Options
{

    #region Options methods
    public void Mute()
    {
        Console.WriteLine("This chat is temporarily muted for 8 hrs..");

        Console.Read();


    }
    public void view()
    {
        Console.WriteLine("I think you are trying to view this msg..Wait a sec and try other options too.");
        Console.Read();

    }
    public void block()
    {
        Console.WriteLine("You will no longer receive msgs from this contact.. ");


    }
    public void deleteChat()
    {
        Console.WriteLine("Are you sure to delete this contact?");
        Console.WriteLine("Type 'yes' to delete");

        string ch = Console.ReadLine();
        if (ch == "yes")
        {
            Console.WriteLine("Deleting Chat");
        }

    }
    #endregion

}

