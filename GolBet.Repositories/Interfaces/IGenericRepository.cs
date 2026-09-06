// GolBet.Repositories/Interfaces/IGenericRepository.cs
using GolBet.Entities.Common;

namespace GolBet.Repositories.Interfaces;

/// <summary>
/// Generic data-access contract for all domain entities.
/// Specific queries live in entity-specific repositories.
/// </summary>
public interface IGenericRepository<T> where T : AuditableEntity
{
    // ---- Queries ---- CQS
    //METODO 1
    Task<IEnumerable<T>> GetAllAsync(bool includeInactive = false);

    //METODO 2
    Task<T?> GetByIdAsync(int id);

    // ---- Commands ----
    //METODO 3
    Task<T> AddAsync(T entity);

    //METODO 4
    Task UpdateAsync(T entity);

    //METODO 5
    Task DeactivateAsync(int id);   // logical delete: IsActive = false
}
