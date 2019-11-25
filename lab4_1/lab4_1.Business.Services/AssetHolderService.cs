using lab4_1.Common.Core.Repositories.Interfaces;
using lab4_1.Common.Core.Services.Interfaces;

namespace lab4_1.Business.Services
{
    public class AssetHolderService : ServiceBase<IAssetHolderRepository>, IAssetHolderService
    {
        public AssetHolderService(IAssetHolderRepository repository) : base(repository)
        {
        }
    }
}
