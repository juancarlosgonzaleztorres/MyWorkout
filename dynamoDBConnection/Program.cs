using Amazon.DynamoDBv2;
using System;

namespace dynamoDBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new AmazonDynamoDBConfig
            {
                ServiceURL = "http://localhost:0/"
            };

            // Access key and secret key are not required
            // when connecting to DynamoDB Local and
            // are left empty in this sample.
            var client = new AmazonDynamoDBClient("", "", config);
            
            Console.WriteLine("Hello Dynamodb!");
        }
    }
}
