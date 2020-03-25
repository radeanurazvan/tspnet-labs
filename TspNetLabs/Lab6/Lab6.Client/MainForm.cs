using System;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Windows.Forms;
using Lab6.Wcf.Contracts;

namespace Lab6.Client
{
    public partial class MainForm : Form
    {
        private readonly PostCommentServiceClient client;

        public MainForm()
        {
            client = new PostCommentServiceClient();
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            LoadPosts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.AddPost(new PostDto
            {
                Description = textBox1.Text,
                Domain = "Hardcoded Domain"
            });

            listBox1.Items.Clear();
            LoadPosts();
        }

        private void LoadPosts()
        {
            var posts = client.GetPosts();
            listBox1.Items.AddRange(posts.Select(p => new MyPost {Description = p.Description}).ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private sealed class MyPost
        {
            public string Description { get; set; }

            public override string ToString() => Description;
        }
    }
}
