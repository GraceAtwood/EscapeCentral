using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace EscapeCentral
{
    public static class GameManager
    {

        public static ConcurrentBag<GameDef.Game> Games = new ConcurrentBag<GameDef.Game>();

    }
}
