using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PostComment;

namespace Lab12.Posts
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public PostDto Post { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = new PostCommentServiceClient();
            Post = (await client.GetPostsAsync()).SingleOrDefault(p => p.Id == id);

            if (Post == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = new PostCommentServiceClient();
            Post = (await client.GetPostsAsync()).SingleOrDefault(p => p.Id == id);

            if (Post != null)
            {
                await client.DeletePostAsync(id.Value);
            }

            return RedirectToPage("./Index");
        }
    }
}
