using InternshipBlazorApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipBlazorApp.Core.Interfaces;

public interface IUsersRepository
{
    public Task<User> CreateUserAsync(User user, CancellationToken cancellationToken);
    public Task<User?> GetUserAsync(Guid id, CancellationToken cancellationToken);
    public Task<User?> DeleteUserAsync(Guid id, CancellationToken cancellationToken);
}
 