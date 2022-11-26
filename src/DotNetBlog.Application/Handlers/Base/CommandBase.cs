using MediatR;
using ResultSuccess;

namespace DotNetBlog.Application.Handlers.Base;

public abstract class CommandBase : IRequest<Result>
{
}