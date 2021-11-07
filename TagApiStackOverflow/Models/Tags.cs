using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TagApiStackOverflow.Models
{
    public class Tags
    {
        public int Id { get; set; }
        public int Popularity { get; set; }
        public decimal Usage { get; set; }
    }
    public class StackOverFlowClient
    {
        public StackOverFlowClient(HttpClient client)
        {
            // client.BaseAddress is "https://api.github.com"
        }
    }
    public class TagsRepository : ITagsRepository
    {
        public Tags GetTag(int id)
        {
            // put logic in here
        }
    }
}
