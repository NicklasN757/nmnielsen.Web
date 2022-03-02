using nmnielsen.Repository.Interfaces;
using nmnielsen.Service.Interfaces;

namespace nmnielsen.Service.Services;
public abstract class GenericService<T, I, E> : BaseService, IGenericService<T> where T : class where I : IGenericRepository<E> where E : class
{
    private readonly I _genericRepository;
    private readonly MappingService _mappingService;
    private readonly string _entityName = typeof(E).ToString().Replace("Prototype.Repository.Entities.", "");

    public GenericService(MappingService mappingService, I genericRepository)
    {
        _mappingService = mappingService;
        _genericRepository = genericRepository;
    }

    //Calls and logs the "CreateAsync" function from the GenericRepository
    public async Task CreateAsync(T entity)
    {
        try
        {
            await _genericRepository.CreateAsync(_mappingService._mapper.Map<E>(entity));
            LogInformation($"Successfully created a new {_entityName}.");
        }
        catch (Exception ex)
        {
            LogError($"Failed to create a new {_entityName}.", ex);
        }
    }

    //Calls and logs the "GetAllAsync" function from the GenericRepository
    public async Task<List<T>> GetAllAsync()
    {
        try
        {
            List<T> tmpList = _mappingService._mapper.Map<List<T>>(await _genericRepository.GetAllAsync());

            LogInformation($"Successfully fetched a list of {_entityName}s.");

            return tmpList;
        }
        catch (Exception ex)
        {
            LogError($"Failed to fetch a list of {_entityName}s.", ex);

            return new List<T>();
        }
    }

    //Calls and logs the "UpdateAsync" function from the GenericRepository
    public async Task UpdateAsync(T entity)
    {
        try
        {
            await _genericRepository.UpdateAsync(_mappingService._mapper.Map<E>(entity));
            LogInformation($"Successfully updated a {_entityName}.");
        }
        catch (Exception ex)
        {
            LogError($"Failed to update a {_entityName}.", ex);
        }
    }

    //Calls and logs the "GetByIdAsync" function from the GenericRepository
    public async Task<T> GetByIdAsync(object id)
    {
        try
        {
            T tmpEntity = _mappingService._mapper.Map<T>(await _genericRepository.GetByIdAsync(id));
            LogInformation($"Successfully fetched the entity with the id: {id}.");

            return tmpEntity;
        }
        catch (Exception ex)
        {
            LogError($"Failed to fetch the entity with the id: {id}.", ex);
            return null;
        }
    }
}