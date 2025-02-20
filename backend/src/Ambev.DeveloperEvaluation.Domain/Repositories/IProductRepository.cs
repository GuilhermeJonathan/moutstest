﻿using Ambev.DeveloperEvaluation.Domain.Entities.Products;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> CreateAsync(Product product, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
        Task<List<string>> GetAllCategoriesAsync(CancellationToken cancellationToken = default);
        Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<List<Product>> GetPagedProductsAsync(int pageNumber, int pageSize, string orderByColumn, bool orderByDescending, 
            string? category, CancellationToken cancellationToken = default);
        Task<int> GetTotalCountAsync(string? category, CancellationToken cancellationToken = default);
        Task<Product> UpdateAsync(Product product, CancellationToken cancellationToken = default);
    }
}
