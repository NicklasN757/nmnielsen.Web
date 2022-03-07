using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace nmnielsen.Web.Pages.Account
{
    public class LoginModel : PageModel
    {
        public async Task OnGetAsync()
        {
            var authenticationProperties = new LoginAuthenticationPropertiesBuilder().WithRedirectUri("/").Build();
            await HttpContext.ChallengeAsync(Auth0Constants.AuthenticationScheme, authenticationProperties);
        }
    }
}