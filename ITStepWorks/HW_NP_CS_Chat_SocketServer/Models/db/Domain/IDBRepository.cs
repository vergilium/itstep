using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Domain
{
    public interface IDbRepository<T>
          where T : class, IDbIdentity {
        IQueryable<T> AllItems { get; }
        DbContext Context { get; }
        Task<List<T>> ToListAsync();
        Task<int> AddItemAsync(T item);
        Task<int> AddItemsAsync(IEnumerable<T> items);
        Task<T> GetItemAsync(long id);
        Task<bool> ChangeItemAsync(T item);
        Task<bool> DeleteItemAsync(long id);
        Task<int> SaveChangesAsync();
        Task<bool> UpdateItemAsync(T item);
    }
}
