using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using nmnielsen.Service.DataTransferObjects;
using nmnielsen.Service.Interfaces;

namespace nmnielsen.Web.Pages.Project;

public class ProjectListModel : PageModel
{
    private readonly IProjectService _projectService;
    public ProjectListModel(IProjectService projectService) => _projectService = projectService;

    public List<ProjectDTO> Projects { get; set; }

    public async Task<IActionResult> OnGet()
    {
        Projects = await _projectService.GetAllAsync();

        return Page();
    }
}