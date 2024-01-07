namespace HttpClientWrapperDemo.HttpClientWrapper;

public interface IHttpClientWrapper
{
    Task<TResponse?> GetAsync<TResponse, TRequest>(string url, TRequest? request = default);
    Task<TResponse?> PostAsync<TResponse, TRequest>(string url, TRequest request, string contentType);
}