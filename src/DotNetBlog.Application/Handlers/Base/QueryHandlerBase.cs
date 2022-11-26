using MediatR;

namespace DotNetBlog.Application.Handlers.Base;

public class QueryHandlerBase<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
where TRequest : IRequest<TResponse>
{

    public QueryHandlerBase()
    {
        
    }
    
    public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}