using InternshipBlazorApp.Core.Entities;
using InternshipBlazorApp.Core.Interfaces;
using InternshipBlazorApp.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipBlazorApp.Infrastructure.Repositories
{
    public class UsersRepository: IUsersRepository
    {   
        private readonly AppDbContext _context;

        public UsersRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> CreateUserAsync(User user, CancellationToken cancellationToken)
        {
            var entity = await _context.Users.AddAsync(user, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Entity;
        }

        public async Task<User?> GetUserAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Users.FindAsync(new object?[] { id }, cancellationToken);
        }

        public async Task<User?> DeleteUserAsync(Guid id, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FindAsync(new object?[] { id }, cancellationToken);
            if (user == null)
            {
                return null;
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync(cancellationToken);
            return user;
        }
    }
}
