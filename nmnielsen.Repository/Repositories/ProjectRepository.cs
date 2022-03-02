using nmnielsen.Repository.Domain;
using nmnielsen.Repository.Entities;
using nmnielsen.Repository.Interfaces;

namespace nmnielsen.Repository.Repositories;
public class ProjectRepository : GenericRepository<Project>, IProjectRepository
{
    private readonly NmnielsenContext _dbContext;
    public ProjectRepository(NmnielsenContext nmnielsenContext) : base(nmnielsenContext) => _dbContext = nmnielsenContext; 
}