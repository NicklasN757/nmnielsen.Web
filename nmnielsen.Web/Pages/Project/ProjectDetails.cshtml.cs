using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using nmnielsen.Service.DataTransferObjects;
using nmnielsen.Service.Interfaces;

namespace nmnielsen.Web.Pages.Project;

public class ProjectDetailsModel : PageModel
{
    private readonly IUserService _userService;
    private readonly IProjectService _projectService;
    public ProjectDetailsModel(IUserService userService, IProjectService projectService)
    {
        _userService = userService;
        _projectService = projectService;
    }

    public ProjectDTO Project { get; set; }

    // Acces control
    public bool CanEdit { get; set; }
    public bool CanDelete { get; set; }

    public async Task<IActionResult> OnGet(int projectId)
    {
        CanEdit = await _userService.CheckUserPermission("NMNielsen:update");
        CanDelete = await _userService.CheckUserPermission("NMNielsen:delete");

        Project = await _projectService.GetByIdAsync(projectId);

        return Page();
    }
}
