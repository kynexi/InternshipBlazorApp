using InternshipBlazorApp.Core.Entities;
using InternshipBlazorApp.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipBlazorApp.UseCases.Features.Commands.DeleteUser;
public class DeleteUserCommandHandler: IRequestHandler<DeleteUserCommand, User?>
{
    private readonly IUsersRepository _repository;

    public DeleteUserCommandHandler(IUsersRepository repository)
    {
        _repository = repository;
    }

    public async Task<User?> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        return await _repository.DeleteUserAsync(request.Id, cancellationToken);
    }
}
