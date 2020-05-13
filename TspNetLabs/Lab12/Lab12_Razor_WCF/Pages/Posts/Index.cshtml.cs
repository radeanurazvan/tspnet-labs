using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PostComment;

namespace Lab12.Posts
{
    public class IndexModel : PageModel
    {

        public IList<PostDto> Posts { get;set; }

        public async Task OnGetAsync()
        {
            var client = new PostCommentServiceClient();
            Posts = await client.GetPostsAsync();
        }
    }
}
