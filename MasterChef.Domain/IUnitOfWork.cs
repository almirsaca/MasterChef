namespace MasterChef.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        int Commit();
        void Dispose();
    }
}