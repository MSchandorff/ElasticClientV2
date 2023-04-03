using Elastic.Clients.Elasticsearch;
using Elastic.Transport;

namespace Library
{
    public class ElasticClient
    {
        private static readonly ElasticClient _instance = new ElasticClient();
        private ElasticClient()
        {
            if (_client == null)
            {
                var settings = new ElasticsearchClientSettings(new Uri("https://localhost:9200"));

                _client = new ElasticsearchClient(settings);
            }
        }

        public static ElasticClient Instance { get { return _instance; } }
        public ElasticsearchClient _client { get; set; }


        public async Task TestDataIndex()
        {
            var data = new TestData
            {
                StringProperty = "value123"
            };

            var Response = await _client
                .IndexAsync(document, "my-document-index");

            //if (Response.IsValidResponse)
            //{
            //    Console.WriteLine($"Index document with ID {indexResponse.Id} succeeded.");
            //}
        }
    }
}
