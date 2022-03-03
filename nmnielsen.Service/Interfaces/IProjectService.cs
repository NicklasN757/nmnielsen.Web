using nmnielsen.Service.DataTransferObjects;

namespace nmnielsen.Service.Interfaces;
public interface IProjectService : IGenericService<ProjectDTO>
{
    /// <summary>
    /// Gets all projects thats not marked as hidden
    /// </summary>
    /// <returns>A list of project that not hidden</returns>
    Task<List<ProjectDTO>> GetAllNotHidden();
}