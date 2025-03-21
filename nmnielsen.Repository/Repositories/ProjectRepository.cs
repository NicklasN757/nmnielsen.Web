﻿using Microsoft.EntityFrameworkCore;
using nmnielsen.Repository.Domain;
using nmnielsen.Repository.Entities;
using nmnielsen.Repository.Interfaces;

namespace nmnielsen.Repository.Repositories;
public class ProjectRepository : GenericRepository<Project>, IProjectRepository
{
    private readonly NMNielsenContext _dbContext;
    public ProjectRepository(NMNielsenContext nmnielsenContext) : base(nmnielsenContext) => _dbContext = nmnielsenContext;

    //Gets all projects thats not marked as hidden
    public Task<List<Project>> GetAllNotHidden() => _dbContext.Projects.Where(p => !p.IsHidden).ToListAsync();
}