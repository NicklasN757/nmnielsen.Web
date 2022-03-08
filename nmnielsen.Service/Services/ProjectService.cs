using nmnielsen.Repository.Entities;
using nmnielsen.Repository.Interfaces;
using nmnielsen.Service.DataTransferObjects;
using nmnielsen.Service.Interfaces;

namespace nmnielsen.Service.Services;
public class ProjectService : GenericService<ProjectDTO, IProjectRepository, Project>, IProjectService
{
    private readonly MappingService _mappingService;
    private readonly IProjectRepository _projectRepository;
    public ProjectService(MappingService mappingService, IProjectRepository projectRepository) : base(mappingService, projectRepository)
    {
        _mappingService = mappingService;
        _projectRepository = projectRepository;
    }

    //Calls and logs the "GetAllNotHidden" function from the ProjectRepository
    public async Task<List<ProjectDTO>> GetAllNotHidden()
    {
        try
        {
            List<ProjectDTO> tmpList = _mappingService._mapper.Map<List<ProjectDTO>>(await _projectRepository.GetAllNotHidden());

            LogInformation($"Successfully fetched a list of projects.");

            return tmpList;
        }
        catch (Exception ex)
        {
            LogError($"Failed to fetch a list of projects.", ex);

            return new List<ProjectDTO>();
        }
    }
}