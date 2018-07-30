namespace SalesManagement.ConsoleApp.Domain.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }
    }
}