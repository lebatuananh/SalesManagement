﻿namespace SalesManagement.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }
    }
}