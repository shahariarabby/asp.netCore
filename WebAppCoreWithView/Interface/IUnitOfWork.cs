namespace WebAppCoreWithView.Interface
{
    public interface IUnitOfWork
    {
        IUser Users { get; }

        Task CompleteAsync();
        void SaveChanges();
    }
}
