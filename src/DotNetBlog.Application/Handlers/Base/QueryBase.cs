using MediatR;

namespace DotNetBlog.Application.Handlers.Base;

public abstract class QueryBase<TRequest> : IRequest<TRequest>
{
}