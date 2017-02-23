using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Files
    {
        public static void Main()
        {
            var filesByRoot = new Dictionary<string, Dictionary<string, long>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var rootedParams = Console.ReadLine().Split('\\');
                var root = rootedParams[0];
                var fileWithSize = rootedParams[rootedParams.Length - 1].Split(';');
                var fileNameWithExtension = fileWithSize[0];
                var fileSize = long.Parse(fileWithSize[1]);

                if (!filesByRoot.ContainsKey(root))
                {
                    filesByRoot.Add(root, new Dictionary<string, long>());

                }
                if (!filesByRoot[root].ContainsKey(fileNameWithExtension))
                {
                    filesByRoot[root].Add(fileNameWithExtension, fileSize);
                }
                else
                {
                    filesByRoot[root][fileNameWithExtension] = fileSize;
                }
            

            }
            var queryParams = Console.ReadLine().Split(' ');
            var queryExtension = queryParams[0];
            var queryRoot = queryParams[2];
            if (filesByRoot.ContainsKey(queryRoot))
            {
                var foundFiles = filesByRoot[queryRoot];

                foreach (var file in foundFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (file.Key.EndsWith(queryExtension))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
