using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PostComment;

namespace Lab12.Posts
{
    public class CreateModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PostDto Post { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var client = new PostCommentServiceClient();
            await client.AddPostAsync(Post);
            return RedirectToPage("./Index");
        }
    }
}
