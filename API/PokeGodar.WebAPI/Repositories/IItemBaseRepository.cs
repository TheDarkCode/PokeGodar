using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using PokeGodar.WebAPI.Entities;

namespace PokeGodar.WebAPI.Repositories
{
    public interface IItemBaseRepository
    {
        Task<Document> Create(ItemBase item);
        IEnumerable<ItemBase> Find(Expression<Func<ItemBase, bool>> predicate);
        IEnumerable<ItemBase> Find(string docType, Expression<Func<ItemBase, bool>> predicate);
        void getResolver(int resolverService);

    }
}
