using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreRepository2
{
    [DynamoDBTable("Excercise")]
    public class Excercise
    {
        [DynamoDBHashKey]
        public int Id { get; set; }
        public string Name { get; set; }
        // Additional properties go here. 
    }
}
