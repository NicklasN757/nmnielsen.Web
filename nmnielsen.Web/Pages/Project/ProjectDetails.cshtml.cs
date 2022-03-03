using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using nmnielsen.Service.DataTransferObjects;
using nmnielsen.Service.Interfaces;

namespace nmnielsen.Web.Pages.Project;

public class ProjectDetailsModel : PageModel
{
    IProjectService _projectService;
    public ProjectDetailsModel(IProjectService projectService) => _projectService = projectService;

    public ProjectDTO Project { get; set; }

    public async Task<IActionResult> OnGet(int projectId)
    {
        Project = await _projectService.GetByIdAsync(projectId);

        return Page();
    }
}
