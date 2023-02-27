namespace BlazorDemo.Common.Web.ApiAccess;

/// <summary>
/// the basic api result containing response information
/// </summary>
public class ApiResult
{
    private List<string> apiErrorMessages;

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiResult"/> class. 
    /// </summary>
    /// <param name="apiMethodType">Takes the method type as parameter</param>
    public ApiResult(ApiMethodType apiMethodType)
    {
        this.MethodType = apiMethodType;
    }

    /// <summary>
    /// The internal statuses retrieved from the response
    /// </summary>
    public ApiStatusCode Status { get; set; }

    /// <summary>
    /// The api Method type requested
    /// </summary>
    public ApiMethodType MethodType { get; protected set; }

    /// <summary>
    /// True if the response status indicates success, otherwise false
    /// </summary>
    public bool Success
    {
        get
        {
            return this.ErrorMessages.Any() == false;
        }
    }

    /// <summary>
    /// A list of errors in the response or while handling the response
    /// </summary>
    public List<string> ErrorMessages
    {
        get
        {
            if (this.apiErrorMessages == null)
            {
                this.apiErrorMessages = new List<string>();
            }

            return this.apiErrorMessages;
        }
        set => this.apiErrorMessages = value;
    }

    /// <summary>
    /// The url requested from the api
    /// </summary>
    public string RequestUrl { get; set; }

    /// <summary>
    /// Adds the error message to the ErrorMessage collection
    /// </summary>
    /// <param name="exp">The exception to add</param>
    public void AddError(Exception exp)
    {
        this.ErrorMessages.Add(exp.Message);
    }

    /// <summary>
    /// Adds an errormessage to the ErrorMessage collection
    /// </summary>
    /// <param name="errorMessage">The error message</param>
    public void AddError(string errorMessage)
    {
        this.ErrorMessages.Add(errorMessage);
    }
}

/// <inheritdoc />
/// <summary>
/// The generic api result containing the json deserialized result
/// </summary>
/// <typeparam name="T">The type o the generic result</typeparam>
public class ApiResult<T> : ApiResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiResult{T}"/> class. 
    /// </summary>
    /// <param name="apiMethodType">Takes the methodtype as parameter</param>
    public ApiResult(ApiMethodType apiMethodType) : base(apiMethodType)
    {
    }

    /// <summary>
    /// The result object
    /// </summary>
    public T Result { get; set; }
}
