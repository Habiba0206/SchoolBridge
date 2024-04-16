using SchoolBridge.Domain.Common.Commands;
using SchoolBridge.Domain.Common.Queries;
using SchoolBridge.Domain.Entities;
using System.Linq.Expressions;

namespace SchoolBridge.Application.Comments.Services;

/// <summary>
/// Interface for managing comment entities.
/// </summary>
public interface ICommentService
{
    /// <summary>
    /// Retrieves comments based on optional filtering conditions and tracking prefrences.
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="queryOptions"></param>
    /// <returns></returns>
    IQueryable<Comment> Get(
         Expression<Func<Comment, bool>>? predicate = default,
         QueryOptions queryOptions = default);

    /// <summary>
    /// Asynchronously retrieves a comment by its id, optionally applying caching.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="queryOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Comment?> GetByIdAsync(
        Guid id,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Checks if comment exists.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<bool> CheckByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously retrieves comments by collection of ids.
    /// </summary>
    /// <param name="ids"></param>
    /// <param name="queryOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<IList<Comment>> GetByIdsAsync(
        IEnumerable<Guid> ids,
        QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously creates a new comment entity.
    /// </summary>
    /// <param name="comment"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Comment> CreateAsync(
        Comment comment,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously updates a comment entity.
    /// </summary>
    /// <param name="comment"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Comment> UpdateAsync(
        Comment comment,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously deletes a comment entity.
    /// </summary>
    /// <param name="comment"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Comment?> DeleteAsync(
        Comment comment,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously deletes an existing comment entity by its id.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="commandOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<Comment?> DeleteByIdAsync(
        Guid id,
        CommandOptions commandOptions,
        CancellationToken cancellationToken = default);
}
