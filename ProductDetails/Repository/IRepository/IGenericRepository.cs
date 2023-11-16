﻿namespace ProductDetails.Repository.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll();

        Task<T> Get(int id);

        Task Create(T entity);

        Task Delete(T entity);

        Task Save();
      
    }
}
