using ApidoPI.Entity;

namespace ApidoPI.Contracts.Repository
{
    public interface IBairroRepository
    {
        Task<IEnumerable<BairroEntity>> Get();
    }
}