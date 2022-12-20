namespace lab4.Repos.GenericRepos
{
    public class GenericRepos<TEntity> : IGenericRepos<TEntity> where TEntity : BaseEntity.BaseEntity
    {


        public void Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }


        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public TEntity FindById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAllAsQueryable()
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
