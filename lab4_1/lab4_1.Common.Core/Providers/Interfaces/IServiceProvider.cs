namespace lab4_1.Common.Core.Providers.Interfaces
{
    public interface IServiceProvider<TBuilder>
    {
        void RegisterServices(TBuilder builder);
    }
}
