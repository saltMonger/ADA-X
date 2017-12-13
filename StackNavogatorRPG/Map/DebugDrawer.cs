using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenAgentBased
{

    public class DebugDrawer
    {
        public int MapSizeX { get; set; }
        public int MapSizeY { get; set; }
        public RoomCell[,] Map { get; set; }


        public void DrawMap()
        {
            Stopwatch sw = new Stopwatch();
            DiggerAgent digger = new DiggerAgent(25, 25, 3);

            sw.Start();
            digger.DigMap();
            Map = digger.RoomCells;
            sw.Stop();

            MapSizeX = digger.MapSizeX;
            MapSizeY = digger.MapSizeY;

            for (int x = 0; x < MapSizeX; x++)
            {
                for (int y = 0; y < MapSizeY; y++)
                {
                    //check directions and accumulate a connect number
                    int numConnections = 0;

                    if(Map[x, y] == null)
                    {
                        Console.Write(" ");
                        continue;
                    }

                    if (Map[x, y].North != null)
                    {
                        numConnections += 1;
                    }
                    if (Map[x, y].East != null)
                    {
                        numConnections += 1;
                    }
                    if (Map[x, y].West != null)
                    {
                        numConnections += 1;
                    }
                    if (Map[x, y].South != null)
                    {
                        numConnections += 1;
                    }
                    Console.Write(numConnections);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Map gen time: " + sw.ElapsedMilliseconds);
            MapCharter mapchart = new MapCharter(Map, MapSizeX, MapSizeY);
            mapchart.ChartMap();

        }
    }
}
