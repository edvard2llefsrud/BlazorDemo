namespace BlazorDemo.Common.Web.ApiAccess;

public enum ApiStatusCode
{
    /// <summary>
    /// An unknown error
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// No result was retrieved from the Api
    /// </summary>
    NoResult = 1,

    /// <summary>
    /// The resource was not found
    /// </summary>
    NotFound = 404,

    /// <summary>
    /// Authorization for the specific resource was not found
    /// </summary>
    Unauthorized = 401,

    /// <summary>
    /// Access to the specific resource was forbidden
    /// </summary>
    Forbidden = 403,

    /// <summary>
    /// The request to the api was ambiguous
    /// </summary>
    Ambiguous = 300,

    /// <summary>
    /// A more general Bad request occured
    /// </summary>
    BadRequest = 400,

    /// <summary>
    /// An error happened within the Api
    /// </summary>
    ServerError = 500,

    /// <summary>
    /// A successful response
    /// </summary>
    Ok = 200,

    /// <summary>
    /// Failed connection attempt
    /// </summary>
    ConnectFailure = 3,

    /// <summary>
    /// A webexception occured
    /// </summary>
    WebException = 4,

    /// <summary>
    /// A conflicted response
    /// </summary>
    Conflict = 409,

    /// <summary>
    /// A NotAllowed response
    /// </summary>
    NotAllowed = 405
}