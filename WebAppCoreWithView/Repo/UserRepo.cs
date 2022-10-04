using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebAppCoreWithView.Interface;
using WebAppCoreWithView.ModelContext;
using WebAppCoreWithView.Models;

namespace WebAppCoreWithView.Repo
{
    public class UserRepo : Base<User>, IUser
    {
        public UserRepo(ModelDbContext modelDbContext) : base(modelDbContext)
        {
        }

        public User SaveUser(User user)
        {
            try
            {
                Create(user);

                SaveChanges();
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User UpdateUser(User user)
        {
            try
            {
                

                Update(user);

                SaveChanges();
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }


        #region Dispose
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    ModelDbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion


    }


}
