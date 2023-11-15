using Microsoft.AspNetCore.Mvc;
using ViewComponent_MVC.Models;

namespace ViewComponent_MVC.ViewComponents
{
    public class CommentViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new List<CommentViewModel>
            {
                new CommentViewModel
                {
                    CommentBy = "Fatih",
                    Comment = "Bugün hiç uykum yok. Enerjim top seviyede!",
                    CommentTime = DateTime.Now
                },
                new CommentViewModel
                {
                    CommentBy = "Gürkan",
                    Comment = "Bugün çok güzel bir gün.",
                    CommentTime = DateTime.Now.AddDays(-2)
                },
                new CommentViewModel
                {
                    CommentBy = "Hüseyin",
                    Comment = "Bugün kendimi çok yalnız hissediyorum",
                    CommentTime = DateTime.Now.AddDays(-7)
                }
            };

            return View(model);
        }
    }
}
