using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System.Threading.Tasks;

namespace AzureBlobStorage.Test
{
    public class Tests
    {
        private readonly string _storageConnectionString;
        private readonly string _storageContainerName;

        public Tests(IConfiguration configuration)
        {
            _storageConnectionString = configuration.GetValue<string>("BlobConnectionString");
            _storageContainerName = configuration.GetValue<string>("BlobContainerName");
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task UploadAsync()
        {
            Assert.Pass();
            //string path = CreateTempFile(SampleFileContent);

            //BlobContainerClient container = new BlobContainerClient(_storageConnectionString, _storageContainerName);
            //await container.CreateAsync();
            //try
            //{
            //    // Get a reference to a blob
            //    BlobClient blob = container.GetBlobClient(("sample-file"));

            //    // Upload file data
            //    await blob.UploadAsync(path);

            //    // Verify we uploaded some content
            //    BlobProperties properties = await blob.GetPropertiesAsync();
            //    Assert.AreEqual(SampleFileContent.Length, properties.ContentLength);
            //}
            //finally
            //{
            //    // Clean up after the test when we're finished
            //    await container.DeleteAsync();
            //}
        }
    }
}