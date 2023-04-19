using Elastic.Clients.Elasticsearch;
using Elastic.Transport;
using Library.Models;

namespace Library
{
    public class ElasticClient
    {
        private static readonly ElasticClient _instance = new ElasticClient();
        private ElasticClient()
        {
            if (_client == null)
            {
                var settings = new ElasticsearchClientSettings(new Uri("http://localhost:9200"));

                _client = new ElasticsearchClient(settings);
            }
        }

        public static ElasticClient Instance { get { return _instance; } }
        public ElasticsearchClient _client { get; set; }


        public void TestDataIndex()
        {
            var data = new List<TestData>()
            {
                //new TestData
                //{
                //Id = 1,
                //LogTime = DateTime.Now,
                //StepNo = 1400,
                //CircuitName = "R1.1",
                //TMP1 = 20.38,
                //TMP2 = 20.06,
                //B31 = 19.90909,
                //B32 = 19.80357,
                //B21 = 19.73058,
                //B22 = 20.0036,
                //P101 = 173.0111,
                //RegulatorSP = 20,
                //RegulatorFB = 0
                //}
            };

            var Response = _client
                .Bulk(b => b.Index("test2").IndexMany<TestData>(data));

            if (!Response.IsValidResponse)
            {
                // Handle errors
                var debugInfo = Response.DebugInformation;
                var error = Response.ElasticsearchServerError.Error;
            }
        }

        public void IndexData(List<TestResult> data)
        {
            var response = _client
                .Bulk(b => b.Index("test2").IndexMany<TestResult>(data));

            if (!response.IsValidResponse)
            {
                var debugInfo = response.DebugInformation;
                var error = response.ElasticsearchServerError.Error;
            }
        }
    }
}
