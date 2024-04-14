using SchoolBridge.Domain.Common.Commands;
using SchoolBridge.Domain.Common.Queries;
using SchoolBridge.Domain.Entities;
using System.Linq.Expressions;

namespace SchoolBridge.Persistence.Repositories.Interfaces;

/// <summary>
/// Represents a repository interface for managing class entities.
/// </summary>
public interface IClassRepository
{
    /// <summary>
    /// Retrieves classes based on optional filtering conditions and tracking prefrences.
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="queryOptions"></param>
    /// <returns></returns>
    IQueryable<Class> Get(
         Expression<Func<Class, bool>>? predicate = default,
         QueryOptions queryOptions = default);

    /// <summary>
    /// Asynchronously retrieves a class by its id, optionally applying caching.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="queryOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Class?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Checks if class exists.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously retrieves classes by collection of ids.
    /// </summary>
    /// <param name="ids"></param>
    /// <param name="queryOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<IList<Class>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously creates a new class entity.
    /// </summary>
    /// <param name="class"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Class> CreateAsync(
        Class @class,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously updates a class entity.
    /// </summary>
    /// <param name="class"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Class> UpdateAsync(
        Class @class,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously deletes a class entity.
    /// </summary>
    /// <param name="class"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Class?> DeleteAsync(
        Class @class,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously deletes an existing class entity by its id.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Class?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);
}
