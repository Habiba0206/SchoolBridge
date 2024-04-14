using SchoolBridge.Domain.Common.Commands;
using SchoolBridge.Domain.Common.Queries;
using SchoolBridge.Domain.Entities;
using SchoolBridge.Persistence.Caching.Brokers;
using SchoolBridge.Persistence.DataContexts;
using SchoolBridge.Persistence.Repositories.Interfaces;
using System.Linq.Expressions;

namespace SchoolBridge.Persistence.Repositories;

/// <summary>
/// Provides data access functionality for Student entities.
/// Inheriting core repository logic from `EntityRepositoryBase`.
/// </summary>
public class StudentRepository(AppDbContext appDbContext, ICacheBroker cacheBroker) :
    EntityRepositoryBase<Student, AppDbContext>(appDbContext, cacheBroker),
    IStudentRepository
{
    public IQueryable<Student> Get(
        Expression<Func<Student, bool>>? predicate = null, 
        QueryOptions queryOptions = default) =>
    base.Get(predicate, queryOptions);

    public ValueTask<Student?> GetByIdAsync(
        Guid id, 
        QueryOptions queryOptions = default, 
        CancellationToken cancellationToken = default) =>
    base.GetByIdAsync(id, queryOptions, cancellationToken);

    public ValueTask<IList<Student>> GetByIdsAsync(
        IEnumerable<Guid> ids, 
        QueryOptions queryOptions = default, 
        CancellationToken cancellationToken = default) =>
    base.GetByIdsAsync(ids, queryOptions, cancellationToken);

    public ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default) =>
    base.CheckByIdAsync(id, cancellationToken);

    public ValueTask<Student> CreateAsync(
        Student student, 
        CommandOptions commandOptions = default, 
        CancellationToken cancellationToken = default) =>
    base.CreateAsync(student, commandOptions, cancellationToken);

    public ValueTask<Student> UpdateAsync(
        Student student, 
        CommandOptions commandOptions, 
        CancellationToken cancellationToken = default) =>
    base.UpdateAsync(student, commandOptions, cancellationToken);

    public ValueTask<Student?> DeleteAsync(
        Student student,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default) =>
    base.UpdateAsync(student, commandOptions, cancellationToken);

    public ValueTask<Student?> DeleteByIdAsync(
        Guid id, 
        CommandOptions commandOptions, 
        CancellationToken cancellationToken = default) =>
    base.DeleteByIdAsync(id, commandOptions, cancellationToken);
}
