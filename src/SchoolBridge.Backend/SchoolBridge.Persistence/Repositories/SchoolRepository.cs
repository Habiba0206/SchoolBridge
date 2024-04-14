using SchoolBridge.Domain.Common.Commands;
using SchoolBridge.Domain.Common.Queries;
using SchoolBridge.Domain.Entities;
using SchoolBridge.Persistence.Caching.Brokers;
using SchoolBridge.Persistence.DataContexts;
using SchoolBridge.Persistence.Repositories.Interfaces;
using System.Linq.Expressions;

namespace SchoolBridge.Persistence.Repositories;

/// <summary>
/// Provides data access functionality for School entities.
/// Inheriting core repository logic from `EntityRepositoryBase`.
/// </summary>
public class SchoolRepository(AppDbContext appDbContext, ICacheBroker cacheBroker) :
    EntityRepositoryBase<School, AppDbContext>(appDbContext, cacheBroker),
    ISchoolRepository
{
    public IQueryable<School> Get(
        Expression<Func<School, bool>>? predicate = null, 
        QueryOptions queryOptions = default) =>
    base.Get(predicate, queryOptions);

    public ValueTask<School?> GetByIdAsync(
        Guid id, 
        QueryOptions queryOptions = default, 
        CancellationToken cancellationToken = default) =>
    base.GetByIdAsync(id, queryOptions, cancellationToken);

    public ValueTask<IList<School>> GetByIdsAsync(
        IEnumerable<Guid> ids, 
        QueryOptions queryOptions = default, 
        CancellationToken cancellationToken = default) =>
    base.GetByIdsAsync(ids, queryOptions, cancellationToken);

    public ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default) =>
    base.CheckByIdAsync(id, cancellationToken);

    public ValueTask<School> CreateAsync(
        School school, 
        CommandOptions commandOptions = default, 
        CancellationToken cancellationToken = default) =>
    base.CreateAsync(school, commandOptions, cancellationToken);

    public ValueTask<School> UpdateAsync(
        School school, 
        CommandOptions commandOptions, 
        CancellationToken cancellationToken = default) =>
    base.UpdateAsync(school, commandOptions, cancellationToken);

    public ValueTask<School?> DeleteAsync(
        School school, 
        CommandOptions commandOptions, 
        CancellationToken cancellationToken = default) =>
    base.DeleteAsync(school, commandOptions, cancellationToken);

    public ValueTask<School?> DeleteByIdAsync(
        Guid id, 
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default) =>
    base.DeleteByIdAsync(id, commandOptions, cancellationToken);
}
