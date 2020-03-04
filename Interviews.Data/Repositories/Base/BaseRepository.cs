using Interviews.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interviews.Data.Repositories.Base
{
    public class BaseRepository<TIdType, T> : IBaseRepository<TIdType, T>
        where T : class
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseRepository{TIdType,T}" /> class.
        /// </summary>
        /// <param name="context">The session.</param>
        protected BaseRepository(InterviewDbContext context)
        {
            Context = context;
        }

        /// <summary>
        ///     Gets the session.
        /// </summary>
        protected InterviewDbContext Context { get; }

        /// <summary>
        ///     Gets the entity collection.
        /// </summary>
        protected DbSet<T> DbSet => Context.Set<T>();

        /// <inheritdoc />
        /// <summary>
        ///     Gets an entity by its id.
        /// </summary>
        /// <param name="id">The entity id.</param>
        /// <returns>An entity</returns>
        public virtual async Task<T> GetSingleByIdAsync(TIdType id)
        {
            var entity = await DbSet.FindAsync(id);
            return entity;
        }

        /// <inheritdoc />
        /// <summary>
        ///     Gets all instances of the entity type.
        /// </summary>
        /// <returns>An Enumerable with the list of entities.</returns>
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            var results = DbSet;
            return await results.ToListAsync();
        }

        /// <inheritdoc />
        /// <summary>
        ///     Gets an entity by expression parameter
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression)
        {
            return await DbSet.FirstOrDefaultAsync(expression);
        }

        /// <inheritdoc />
        /// <summary>
        ///     Gets all instances of the entity type by expression parameter
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> expression)
        {
            return await DbSet.Where(expression).ToListAsync();
        }

        /// <inheritdoc />
        /// <summary>
        ///     Saves the current state of the specified entity.
        /// </summary>
        /// <param name="entity">The entity to persist.</param>
        /// <returns>An entity</returns>
        public virtual T Save(T entity)
        {
            DbSet.Add(entity);
            return entity;
        }

        /// <inheritdoc />
        /// <summary>
        ///     Set a state modified to the specified entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>An entity with modified state</returns>
        public virtual T Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        /// <inheritdoc />
        /// <summary>
        ///     Attaching an existing entity to the context before the update
        ///     <see
        ///         cref="https://docs.microsoft.com/en-us/ef/ef6/saving/change-tracking/entity-state#attaching-an-existing-entity-to-the-context" />
        /// </summary>
        /// <param name="entity"></param>
        public void Attach(T entity)
        {
            Context.Set<T>().Attach(entity);
        }

        /// <inheritdoc />
        /// <summary>
        ///     Removes the specified entity.
        /// </summary>
        /// <param name="entity">The entity to be deleted.</param>
        public virtual void Remove(T entity)
        {
            DbSet.Remove(entity);
        }
    }

}
