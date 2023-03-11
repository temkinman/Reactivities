namespace Application.Core;

public class AppException
{
	public int StatusCode { get; private set; }
	public string Message { get; private set; }
	public string? Details { get; private set; }

	public AppException(int statusCode, string message, string? details = null)
	{
		StatusCode = statusCode;
		Message = message;
		Details = details;
	}
}
