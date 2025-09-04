using InternshipBlazorApp.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipBlazorApp.UseCases.Features.Commands.CreateUser;

public record CreateUserCommand(string FirstName, string LastName, int Age, bool IsMarried): IRequest<User>;