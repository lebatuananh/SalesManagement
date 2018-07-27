namespace SalesManagement.Infrastructure.SharedKernel
{
    public abstract class DomainEntity<T>
    {
        public T Id { get; set; }

        public bool IsTransient() => Id.Equals(obj: default(T));
    }
}