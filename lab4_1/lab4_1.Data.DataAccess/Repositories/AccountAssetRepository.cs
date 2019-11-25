using lab4_1.Common.Core.Repositories.Interfaces;
using lab4_1.Data.DataAccess.Contexts;

namespace lab4_1.Data.DataAccess.Repositories
{
    public class AccountAssetRepository : RepositoryBase, IAccountAssetRepository
    {
        public AccountAssetRepository(DbContext context) : base(context)
        {
        }
    }
}
