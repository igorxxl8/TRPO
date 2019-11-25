using lab4_1.Common.Core.Repositories.Interfaces;
using lab4_1.Data.DataAccess.Contexts;
using lab4_1.Data.DataAccess.Repositories;

namespace lab4_1.Data.DataAccess.Mock.Repositories
{
    public class MockAccountAssetRepository : RepositoryBase, IAccountAssetRepository
    {
        public MockAccountAssetRepository(DbContext context) : base(context)
        {
        }
    }
}
