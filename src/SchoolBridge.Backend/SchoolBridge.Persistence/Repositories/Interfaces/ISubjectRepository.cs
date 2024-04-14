using SchoolBridge.Domain.Common.Commands;
using SchoolBridge.Domain.Common.Queries;
using SchoolBridge.Domain.Entities;
using System.Linq.Expressions;

namespace SchoolBridge.Persistence.Repositories.Interfaces;

/// <summary>
/// Represents a repository interface for managing subject entities.
/// </summary>
public interface ISubjectRepository
{
    /// <summary>
    /// Retrieves subjects based on optional filtering conditions and tracking prefrences.
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="queryOptions"></param>
    /// <returns></returns>
    IQueryable<Subject> Get(
         Expression<Func<Subject, bool>>? predicate = default,
         QueryOptions queryOptions = default);

    /// <summary>
    /// Asynchronously retrieves a subject by its id, optionally applying caching.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="queryOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Subject?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Checks if subject exists.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously retrieves subjects by collection of ids.
    /// </summary>
    /// <param name="ids"></param>
    /// <param name="queryOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<IList<Subject>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously creates a new subject entity.
    /// </summary>
    /// <param name="subject"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Subject> CreateAsync(
        Subject subject,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously updates a subject entity.
    /// </summary>
    /// <param name="subject"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Subject> UpdateAsync(
        Subject subject,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously deletes a subject entity.
    /// </summary>
    /// <param name="subject"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Subject?> DeleteAsync(
        Subject subject,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously deletes an existing subject entity by its id.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Subject?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);
}
