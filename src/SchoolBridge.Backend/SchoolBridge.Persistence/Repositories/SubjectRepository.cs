using SchoolBridge.Domain.Common.Commands;
using SchoolBridge.Domain.Common.Queries;
using SchoolBridge.Domain.Entities;
using SchoolBridge.Persistence.Caching.Brokers;
using SchoolBridge.Persistence.DataContexts;
using SchoolBridge.Persistence.Repositories.Interfaces;
using System.Linq.Expressions;

namespace SchoolBridge.Persistence.Repositories;

/// <summary>
/// Provides data access functionality for Subject entities.
/// Inheriting core repository logic from `EntityRepositoryBase`.
/// </summary>
public class SubjectRepository(AppDbContext appDbContext, ICacheBroker cacheBroker) :
    EntityRepositoryBase<Subject, AppDbContext>(appDbContext, cacheBroker),
    ISubjectRepository
{
    public IQueryable<Subject> Get(
        Expression<Func<Subject, bool>>? predicate = null,
        QueryOptions queryOptions = default) =>
    base.Get(predicate, queryOptions);

    public ValueTask<Subject?> GetByIdAsync(
        Guid id, 
        QueryOptions queryOptions = default, 
        CancellationToken cancellationToken = default) =>
    base.GetByIdAsync(id, queryOptions, cancellationToken);

    public ValueTask<IList<Subject>> GetByIdsAsync(
        IEnumerable<Guid> ids, 
        QueryOptions queryOptions = default, 
        CancellationToken cancellationToken = default) =>
    base.GetByIdsAsync(ids, queryOptions, cancellationToken);

    public ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default) =>
    base.CheckByIdAsync(id, cancellationToken);

    public ValueTask<Subject> CreateAsync(
        Subject subject, 
        CommandOptions commandOptions = default, 
        CancellationToken cancellationToken = default) =>
    base.CreateAsync(subject, commandOptions, cancellationToken);

    public ValueTask<Subject> UpdateAsync(
        Subject subject, 
        CommandOptions commandOptions, 
        CancellationToken cancellationToken = default) =>
    base.UpdateAsync(subject, commandOptions, cancellationToken);

    public ValueTask<Subject?> DeleteAsync(
        Subject subject,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default) =>
    base.DeleteAsync(subject, commandOptions, cancellationToken);

    public ValueTask<Subject?> DeleteByIdAsync(
        Guid id, 
        CommandOptions commandOptions, 
        CancellationToken cancellationToken = default) =>
    base.DeleteByIdAsync(id, commandOptions, cancellationToken);
}
