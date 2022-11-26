using MediatR;

namespace DotNetBlog.Application.Base;

public abstract class QueryBase<TRequest> : IRequest<TRequest>
{
}