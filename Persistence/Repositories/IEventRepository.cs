using Persistence.Entities;
namespace Persistence.Repositories;

public interface IEventRepository : IBaseRepository<EventEntity>
{
    Task<decimal?> GetLowestPackagePriceAsync();
}