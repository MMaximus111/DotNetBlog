using MediatR;

namespace DotNetBlog.Application.Handlers.Base;

public abstract class QueryHandlerBase<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
where TRequest : IRequest<TResponse>
{
    protected abstract Task<TResponse> QueryAsync(TRequest request, CancellationToken cancellationToken);

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
    {
        var response = await QueryAsync(request, cancellationToken);

        return response;
    }
}