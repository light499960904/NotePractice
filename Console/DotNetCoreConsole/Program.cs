﻿using System;

namespace DotNetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisDemo();
        }

        private static void RedisDemo()
        {
            RedisHelper redisHelper = new RedisHelper("127.0.0.1:6379");
            string value = "abcdefg";
            bool r1 = redisHelper.SetValue("mykey", value);
            string saveValue = redisHelper.GetValue("mykey");
            bool r2 = redisHelper.SetValue("mykey", "NewValue");
            saveValue = redisHelper.GetValue("mykey");
            bool r3 = redisHelper.DeleteKey("mykey");
            string uncacheValue = redisHelper.GetValue("mykey");
        }
    }
}
