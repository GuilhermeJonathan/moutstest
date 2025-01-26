namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.ListUsers;

/// <summary>
/// Request model for getting a list users
/// </summary>
public class ListUsersRequest
{
    /// <summary>
    /// (optional): Page number for pagination (default: 1)
    /// </summary>
    public int Page { get; set; } = 1;

    /// <summary>
    /// (optional): Number of items per page (default: 10)
    /// </summary>
    public int Size { get; set; } = 10;

    /// <summary>
    /// (optional): Ordering of results (e.g., "username asc, email desc")
    /// </summary>
    public string? Order { get; set; } = string.Empty;
}