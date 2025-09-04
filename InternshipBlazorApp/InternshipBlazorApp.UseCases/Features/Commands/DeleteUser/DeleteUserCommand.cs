using InternshipBlazorApp.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipBlazorApp.UseCases.Features.Commands.DeleteUser;
public record DeleteUserCommand(Guid Id): IRequest<User?>;
