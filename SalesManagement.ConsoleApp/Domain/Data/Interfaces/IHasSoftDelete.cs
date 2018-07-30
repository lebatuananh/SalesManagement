namespace SalesManagement.ConsoleApp.Domain.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { set; get; }
    }
}