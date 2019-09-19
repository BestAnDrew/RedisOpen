using System;
using StackExchange.Redis;

namespace RedisPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionMultiplexer redisCon = ConnectionMultiplexer.Connect("localhost");


            IDatabase db = redisCon.GetDatabase();


            db.StringSet("foo","bar");

            String val = db.StringGet("foo");

            Console.WriteLine(val);
        }
    }
}
