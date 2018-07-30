using SalesManagement.ConsoleApp.Domain.Data.Enum;

namespace SalesManagement.ConsoleApp.Domain.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}