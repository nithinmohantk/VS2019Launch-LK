using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp8
{
    public class AsyncStreams
    {
        private readonly string[] _conferences = {
            "Letterkenny",
            "Dublin",
            "Belfast",
            "MSOpenHack",
            ".NET Conf",
            "Microsoft Ireland",
            "MSCommunity",
            "CrisCon",
            "SharePoint Saturday",
            "Azure Thursdays",
            "Thrive",
            "SQLSaturday"
        };

        private async IAsyncEnumerable<string> GetConferencesAsync()
        {
            foreach (var conference in _conferences)
            {
                await Task.Delay(100);
                yield return conference;
            }
        }

        public async Task WriteConferences()
        {
            await foreach (var conference in GetConferencesAsync())
            {
                Console.WriteLine(conference);
            }
        }
    }
}
