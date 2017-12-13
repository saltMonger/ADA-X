using System;
using System.Collections.Generic;
using MapGenAgentBased;
using UIKit;

namespace StackNavogatorRPG.Map
{
    public class MapManager
    {
        private static MapManager _instance;

        public Dictionary<byte, UIImage> bgimages; 

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

            //build image dict
            bgimages = new Dictionary<byte, UIImage>();
            //north heading
            bgimages.Add(0x41, UIImage.FromBundle("Background Images/bg-000.png"));
            bgimages.Add(0x51, UIImage.FromBundle("Background Images/bg-010.png"));
            bgimages.Add(0x61, UIImage.FromBundle("Background Images/bg-001.png"));
            bgimages.Add(0x71, UIImage.FromBundle("Background Images/bg-011.png"));
            bgimages.Add(0xC1, UIImage.FromBundle("Background Images/bg-100.png"));
            bgimages.Add(0xD1, UIImage.FromBundle("Background Images/bg-110.png"));
            bgimages.Add(0xE1, UIImage.FromBundle("Background Images/bg-101.png"));
            bgimages.Add(0xF1, UIImage.FromBundle("Background Images/bg-111.png"));


            //east heading
            bgimages.Add(0x82, UIImage.FromBundle("Background Images/bg-000.png"));
            bgimages.Add(0x92, UIImage.FromBundle("Background Images/bg-100.png"));
            bgimages.Add(0xA2, UIImage.FromBundle("Background Images/bg-010.png"));
            bgimages.Add(0xB2, UIImage.FromBundle("Background Images/bg-110.png"));
            bgimages.Add(0xC2, UIImage.FromBundle("Background Images/bg-001.png"));
            bgimages.Add(0xD2, UIImage.FromBundle("Background Images/bg-101.png"));
            bgimages.Add(0xE2, UIImage.FromBundle("Background Images/bg-011.png"));
            bgimages.Add(0xF2, UIImage.FromBundle("Background Images/bg-111.png"));

            //south heading
            bgimages.Add(0x14, UIImage.FromBundle("Background Images/bg-000.png"));
            bgimages.Add(0x34, UIImage.FromBundle("Background Images/bg-100.png"));
            bgimages.Add(0x54, UIImage.FromBundle("Background Images/bg-010.png"));
            bgimages.Add(0x74, UIImage.FromBundle("Background Images/bg-110.png"));
            bgimages.Add(0x94, UIImage.FromBundle("Background Images/bg-001.png"));
            bgimages.Add(0xB4, UIImage.FromBundle("Background Images/bg-101.png"));
            bgimages.Add(0xD4, UIImage.FromBundle("Background Images/bg-011.png"));
            bgimages.Add(0xF4, UIImage.FromBundle("Background Images/bg-111.png"));

            //west heading
            bgimages.Add(0x28, UIImage.FromBundle("Background Images/bg-000.png"));
            bgimages.Add(0x38, UIImage.FromBundle("Background Images/bg-001.png"));
            bgimages.Add(0x68, UIImage.FromBundle("Background Images/bg-100.png"));
            bgimages.Add(0x78, UIImage.FromBundle("Background Images/bg-101.png"));
            bgimages.Add(0xA8, UIImage.FromBundle("Background Images/bg-010.png"));
            bgimages.Add(0xB8, UIImage.FromBundle("Background Images/bg-011.png"));
            bgimages.Add(0xE8, UIImage.FromBundle("Background Images/bg-110.png"));
            bgimages.Add(0xF8, UIImage.FromBundle("Background Images/bg-111.png"));


                         

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
            Direction dir;
            if(Map[PlayerCoords[0], PlayerCoords[1]].North != null){
                dir = Direction.South;
            }
            else if(Map[PlayerCoords[0], PlayerCoords[1]].East != null)
            {
                dir = Direction.West;
            }
            else if(Map[PlayerCoords[0], PlayerCoords[1]].West != null){
                dir = Direction.East;
            }
            else{
                dir = Direction.North;
            }

            byte roomDesc = Map[PlayerCoords[0], PlayerCoords[1]].AssignRoomCellImage(dir);

            VC_DungeonRoom nRoom = new VC_DungeonRoom(true);
            nRoom.rc = Map[PlayerCoords[0], PlayerCoords[1]];
            Map[PlayerCoords[0], PlayerCoords[1]].Visited = true;

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

        public string WriteMap(){
            MapCharter charter = new MapCharter(Map, MapSizeX, MapSizeY);
            charter.ChartMap();
            return charter.MapString;
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
            Map[PlayerCoords[0], PlayerCoords[1]].Visited = true;
            VC_DungeonRoom nRoom = new VC_DungeonRoom(false);
            nRoom.rc = Map[PlayerCoords[0], PlayerCoords[1]];

            switch (roomDesc)
            {
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
                case 0xC1:
                    nRoom.BottomButtonDuty = Direction.South;
                    nRoom.LeftButtonDuty = Direction.West;
                    break;
                case 0xD1:
                    nRoom.LeftButtonDuty = Direction.West;
                    nRoom.BottomButtonDuty = Direction.South;
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
