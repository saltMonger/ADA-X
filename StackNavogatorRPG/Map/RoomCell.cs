using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenAgentBased
{

    public enum Direction
    {
        None,
        North,
        West,
        South,
        East
    }

    //Physical room
    public class RoomCell
    {
        public RoomCell North { get; set; }
        public RoomCell West { get; set; }
        public RoomCell South { get; set; }
        public RoomCell East { get; set; }

        public int[] RoomCoords
        {
            get;
            set;
        }

        public Treasure Treasure { get; set; }
        public Statue Statue { get; set; }

        //NEED TO ACTUALLY IMPLEMENT THE IMAGE
        public int Image { get; set; }

        public bool Visited;
        public bool Boss;


        //Image of room is based off of heading and doors within room
        //It is represented as a BYTE
        // 00 - 00
        // Bottom is the player heading
        // Top are the doors present within RoomCell
        public byte AssignRoomCellImage(Direction fromRoom)
        {
            byte roomLookup = 0x00;

            //ASSIGN BOTTOM OF BYTE
            switch (fromRoom)
            {
                //BIN   HEX     HUMAN
                //0000  0       NO HEADING
                //0001  1       NORTH
                //0010  2       EAST
                //0100  4       SOUTH
                //1000  8       WEST
                case Direction.North: roomLookup = 0x01; break;
                case Direction.East: roomLookup = 0x02; break;
                case Direction.South: roomLookup = 0x04; break;
                case Direction.West: roomLookup = 0x08; break;
            }

            //ASSIGN TOP OF BYTE
            //BIN   HEX     HUMAN
            //0000  0       No Door Exists (should not happen)
            //0001  1       North Door
            //0010  2       East Door
            //0100  4       South Door
            //1000  8       West Door
            if(North != null)
            {
                roomLookup |= 0x10;
            }
            if(East != null)
            {
                roomLookup |= 0x20;
            }
            if (South != null)
            {
                roomLookup |= 0x40;
            }
            if(West != null)
            {
                roomLookup |= 0x80;
            }

            //do image lookup here
            //01010001

            return roomLookup;
        }



    }


    //dummy classes
    public class Treasure
    {

    }

    public class Statue
{

}
}
