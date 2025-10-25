# FuckOfAsAService.cs
Web-API for [foaas.com](https://foass.1001010.com/) an website that provides a modern, RESTful, scalable solution to the common problem of telling people to fuck off

## Example
```cs
using System;
using FuckOfAsAServiceApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new FuckOfAsAService();
            string version = await api.GetVersion();
            Console.WriteLine(version);
        }
    }
}
```
