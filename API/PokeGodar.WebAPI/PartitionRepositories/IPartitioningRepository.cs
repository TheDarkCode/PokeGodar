using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents;

namespace PokeGodar.WebAPI.PartitionRepositories
{
    public interface IPartitioningRepository<T>
         where T : class
    {
        Task<IEnumerable<T>> GetByAuthor(string authorId, Expression<Func<T, bool>> predicate = null);
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate = null);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        Task<ResourceResponse<Document>> CreateDocumentAsync(T entity);
        Task<ResourceResponse<Document>> UpdateDocumentAsync(T entity);
        Task<ResourceResponse<Document>> DeleteDocumentAsync(string id);
    }
}
