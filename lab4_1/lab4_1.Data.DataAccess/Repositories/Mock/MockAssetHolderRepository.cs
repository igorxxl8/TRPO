using lab4_1.Common.Core.Repositories.Interfaces;
using lab4_1.Data.DataAccess.Contexts;
using lab4_1.Data.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1.Data.DataAccess.Mock.Repositories
{
    public class MockAssetHolderRepository : RepositoryBase, IAssetHolderRepository
    {
        public MockAssetHolderRepository(DbContext context) : base(context)
        {
        }
    }
}
