using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    public class Client
    {
        public Client()
        {
        }
        public string Name { get; set; }
        public long Phone { get; set; }
    }
    public class contact_list
    {
        List<string> contacts = new List<string>();
        string a = "Akhil";
        string b = "Nikhil";
        string c = "Lokesh";
        string d = "Prudvi";
        public void list()
        {
            contacts.Add(a);
            contacts.Add(b);
            contacts.Add(c);
            contacts.Add(d);
            foreach(string st in contacts)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();
        }
        public void RemoveParticipant_Akhil()
        {
            contacts.Remove(a);
            foreach(string st in contacts)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();
        }
        public void RemoveParticipant_Nikhil()
        {
            contacts.Remove(a);
            foreach (string st in contacts)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();
        }
        public void RemoveParticipant_Lokesh()
        {
            contacts.Remove(a);
            foreach (string st in contacts)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();
        }
        public void RemoveParticipant_Prudvi()
        {
            contacts.Remove(a);
            foreach (string st in contacts)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();
        }

        public void group()
        {
            contacts.Remove(a);
        }
    }
}
public class Options
{
    List<string> con = new List<string>();
    public void Add()
    {
        Console.WriteLine("Create new contact or Add to existing contacts?");

        string n1 = Console.ReadLine();
        con.Add(n1);
        Console.WriteLine(con);
        Console.Read();
    }
    public void view()
    {
        Console.WriteLine("Hi.. Namaste.. Hello.. Gudmrng ..Heyy Wassupp...........");
        Console.Read();
    }
    public void edit()
    {
    }
    public void delete()
    {
    }
}
