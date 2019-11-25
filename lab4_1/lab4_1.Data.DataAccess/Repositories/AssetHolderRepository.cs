using lab4_1.Common.Core.Repositories.Interfaces;
using lab4_1.Data.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1.Data.DataAccess.Repositories
{
    public class AssetHolderRepository : RepositoryBase, IAssetHolderRepository
    {
        public AssetHolderRepository(DbContext context) : base(context)
        {
        }
    }
}
