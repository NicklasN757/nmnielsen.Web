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
        _projectRepository = projectRepository;
        _mappingService = mappingService;
    } 
}