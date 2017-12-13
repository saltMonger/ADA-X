using System;
using MapGenAgentBased;

namespace StackNavogatorRPG.Map
{
    public class MapManager
    {
        private static MapManager _instance;

        public RoomCell[,] Map
        {
            get;
            set;
        }

        public int MapSizeX
        {
            get;
            set;
        }

        public int MapSizeY
        {
            get;
            set;
        }

        public int[] PlayerCoords
        {
            get;
            set;
        }

        private MapManager()
        {
            PlayerCoords = new int[2];
        }

        public static MapManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MapManager();
                }
                return _instance;
            }
        }

        public VC_DungeonRoom GetFirstRoom(){
            //set room settings
            byte roomDesc = Map[PlayerCoords[0], PlayerCoords[1]].AssignRoomCellImage(Direction.North);

            VC_DungeonRoom nRoom = new VC_DungeonRoom();
            nRoom.rc = Map[PlayerCoords[0], PlayerCoords[1]];

            switch (roomDesc)
            {
                case 0x11:
                    nRoom.TopButtonDuty = Direction.North; break;
                case 0x21:
                    nRoom.RightButtonDuty = Direction.East; break;
                case 0x31:
                    nRoom.TopButtonDuty = Direction.North;
                    nRoom.RightButtonDuty = Direction.East; break;
                case 0x41:
                    nRoom.BottomButtonDuty = Direction.South; break;
                case 0x51:
                    nRoom.TopButtonDuty = Direction.North;
                    nRoom.BottomButtonDuty = Direction.South;
                    break;
                case 0x61:
                    nRoom.RightButtonDuty = Direction.East;
                    nRoom.BottomButtonDuty = Direction.South;
                    break;
                case 0x71:
                    nRoom.TopButtonDuty = Direction.North;
                    nRoom.BottomButtonDuty = Direction.South;
                    nRoom.RightButtonDuty = Direction.East;
                    break;
                case 0x81:
                    nRoom.LeftButtonDuty = Direction.West;
                    break;
                case 0x91:
                    nRoom.TopButtonDuty = Direction.North;
                    nRoom.LeftButtonDuty = Direction.West;
                    break;
                case 0xA1:
                    nRoom.LeftButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.East;
                    break;
                case 0xB1:
                    nRoom.TopButtonDuty = Direction.North;
                    nRoom.LeftButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.East;
                    break;
                case 0xC1:
                    nRoom.BottomButtonDuty = Direction.South;
                    nRoom.LeftButtonDuty = Direction.West;
                    break;
                case 0xD1:
                    nRoom.LeftButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.East;
                    nRoom.TopButtonDuty = Direction.North;
                    break;
                case 0xE1:
                    nRoom.LeftButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.East;
                    nRoom.BottomButtonDuty = Direction.South;
                    break;
                case 0xF1:
                    nRoom.TopButtonDuty = Direction.North;
                    nRoom.BottomButtonDuty = Direction.South;
                    nRoom.LeftButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.East;
                    break;
                case 0x82: //EAST heading
                    nRoom.BottomButtonDuty = Direction.West;
                    break;
                case 0x92:
                    nRoom.LeftButtonDuty = Direction.North;
                    nRoom.BottomButtonDuty = Direction.West;
                    break;
                case 0xA2:
                    nRoom.BottomButtonDuty = Direction.West;
                    nRoom.TopButtonDuty = Direction.East;
                    break;
                case 0xB2:
                    nRoom.BottomButtonDuty = Direction.West;
                    nRoom.LeftButtonDuty = Direction.North;
                    nRoom.TopButtonDuty = Direction.East;
                    break;
                case 0xC2:
                    nRoom.BottomButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.South;
                    break;
                case 0xD2:
                    nRoom.BottomButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.South;
                    nRoom.LeftButtonDuty = Direction.North;
                    break;
                case 0xE2:
                    nRoom.BottomButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.South;
                    nRoom.TopButtonDuty = Direction.East;
                    break;
                case 0xF2:
                    nRoom.BottomButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.South;
                    nRoom.TopButtonDuty = Direction.East;
                    nRoom.LeftButtonDuty = Direction.North;
                    break;
                case 0x14:
                    nRoom.BottomButtonDuty = Direction.North;
                    break;
                case 0x34:
                    nRoom.BottomButtonDuty = Direction.North;
                    nRoom.LeftButtonDuty = Direction.East;
                    break;
                case 0x54:
                    nRoom.BottomButtonDuty = Direction.North;
                    nRoom.TopButtonDuty = Direction.South;
                    break;
                case 0x74:
                    nRoom.BottomButtonDuty = Direction.North;
                    nRoom.TopButtonDuty = Direction.South;
                    nRoom.LeftButtonDuty = Direction.East;
                    break;
                case 0x94:
                    nRoom.BottomButtonDuty = Direction.North;
                    nRoom.RightButtonDuty = Direction.West;
                    break;
                case 0xB4:
                    nRoom.BottomButtonDuty = Direction.North;
                    nRoom.RightButtonDuty = Direction.West;
                    nRoom.LeftButtonDuty = Direction.East;
                    break;
                case 0xD4:
                    nRoom.BottomButtonDuty = Direction.North;
                    nRoom.TopButtonDuty = Direction.South;
                    nRoom.RightButtonDuty = Direction.West;
                    break;
                case 0xF4:
                    nRoom.BottomButtonDuty = Direction.North;
                    nRoom.TopButtonDuty = Direction.South;
                    nRoom.RightButtonDuty = Direction.West;
                    nRoom.LeftButtonDuty = Direction.East;
                    break;
                case 0x28: //WEST heading
                    nRoom.BottomButtonDuty = Direction.East;
                    break;
                case 0x38:
                    nRoom.BottomButtonDuty = Direction.East;
                    nRoom.RightButtonDuty = Direction.North;
                    break;
                case 0x68:
                    nRoom.BottomButtonDuty = Direction.East;
                    nRoom.LeftButtonDuty = Direction.South;
                    break;
                case 0x78:
                    nRoom.BottomButtonDuty = Direction.East;
                    nRoom.RightButtonDuty = Direction.North;
                    nRoom.LeftButtonDuty = Direction.South;
                    break;
                case 0xA8:
                    nRoom.BottomButtonDuty = Direction.East;
                    nRoom.TopButtonDuty = Direction.West;
                    break;
                case 0xB8:
                    nRoom.BottomButtonDuty = Direction.East;
                    nRoom.TopButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.North;
                    break;
                case 0xE8:
                    nRoom.BottomButtonDuty = Direction.East;
                    nRoom.TopButtonDuty = Direction.West;
                    nRoom.LeftButtonDuty = Direction.South;
                    break;
                case 0xF8:
                    nRoom.BottomButtonDuty = Direction.East;
                    nRoom.TopButtonDuty = Direction.West;
                    nRoom.LeftButtonDuty = Direction.South;
                    nRoom.RightButtonDuty = Direction.North;
                    break;
            }

            return nRoom;
        }

        public void GenMap()
        {
            DiggerAgent da = new DiggerAgent(25,25, 3);
            da.DigMap();
            Map = da.RoomCells;
            MapSizeX = da.MapSizeX;
            MapSizeY = da.MapSizeY;
            //need to read back player coords
            PlayerCoords = da.PlayerStartLocation;


        }

        public void WriteMap(){
            MapCharter charter = new MapCharter(Map, MapSizeX, MapSizeY);
            charter.ChartMap();
        }

        //Manipulates MapManager's player coords, effectively moving the player through the map
        //Calls RoomCell's AssignRoomCellImage on the destination cell
        //After load, rng decides if an encounter is happening
        //Also, builds and returns the view controller to the calling vc
        public VC_DungeonRoom MoveRoom(Direction direction){
            //calculate the movement between rooms
            switch(direction){
                case Direction.North: PlayerCoords[1] -= 1; break;
                case Direction.South: PlayerCoords[1] += 1; break;
                case Direction.East: PlayerCoords[0] += 1; break;
                case Direction.West: PlayerCoords[0] -= 1; break;
            }

            //"enter" roomcell by deciding image and doors
            //get back the 
            byte roomDesc = Map[PlayerCoords[0], PlayerCoords[1]].AssignRoomCellImage(direction);

            VC_DungeonRoom nRoom = new VC_DungeonRoom();
            nRoom.rc = Map[PlayerCoords[0], PlayerCoords[1]];

            switch (roomDesc)
            {
                case 0x11:
                    nRoom.TopButtonDuty = Direction.North; break;
                case 0x21:
                    nRoom.RightButtonDuty = Direction.East; break;
                case 0x31:
                    nRoom.TopButtonDuty = Direction.North;
                    nRoom.RightButtonDuty = Direction.East; break;
                case 0x41:
                    nRoom.BottomButtonDuty = Direction.South; break;
                case 0x51:
                    nRoom.TopButtonDuty = Direction.North;
                    nRoom.BottomButtonDuty = Direction.South;
                    break;
                case 0x61:
                    nRoom.RightButtonDuty = Direction.East;
                    nRoom.BottomButtonDuty = Direction.South;
                    break;
                case 0x71:
                    nRoom.TopButtonDuty = Direction.North;
                    nRoom.BottomButtonDuty = Direction.South;
                    nRoom.RightButtonDuty = Direction.East;
                    break;
                case 0x81:
                    nRoom.LeftButtonDuty = Direction.West;
                    break;
                case 0x91:
                    nRoom.TopButtonDuty = Direction.North;
                    nRoom.LeftButtonDuty = Direction.West;
                    break;
                case 0xA1:
                    nRoom.LeftButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.East;
                    break;
                case 0xB1:
                    nRoom.TopButtonDuty = Direction.North;
                    nRoom.LeftButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.East;
                    break;
                case 0xC1:
                    nRoom.BottomButtonDuty = Direction.South;
                    nRoom.LeftButtonDuty = Direction.West;
                    break;
                case 0xD1:
                    nRoom.LeftButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.East;
                    nRoom.TopButtonDuty = Direction.North;
                    break;
                case 0xE1:
                    nRoom.LeftButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.East;
                    nRoom.BottomButtonDuty = Direction.South;
                    break;
                case 0xF1:
                    nRoom.TopButtonDuty = Direction.North;
                    nRoom.BottomButtonDuty = Direction.South;
                    nRoom.LeftButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.East;
                    break;
                case 0x82: //EAST heading
                    nRoom.BottomButtonDuty = Direction.West;
                    break;
                case 0x92:
                    nRoom.LeftButtonDuty = Direction.North;
                    nRoom.BottomButtonDuty = Direction.West;
                    break;
                case 0xA2:
                    nRoom.BottomButtonDuty = Direction.West;
                    nRoom.TopButtonDuty = Direction.East;
                    break;
                case 0xB2:
                    nRoom.BottomButtonDuty = Direction.West;
                    nRoom.LeftButtonDuty = Direction.North;
                    nRoom.TopButtonDuty = Direction.East;
                    break;
                case 0xC2:
                    nRoom.BottomButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.South;
                    break;
                case 0xD2:
                    nRoom.BottomButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.South;
                    nRoom.LeftButtonDuty = Direction.North;
                    break;
                case 0xE2:
                    nRoom.BottomButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.South;
                    nRoom.TopButtonDuty = Direction.East;
                    break;
                case 0xF2:
                    nRoom.BottomButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.South;
                    nRoom.TopButtonDuty = Direction.East;
                    nRoom.LeftButtonDuty = Direction.North;
                    break;
                case 0x14:
                    nRoom.BottomButtonDuty = Direction.North;
                    break;
                case 0x34:
                    nRoom.BottomButtonDuty = Direction.North;
                    nRoom.LeftButtonDuty = Direction.East;
                    break;
                case 0x54:
                    nRoom.BottomButtonDuty = Direction.North;
                    nRoom.TopButtonDuty = Direction.South;
                    break;
                case 0x74:
                    nRoom.BottomButtonDuty = Direction.North;
                    nRoom.TopButtonDuty = Direction.South;
                    nRoom.LeftButtonDuty = Direction.East;
                    break;
                case 0x94:
                    nRoom.BottomButtonDuty = Direction.North;
                    nRoom.RightButtonDuty = Direction.West;
                    break;
                case 0xB4:
                    nRoom.BottomButtonDuty = Direction.North;
                    nRoom.RightButtonDuty = Direction.West;
                    nRoom.LeftButtonDuty = Direction.East;
                    break;
                case 0xD4:
                    nRoom.BottomButtonDuty = Direction.North;
                    nRoom.TopButtonDuty = Direction.South;
                    nRoom.RightButtonDuty = Direction.West;
                    break;
                case 0xF4:
                    nRoom.BottomButtonDuty = Direction.North;
                    nRoom.TopButtonDuty = Direction.South;
                    nRoom.RightButtonDuty = Direction.West;
                    nRoom.LeftButtonDuty = Direction.East;
                    break;
                case 0x28: //WEST heading
                    nRoom.BottomButtonDuty = Direction.East;
                    break;
                case 0x38:
                    nRoom.BottomButtonDuty = Direction.East;
                    nRoom.RightButtonDuty = Direction.North;
                    break;
                case 0x68:
                    nRoom.BottomButtonDuty = Direction.East;
                    nRoom.LeftButtonDuty = Direction.South;
                    break;
                case 0x78:
                    nRoom.BottomButtonDuty = Direction.East;
                    nRoom.RightButtonDuty = Direction.North;
                    nRoom.LeftButtonDuty = Direction.South;
                    break;
                case 0xA8:
                    nRoom.BottomButtonDuty = Direction.East;
                    nRoom.TopButtonDuty = Direction.West;
                    break;
                case 0xB8:
                    nRoom.BottomButtonDuty = Direction.East;
                    nRoom.TopButtonDuty = Direction.West;
                    nRoom.RightButtonDuty = Direction.North;
                    break;
                case 0xE8:
                    nRoom.BottomButtonDuty = Direction.East;
                    nRoom.TopButtonDuty = Direction.West;
                    nRoom.LeftButtonDuty = Direction.South;
                    break;
                case 0xF8:
                    nRoom.BottomButtonDuty = Direction.East;
                    nRoom.TopButtonDuty = Direction.West;
                    nRoom.LeftButtonDuty = Direction.South;
                    nRoom.RightButtonDuty = Direction.North;
                    break;
            }

            return nRoom;
        }
    }
}
