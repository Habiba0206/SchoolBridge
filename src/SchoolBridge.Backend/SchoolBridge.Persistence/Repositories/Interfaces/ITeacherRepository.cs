using SchoolBridge.Domain.Common.Commands;
using SchoolBridge.Domain.Common.Queries;
using SchoolBridge.Domain.Entities;
using System.Linq.Expressions;

namespace SchoolBridge.Persistence.Repositories.Interfaces;

/// <summary>
/// Represents a repository interface for managing teacher entities.
/// </summary>
public interface ITeacherRepository
{
    /// <summary>
    /// Retrieves teachers based on optional filtering conditions and tracking prefrences.
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="queryOptions"></param>
    /// <returns></returns>
    IQueryable<Teacher> Get(
         Expression<Func<Teacher, bool>>? predicate = default,
         QueryOptions queryOptions = default);

    /// <summary>
    /// Asynchronously retrieves a teacher by its id, optionally applying caching.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="queryOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Teacher?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Checks if teacher exists.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously retrieves teachers by collection of ids.
    /// </summary>
    /// <param name="ids"></param>
    /// <param name="queryOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<IList<Teacher>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously creates a new teacher entity.
    /// </summary>
    /// <param name="teacher"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Teacher> CreateAsync(
        Teacher teacher,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously updates a teacher entity.
    /// </summary>
    /// <param name="teacher"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Teacher> UpdateAsync(
        Teacher teacher,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously deletes a teacher entity.
    /// </summary>
    /// <param name="teacher"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Teacher?> DeleteAsync(
        Teacher teacher,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously deletes an existing teacher entity by its id.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Teacher?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);
}
