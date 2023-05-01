using System.Linq.Expressions;

public interface IBaseRepository<TEntity> where TEntity : class
{

    public void Add(TEntity entity);

    public Task<TEntity> AddAsync(TEntity entity);

    public void Update(TEntity entity);

    public Task UpdateAsync(TEntity entity);

    public void Delete(object Id);

    public void Delete(TEntity entity);

    public Task DeleteAsync(TEntity entity);

    public void Delete(Expression<Func<TEntity, bool>>? where);

    public void Delete(Expression<Func<TEntity, bool>>? where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy, params Expression<Func<TEntity, object>>[] includes);

    public TEntity GetById(object Id);

    public IEnumerable<TEntity> GetAll();

    public Task<IReadOnlyList<TEntity>> GetAllAsync();

    //public Task<List<TEntity>> GetAllAsync();

    public TEntity GetFirst(Expression<Func<TEntity, bool>>? where);

    public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>>? where);

    public IEnumerable<TEntity> GetWithExpressions(Expression<Func<TEntity, bool>>? where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, params Expression<Func<TEntity, object>>[] includes);

    public Task<TEntity> GetByIdAsync(object Id);

    public Task<TEntity> GetFirstAsync(Expression<Func<TEntity, bool>>? where);

    public Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>>? where);

    public void Commit();

    public Task<int> CommitAsync();

}