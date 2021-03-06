﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using AspNetCoreDemo;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
	        var host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<Startup>()
            .UseContentRoot()
            .UseUrls("http://localhost:8080")
            .Build();	

            host.Run();      
        }
    }
}
