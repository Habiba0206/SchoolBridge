using SchoolBridge.Domain.Common.Commands;
using SchoolBridge.Domain.Common.Queries;
using SchoolBridge.Domain.Entities;
using System.Linq.Expressions;

namespace SchoolBridge.Persistence.Repositories.Interfaces;

/// <summary>
/// Represents a repository interface for managing student entities.
/// </summary>
public interface IStudentRepository
{
    /// <summary>
    /// Retrieves students based on optional filtering conditions and tracking prefrences.
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="queryOptions"></param>
    /// <returns></returns>
    IQueryable<Student> Get(
         Expression<Func<Student, bool>>? predicate = default,
         QueryOptions queryOptions = default);

    /// <summary>
    /// Asynchronously retrieves a student by its id, optionally applying caching.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="queryOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Student?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Checks if student exists.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously retrieves students by collection of ids.
    /// </summary>
    /// <param name="ids"></param>
    /// <param name="queryOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<IList<Student>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously creates a new student entity.
    /// </summary>
    /// <param name="student"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Student> CreateAsync(
        Student student,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously updates a student entity.
    /// </summary>
    /// <param name="student"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Student> UpdateAsync(
        Student student,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously deletes a student entity.
    /// </summary>
    /// <param name="student"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Student?> DeleteAsync(
        Student student,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously deletes an existing student entity by its id.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Student?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);
}
