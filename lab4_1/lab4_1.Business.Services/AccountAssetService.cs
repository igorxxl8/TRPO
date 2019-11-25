using lab4_1.Common.Core.Repositories.Interfaces;
using lab4_1.Common.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1.Business.Services
{
    public class AccountAssetService : ServiceBase<IAccountAssetRepository>, IAccountAssetService
    {
        public AccountAssetService(IAccountAssetRepository repository) : base(repository)
        {
        }
    }
}
