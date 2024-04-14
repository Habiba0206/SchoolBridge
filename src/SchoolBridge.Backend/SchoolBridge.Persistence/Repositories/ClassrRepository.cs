using SchoolBridge.Domain.Common.Commands;
using SchoolBridge.Domain.Common.Queries;
using SchoolBridge.Domain.Entities;
using SchoolBridge.Persistence.Caching.Brokers;
using SchoolBridge.Persistence.DataContexts;
using SchoolBridge.Persistence.Repositories.Interfaces;
using System.Linq.Expressions;

namespace SchoolBridge.Persistence.Repositories;

/// <summary>
/// Provides data access functionality for Class entities.
/// Inheriting core repository logic from `EntityRepositoryBase`.
/// </summary>
public class ClassrRepository(AppDbContext appDbContext, ICacheBroker cacheBroker) :
    EntityRepositoryBase<Class, AppDbContext>(appDbContext, cacheBroker),
    IClassRepository

{
    public IQueryable<Class> Get(
        Expression<Func<Class, bool>>? predicate = null, 
        QueryOptions queryOptions = default) =>
    base.Get(predicate, queryOptions);

    public ValueTask<Class?> GetByIdAsync(
        Guid id, 
        QueryOptions queryOptions = default, 
        CancellationToken cancellationToken = default) =>
    base.GetByIdAsync(id, queryOptions, cancellationToken);

    public ValueTask<IList<Class>> GetByIdsAsync(
        IEnumerable<Guid> ids, 
        QueryOptions queryOptions = default, 
        CancellationToken cancellationToken = default) =>
    base.GetByIdsAsync(ids, queryOptions, cancellationToken);

    public ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default) =>
    base.CheckByIdAsync(id, cancellationToken);

    public ValueTask<Class> CreateAsync(
        Class @class, 
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default) =>
    base.CreateAsync(@class, commandOptions, cancellationToken);

    public ValueTask<Class> UpdateAsync(
        Class @class, 
        CommandOptions commandOptions, 
        CancellationToken cancellationToken) =>
    base.UpdateAsync(@class, commandOptions, cancellationToken);

    public ValueTask<Class?> DeleteAsync(
        Class @class, 
        CommandOptions commandOptions, 
        CancellationToken cancellationToken = default) =>
    base.UpdateAsync(@class, commandOptions, cancellationToken);

    public ValueTask<Class?> DeleteByIdAsync(
        Guid id, 
        CommandOptions commandOptions, 
        CancellationToken cancellationToken = default) =>
    base.DeleteByIdAsync(id, commandOptions, cancellationToken);
}
