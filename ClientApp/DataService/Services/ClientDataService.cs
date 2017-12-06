using DataService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services
{
    class ClientDataService : IClientDataService
    {
        // Field
        private DatabaseToClassesDataContext _db;

        // Constructor
        public ClientDataService()
        {
            _db = new DatabaseToClassesDataContext();
        }

        //Methods
        public List<Client> GetAllClients()
        {
            var allClients = _db.Clients;

            return allClients.ToList();
        }

        public Client GetSingleClient(int id)
        {
            var client = _db.Clients
                         .Where(row => row.Id == id)
                         .Single();

            return client;
        }
    }
}
