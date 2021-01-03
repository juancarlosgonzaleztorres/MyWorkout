using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Core;
using Generic;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreRepository2
{
    public sealed class ExcerciseRepositoryDynamoDB:ICRUD<Core.Excercise>, System.IDisposable
    {
        private const string Excercises = "Excercises";
        DynamoDBContext context;
        //AmazonDynamoDBClient client;
        public ExcerciseRepositoryDynamoDB(IAmazonDynamoDB client)
        {
            
        }

        public async Task<int> CreateAsync(Core.Excercise item)
        {
            var dynamoDBConfig = new AmazonDynamoDBConfig();
            dynamoDBConfig.ServiceURL = "http://localhost:8000/";
            var client = new AmazonDynamoDBClient(dynamoDBConfig);

            var tables = await client.ListTablesAsync();
            var currentTables = tables.TableNames;
            if (!currentTables.Contains(Excercises))
            {
                var request = new CreateTableRequest
                {
                    TableName = Excercises,
                    AttributeDefinitions = new List<AttributeDefinition>
                      {
                        new AttributeDefinition
                        {
                          AttributeName = "Id",
                          AttributeType = "N"
                        },
                        new AttributeDefinition
                        {
                          AttributeName = "Name",
                          AttributeType = "S"
                        }
                      },
                    KeySchema = new List<KeySchemaElement>
                  {
                    new KeySchemaElement
                    {
                      AttributeName = "Id",
                      KeyType = "HASH"
                    },
                    new KeySchemaElement
                    {
                      AttributeName = "Name",
                      KeyType = "RANGE"
                    },
                  },
                    ProvisionedThroughput = new ProvisionedThroughput
                    {
                        ReadCapacityUnits = 10,
                        WriteCapacityUnits = 5
                    },
                };
                
                var response = await client.CreateTableAsync(request,new System.Threading.CancellationToken());
            }

            Table excerciseCatalog = Table.LoadTable(client, Excercises);
            var excercise = new Document();
            excercise["Id"] = item.Id;
            excercise["Name"] = item.Name;
            var excerciseEntry = await excerciseCatalog.PutItemAsync(excercise);
            return 1;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Core.Excercise Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id)
        {
            throw new System.NotImplementedException();
        }

        int ICRUD<Core.Excercise>.Create(Core.Excercise item)
        {
            return CreateAsync(item).Result;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public List<Core.Excercise> Read()
        {
            throw new System.NotImplementedException();
        }
    }
}
