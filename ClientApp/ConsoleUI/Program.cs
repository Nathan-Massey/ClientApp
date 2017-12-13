using ServiceLayer.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static ClientService cs = new ClientService();
        static void Main(string[] args)
        {
            bool keepAsking = true;

            do
            {
                string input = Console.ReadLine();

                switch(input)
                {
                    case "client --all":
                         GetAllClient();
                         break;

                    case "client --single":
                         GetSingleClient();
                         break;

                    case "client --create":
                         CreateClient();
                         break;

                    case "client --delete":
                         DeleteClient();
                         break;

                    // HW - Create the update client
                    case "client --update":
                         UpdateClient();
                         break;

                    case "exit":
                         keepAsking = false;
                         break;

                }
            } while (keepAsking);


        }

        private static void UpdateClient()
        {
            Console.WriteLine("Enter client id");

            int inputId = int.Parse(Console.ReadLine());

            var updateClient = new DataService.Client();

            Console.WriteLine("Enter client's first name:");

            updateClient.FirstName = Console.ReadLine();

            Console.WriteLine("Enter client's last name:");

            updateClient.LastName = Console.ReadLine();

            Console.WriteLine("Enter client's birthday: (mm/dd/yyyy)");

            updateClient.Birthday = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter client's address:");

            updateClient.Address = Console.ReadLine();

            if (cs.UpdateClient(inputId))
            {
                Console.WriteLine("Client was updated");
            }
            else
            {
                Console.WriteLine("Client could not be updated");
            }
        }

        private static void DeleteClient()
        {
            Console.WriteLine("Enter client id");

            int inputId = int.Parse(Console.ReadLine());

            if(cs.DeleteClient(inputId))
            {
                Console.WriteLine("Client was deleted");
            }
            else
            {
                Console.WriteLine("Wrong user id");
            }

      
        }

        private static void CreateClient()
        {
            var newClient = new DataService.Client();

            Console.WriteLine("Enter client's first name:");

            newClient.FirstName = Console.ReadLine();

            Console.WriteLine("Enter client's last name:");

            newClient.LastName = Console.ReadLine();

            Console.WriteLine("Enter client's birthday: (mm/dd/yyyy)");

            newClient.Birthday = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter client's address:");

            newClient.Address = Console.ReadLine();

            if(cs.CreateClient(newClient))
            {
                Console.WriteLine("Client added to database");
            }

            else
            {
                Console.WriteLine("Client was no saved");
            }

        }

        private static void GetSingleClient()
        {
            Console.WriteLine("Enter client id");

            int inputId = int.Parse(Console.ReadLine());

            try
            {
                var singleClient = cs.GetSingleClient(inputId);

                Console.WriteLine($"{singleClient.FirstName} {singleClient.LastName} {singleClient.Birthday}");
            }
            catch
            {
                Console.WriteLine("Not a matching Id");
            }
            
        }

        private static void GetAllClient()
        {
            var clients = cs.GetAllClient();

            foreach(var c in clients)
            {
                Console.WriteLine($"{c.Id} - {c.FirstName} {c.LastName} {c.Birthday}");
            }
        }
    }
}
