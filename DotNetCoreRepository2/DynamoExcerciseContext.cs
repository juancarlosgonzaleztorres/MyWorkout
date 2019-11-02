using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Core;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreRepository2
{
    public class DynamoDBExcerciseContext : DynamoDBContext
    {
        public DynamoDBExcerciseContext(IAmazonDynamoDB client):base(client)
        {

        }
    }
}
