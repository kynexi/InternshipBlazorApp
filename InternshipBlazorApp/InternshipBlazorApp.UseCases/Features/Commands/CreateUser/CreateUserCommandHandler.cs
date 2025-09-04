using InternshipBlazorApp.Core.Entities;
using InternshipBlazorApp.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipBlazorApp.UseCases.Features.Commands.CreateUser;

internal class CreateUserCommandHandler: IRequestHandler<CreateUserCommand, User>
{
    private readonly IUsersRepository _repository;

    public CreateUserCommandHandler(IUsersRepository repository)
    {
        _repository = repository;
    }

    public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Age = request.Age,
            IsMarried = request.IsMarried
        };

        return await _repository.CreateUserAsync(user, cancellationToken);
    }
}
