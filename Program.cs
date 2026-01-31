using http_practice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace http_practice
{
    internal class Program
    {
        private static UserService _userService;
        private static PostsService postsService;

        static async Task Main(string[] args)
        {
            _userService = new UserService();
            _postsService = new PostsService();

            var users = await _userService.GetAllAsync();
            var posts = await _postsService.GetAllAsync();

            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.Id}");
                Console.WriteLine($"Username: {user.Username}");
                Console.WriteLine($"Email: {user.Email}");
            }
            foreach(var post in posts)
            {
                Console.WriteLine($"ID: {post.Id}");
                Console.WriteLine($"Title: {post.Title}");
                Console.WriteLine($"Content: {post.Content}");
            }
        }
    }
}
