using System.Linq.Expressions;
using WebAppCoreWithView.Models;

namespace WebAppCoreWithView.Interface
{
   
    //public interface IBase<T>
    //{
    //    IQueryable<T> FindAll();
    //    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    //    void Create(T entity);
    //    void Update(T entity);
    //    void Delete(T entity);
    //}
    public interface IUser: IBase<User>, IDisposable
    {
        User SaveUser(User user);
        User UpdateUser(User user);
        //IOwnerRepository Owner { get; }
        //IAccountRepository Account { get; }
        //void Save();
    }
}
