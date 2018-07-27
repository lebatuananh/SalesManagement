using SalesManagement.Data.Enums;

namespace SalesManagement.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}