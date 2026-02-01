using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace http_practice.Services
{
    internal class PostsService
    {
        private readonly HttpClient _http;

        public PostsService()
        {
            _http = ApiClient.Instance;
        }

        public async Task<List<PostDto>> GetAllAsync()
        {
            try
            {
                return await _http.GetFromJsonAsync<List<PostDto>>("/api/posts");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error HTTP request: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error get all posts: {ex.Message}");
                throw;
            }
        }

        public async Task<HttpResponseMessage> CreateAsync(PostDto post)
        {
            try
            {
                return await _http.PostAsJsonAsync<PostDto>("/api/posts", post);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error HTTP request: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error get all posts: {ex.Message}");
                throw;
            }
        }
    }
}
