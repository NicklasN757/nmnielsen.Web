using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using nmnielsen.Service.DataTransferObjects;
using nmnielsen.Service.Interfaces;

namespace nmnielsen.Web.Pages.Project.ProjectGRUD
{
    public class ProjectDeleteModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        public ProjectDeleteModel(IUserService userService, IProjectService projectService)
        {
            _userService = userService;
            _projectService = projectService;
        }

        public ProjectDTO Project { get; set; }
        public async Task<IActionResult> OnGet(int projectId)
        {
            if (!await _userService.CheckUserPermission("NMNielsen:update"))
            {
                return RedirectToPage("../ProjectDetails", new { ProjectId = projectId });
            }

            Project = await _projectService.GetByIdAsync(projectId);

            return Page();
        }
    }
}