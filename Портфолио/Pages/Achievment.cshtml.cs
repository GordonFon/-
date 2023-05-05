using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Портфолио.Pages
{
    public class AchievmentModel : PageModel
    {
        private readonly ILogger<AchievmentModel> _logger;

        public AchievmentModel(ILogger<AchievmentModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}