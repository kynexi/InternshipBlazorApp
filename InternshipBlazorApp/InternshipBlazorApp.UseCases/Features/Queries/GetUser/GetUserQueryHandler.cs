using InternshipBlazorApp.Core.Entities;
using InternshipBlazorApp.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipBlazorApp.UseCases.Features.Queries.GetUser;

internal class GetUserQueryHandler: IRequestHandler<GetUserQuery, User?>
{
    private readonly IUsersRepository _repository;

    public GetUserQueryHandler(IUsersRepository repository)
    {
        _repository = repository;
    }

    public async Task<User?> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetUserAsync(request.Id, cancellationToken);
    }
}
