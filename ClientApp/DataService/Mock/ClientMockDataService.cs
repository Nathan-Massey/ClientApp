using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataService.Interface;

namespace DataService.Mock
{
    public class ClientMockDataService : IClientDataService
    {

        // Field
        private List<Client> _mock;

        // Constructor
        public ClientMockDataService()
        {
            _mock = new List<Client>()
            {
                new Client() {Id = 1, Address= "123 Main Street", Birthday = new DateTime(2000, 03, 24), FirstName= "Nathan", LastName= "Massey"},
                new Client() {Id = 2, Address= "345 2nd Street", Birthday = new DateTime(2002, 05, 06), FirstName= "Collin", LastName= "Massey"},
                new Client() {Id = 3, Address= "678 3rd Street", Birthday = new DateTime(1997, 03, 24), FirstName= "Kawhi", LastName= "Leonard"},
                new Client() {Id = 4, Address= "891 4th Street", Birthday = new DateTime(1995, 03, 24), FirstName= "Andrew", LastName= "Luck"},
                new Client() {Id = 5, Address= "234 5th Street", Birthday = new DateTime(1980, 03, 24), FirstName= "Peyton", LastName= "Manning"},
            };
        }
        public bool CreateClient(Client newClient)
        {
            _mock.Add(newClient);

            return true;
        }

        public bool DeleteClient(int id)
        {
            var clientToBeDeleted = GetSingleClient(id);

            _mock.Remove(clientToBeDeleted);

            return true;
        }

        public List<Client> GetAllClients()
        {
            return _mock;
        }

        public Client GetSingleClient(int id)
        {
            return _mock.Single(client => client.Id == id);
            
        }

        public bool UpdateClient(Client updatedClient)
        {
            var oldClient = GetSingleClient(updatedClient.Id);

            _mock.Remove(oldClient);
            _mock.Add(updatedClient);

            return true;
        }
    }
}
