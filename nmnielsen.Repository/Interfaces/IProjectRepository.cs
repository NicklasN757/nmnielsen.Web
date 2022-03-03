using nmnielsen.Repository.Entities;

namespace nmnielsen.Repository.Interfaces;
public interface IProjectRepository : IGenericRepository<Project>
{
    /// <summary>
    /// Gets all projects thats not marked as hidden
    /// </summary>
    /// <returns>A list of project that not hidden</returns>
    Task<List<Project>> GetAllNotHidden();
}