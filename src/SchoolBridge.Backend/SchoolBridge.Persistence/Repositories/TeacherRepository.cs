using SchoolBridge.Domain.Common.Commands;
using SchoolBridge.Domain.Common.Queries;
using SchoolBridge.Domain.Entities;
using SchoolBridge.Persistence.Caching.Brokers;
using SchoolBridge.Persistence.DataContexts;
using SchoolBridge.Persistence.Repositories.Interfaces;
using System.Linq.Expressions;

namespace SchoolBridge.Persistence.Repositories;

/// <summary>
/// Provides data access functionality for Teacher entities.
/// Inheriting core repository logic from `EntityRepositoryBase`.
/// </summary>
public class TeacherRepository(AppDbContext appDbContext, ICacheBroker cacheBroker) :
    EntityRepositoryBase<Teacher, AppDbContext>(appDbContext, cacheBroker),
    ITeacherRepository
{
    public IQueryable<Teacher> Get(
        Expression<Func<Teacher, bool>>? predicate = null, 
        QueryOptions queryOptions = default) =>
    base.Get(predicate, queryOptions);

    public ValueTask<Teacher?> GetByIdAsync(
        Guid id, 
        QueryOptions queryOptions = default, 
        CancellationToken cancellationToken = default) =>
    base.GetByIdAsync(id, queryOptions, cancellationToken);

    public ValueTask<IList<Teacher>> GetByIdsAsync(
        IEnumerable<Guid> ids, 
        QueryOptions queryOptions = default, 
        CancellationToken cancellationToken = default) =>
    base.GetByIdsAsync(ids, queryOptions, cancellationToken);

    public ValueTask<bool> CheckByIdAsync(
        Guid id, 
        CancellationToken cancellationToken = default) =>
    base.CheckByIdAsync(id, cancellationToken);

    public ValueTask<Teacher> CreateAsync(
        Teacher teacher, 
        CommandOptions commandOptions = default, 
        CancellationToken cancellationToken = default) =>
    base.CreateAsync(teacher, commandOptions, cancellationToken);

    public ValueTask<Teacher> UpdateAsync(
        Teacher teacher, 
        CommandOptions commandOptions, 
        CancellationToken cancellationToken = default) =>
    base.UpdateAsync(teacher, commandOptions, cancellationToken);

    public ValueTask<Teacher?> DeleteAsync(
        Teacher teacher, 
        CommandOptions commandOptions, 
        CancellationToken cancellationToken = default) =>
    base.DeleteAsync(teacher, commandOptions, cancellationToken);

    public ValueTask<Teacher?> DeleteByIdAsync(
        Guid id, 
        CommandOptions commandOptions, 
        CancellationToken cancellationToken = default) =>
    base.DeleteByIdAsync(id, commandOptions, cancellationToken);
}
