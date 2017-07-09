using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeCentral.Persistence
{
    public static class Loader
    {
        private static IEnumerable<string> GetGameDefFiles()
        {
            var str = Directory.GetCurrentDirectory();
            var files = Directory.GetFiles("Defs");

            foreach (var file in files)
            {
                var info = new FileInfo(file);

                if (info.Extension == ".game" && info.Name.Contains("GameDef_"))
                {
                    yield return info.FullName;
                }
            }
        }

        public static IEnumerable<GameDef.Game> LoadAll()
        {
            if (!Directory.Exists("Defs"))
            {
                Directory.CreateDirectory("Defs");
            }
            
            foreach (var file in GetGameDefFiles())
            {
                var rawText = File.ReadAllText(file);
                var game = JsonConvert.DeserializeObject<GameDef.Game>(rawText, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    NullValueHandling = NullValueHandling.Ignore
                });
                yield return game;
            }
        }
    }
}
