using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PostComment;

namespace Lab12.Posts
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public string Comment { get; set; }

        public PostDto Post { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = new PostCommentServiceClient();
            var posts = await client.GetPostsAsync();
            Post = posts.SingleOrDefault(p => p.Id == id);

            if (Post == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var id = (string)Request.RouteValues["id"];
            if (!Guid.TryParse(id, out var postId))
            {
                return RedirectToPage("./Index");
            }

            var client = new PostCommentServiceClient();
            await client.AddPostCommentAsync(postId, new CommentDto {Text = Comment});
            return RedirectToPage();
        }
    }
}
