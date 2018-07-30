using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesManagement.ConsoleApp.Infrastructure.Infrastructure.SharedKernel
{
    public abstract class DomainEntity<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }

        public bool IsTransient() => Id.Equals(obj: default(T));
    }
}