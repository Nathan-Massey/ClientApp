using System.Collections.Generic;

namespace DataService.Interface
{
    interface IClientDataService
    {
        // Single Client
        Client GetSingleClient(int id);

        // All clients
        List<Client> GetAllClients();

        // Create
        bool CreateClient(Client newClient);

        // Update
        bool UpdateClient(Client updatedClient);

        // Delete
        bool DeleteClient(int id);
    }
}
