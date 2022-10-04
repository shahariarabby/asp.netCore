using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebAppCoreWithView.Interface;
using WebAppCoreWithView.ModelContext;
using WebAppCoreWithView.Models;

namespace WebAppCoreWithView.Repo
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ModelDbContext _context;
        //private readonly ILogger _logger;

        public IUser Users { get; private set; }

        public UnitOfWork(ModelDbContext context)
        {
            _context = context;
            
            Users = new UserRepo(context);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
            
        }

        public void SaveChanges()
        {
             _context.SaveChanges();

        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
