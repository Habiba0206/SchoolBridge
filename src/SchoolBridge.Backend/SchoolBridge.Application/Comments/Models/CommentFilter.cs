﻿using SchoolBridge.Application.Classes.Models;
using SchoolBridge.Domain.Common.Queries;

namespace SchoolBridge.Application.Comments.Models;

public class CommentFilter : FilterPagination
{
    /// <summary>
    /// Overrides base GetHashCode method
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        var hashCode = new HashCode();

        hashCode.Add(PageToken);
        hashCode.Add(PageSize);

        return hashCode.ToHashCode();
    }

    /// <summary>
    /// Overrides base Equels method
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj) =>
        obj is CommentFilter commentFilter
        && commentFilter.GetHashCode() == GetHashCode();
}
