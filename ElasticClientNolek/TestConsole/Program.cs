using Library;
using Library.Models;
using System.IO;

var path = "F:\\Nolek mock data\\Marcus-Test-Data";
var result = new List<TestResult>();

if (Directory.Exists(path))
{
    var files = Directory.GetFiles(path);
	foreach (var file in files)
	{
        var csvData = CsvService.ImportDataFromCsv<TestData>(file);
		foreach (var item in csvData)
		{
			result.Add(new TestResult(item));
		}
	}
}

ElasticClient.Instance.IndexData(result);

//ElasticClient.Instance.TestDataIndex();
//await ElasticClient.Instance.TestDataIndex2();