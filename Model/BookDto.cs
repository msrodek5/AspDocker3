using Newtonsoft.Json;

namespace AspDocker3.Model
{
    public class BooksDto
    {
        [JsonProperty("id")]
        public int Id
        { get; set; }

        [JsonProperty("title")]
        public string Title
        { get; set; }
    }
}
