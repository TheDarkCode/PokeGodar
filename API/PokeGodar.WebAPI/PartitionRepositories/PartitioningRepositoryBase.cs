using PokeGodar.WebAPI.Entities;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;

namespace PokeGodar.WebAPI.PartitionRepositories
{
    /// <summary>
    /// All partitioned repository classes must inherit from this base class.  This base class 
    /// contains all the basic CRUD operations.
    /// </summary>
    /// <typeparam name="T">The entity type used for the repository.</typeparam>
    public class PartitioningRepositoryBase<T> : DocumentDbPartitioningClient, IPartitioningRepository<T> where T : ItemBase
    {
        #region ctors

        /// <summary>
        /// All Repository classes must inherit this base class.
        /// </summary>
        /// <param name="dbName">The name of the database.</param>
        public PartitioningRepositoryBase(string dbName)
            : base(dbName)
        {

        }

        #endregion

        #region Public Methods

        public async Task<Document> Create(string collectionLink, T entity)
        {
            return await Client.CreateDocumentAsync(collectionLink, entity);
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            var ret = Client.CreateDocumentQuery<T>(Database.SelfLink)
                .Where(predicate)
                .AsEnumerable();

            return ret;
        }

        public virtual IEnumerable<T> Find(string collectionLink, Expression<Func<T, bool>> predicate)
        {
            var ret = Client.CreateDocumentQuery<T>(collectionLink)
                .Where(predicate)
                .AsEnumerable();

            return ret;
        }

        public async Task<ResourceResponse<Document>> CreateDocumentAsync(T entity)
        {
            return await Client.CreateDocumentAsync(Database.SelfLink, entity);
        }

        public async Task<ResourceResponse<Document>> UpdateDocumentAsync(T entity)
        {
            var doc = GetDocument(entity.Id);

            return await Client.ReplaceDocumentAsync(doc.SelfLink, entity);
        }

        public async Task<ResourceResponse<Document>> DeleteDocumentAsync(string id)
        {
            var doc = GetDocument(id);

            return await Client.DeleteDocumentAsync(doc.SelfLink);
        }

        /// <summary>
        /// Get a T by Id.
        /// </summary>
        /// <param name="id">The id of the document.</param>
        /// <returns>An entity of type T.</returns>
        public async Task<T> GetById(string id)
        {
            return await Task<T>.Run(() =>
                Client.CreateDocumentQuery<T>(Database.SelfLink)
                .Where(p => p.Id == id)
                .AsEnumerable()
                .FirstOrDefault());
        }

        /// <summary>
        /// Get a list of T, with an optional predicate.
        /// </summary>
        /// <param name="authorId">The authorId to filter by.</param>
        /// <param name="predicate">The linq expression Where clause.</param>
        /// <returns>An IEnumerable of T.</returns>
        public async Task<IEnumerable<T>> GetByAuthor(string authorId, Expression<Func<T, bool>> predicate = null)
        {
            return await Task<T>.Run(() =>
                Client.CreateDocumentQuery<T>(Database.SelfLink)
                .Where(p => p.authorId == authorId)
                .Where(predicate)
                .AsEnumerable());
        }

        /// <summary>
        /// Get a list of all T, with an optional predicate.
        /// </summary>
        /// <param name="predicate">The linq expression Where clause.</param>
        /// <returns>An IEnumerable of T.</returns>
        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            if(predicate != null)
            {
                return await Task<T>.Run(() => Client.CreateDocumentQuery<T>(Database.SelfLink)
                    .AsQueryable()
                    .Where(predicate));
                
            } else
            {
                return await Task<T>.Run(() => Client.CreateDocumentQuery<T>(Database.SelfLink)
                    .AsQueryable());
            }
        }

        #endregion

        #region Private Methods

        private Document GetDocument(string id)
        {
            var doc = Client.CreateDocumentQuery<Document>(Database.SelfLink)
                            .Where(d => d.Id == id)
                            .AsEnumerable()
                            .FirstOrDefault();
            return doc;
        }

        #endregion
    }
}