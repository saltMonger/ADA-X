using System;
using MapGenAgentBased;

namespace StackNavogatorRPG.Map
{
    public class MapManager
    {

        public RoomCell[,] Map
        {
            get;
            set;
        }

        public int[2] PlayerCoords
        {
            get;
            set;
        }

        public MapManager()
        {
            
        }



        public void GenMap()
        {
            DiggerAgent da = new DiggerAgent(25,25, 3);
            da.DigMap();
            Map = da.RoomCells;
        }
    }
}
