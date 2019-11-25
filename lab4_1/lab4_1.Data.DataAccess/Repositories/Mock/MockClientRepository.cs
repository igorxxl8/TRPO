using System.Collections.Generic;
using lab4_1.Common.Core.Repositories.Interfaces;
using lab4_1.Common.DomainModel;
using lab4_1.Data.DataAccess.Contexts;
using lab4_1.Data.DataAccess.Repositories;

namespace lab4_1.Data.DataAccess.Mock.Repositories
{
    public class MockClientRepository : RepositoryBase, IClientRepository
    {
        public MockClientRepository(DbContext context) : base(context)
        {
        }

        public ICollection<Client> GetClients()
        {
            return new List<Client>
            {
                new Client {Email = "Test_Email@gmail.com"},
                new Client {Email = "Fakse_Email@gmail.com"}
            };
        }

        public bool RegisterClient(Client client)
        {
            return client != null;
        }

        public bool TryLogin(string email, string password)
        {
            if (password == "password")
            {
                return false;
            }

            return true;
        }
    }
}
