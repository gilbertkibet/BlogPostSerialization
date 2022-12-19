using Newtonsoft.Json;
using System;
using System.IO;

namespace BlogPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* SERIALIZING OBJECT
            var blogPost = new BlogPost("6666098")
            {
                Title = "This is serialization",
                Body = "Oh my god am serializing obj in c#",
                Author = "Gilbert Proud",
                IsPublic = false,
                PublishDate = DateTime.Now
            };

            var serializedBlogPost = JsonConvert.SerializeObject(blogPost);
            */

            //DESERIALIZING JSON TO OBJECT
            //READING JSON
            var blogpostjson = File.ReadAllText(@"C:\Users\Admin\Desktop\blogpost.json");

            //deserialized

            var myobjBlogpost = JsonConvert.DeserializeObject(blogpostjson);
        }
    }
    public class BlogPost
    {
        public BlogPost(string id)
        {
            _id = id;
        }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public bool IsPublic { get; set; }
        [JsonIgnore] //IGNORE DATE IN THE JSON
        public DateTime PublishDate { get; set; }
        [JsonRequired]
        private readonly string _id;

    }



}
