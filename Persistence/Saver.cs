using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeCentral.Persistence
{
    public static class Saver
    {

        public static void SaveGameDefs(IEnumerable<GameDef.Game> games)
        {
            if (!Directory.Exists("Defs"))
            {
                Directory.CreateDirectory("Defs");
            }

            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new Newtonsoft.Json.Converters.JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.TypeNameHandling = TypeNameHandling.Auto;
            serializer.Formatting = Formatting.Indented;

            foreach (var game in games)
            {
                using (StreamWriter sw = new StreamWriter("Defs/GameDef_" + game.Id + ".game"))
                {
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, game, game.GetType());
                    }
                }
            }

        }

    }
}
