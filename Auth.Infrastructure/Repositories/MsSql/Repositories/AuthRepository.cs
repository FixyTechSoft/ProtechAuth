using Auth.Application.Exceptions;
using Auth.Application.Ports.Repositories;
using Auth.Domain;
using Auth.Infrastructure.Repositories.MsSql.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.Infrastructure.Repositories.MsSql.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        internal SqlDbContext Context;
        internal DbSet<User> dbSet;

        public AuthRepository(SqlDbContext context)
        {
            this.Context = context;
            this.dbSet = context.Set<User>();
        }

        public async Task<User> GetUserByUserId(Guid userId)
        {
            return await dbSet.FindAsync(userId);
        }

        public Task<User> GetUserByEmail(string email)
        {
            return Task.FromResult(dbSet.Where(u => u.Email == email).FirstOrDefault());

        }

        public Task UpdateUser(User user)
        {

            user.UpdateDate = DateTime.UtcNow;

            try
            {
                dbSet.Attach(user);
                Context.Entry(user).State = EntityState.Modified;

                return Task.FromResult(user);
            }
            catch (UpdateUserException)
            {
                throw new UpdateUserException("User could not be updated. Result is not acknowledged");
            }
        }

        public async Task CreateUser(User user)
        {
            await dbSet.AddAsync(user);
            await Context.SaveChangesAsync();
        }
    }
}
