using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Core;
using Generic;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreRepository2
{
    public class ExcerciseRepositoryDynamoDB:ICRUD<Core.Excercise>
    {
        DynamoDBContext context;
        public ExcerciseRepositoryDynamoDB(IAmazonDynamoDB client)
        {
            context = new DynamoDBContext(client);
        }

        public int Create(Core.Excercise item)
        {
            throw new System.NotImplementedException();
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
    }
}
