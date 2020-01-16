using Microsoft.OpenApi.Models;

namespace WebApplication2
{
    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}