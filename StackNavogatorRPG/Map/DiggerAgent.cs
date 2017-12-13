using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenAgentBased
{
    public class DiggerAgent
    {
        //RULES
        //The digger will move around the constrained area, creating a room when it moves to a new cell (array position)
        //After X steps, the digger will choose a new direction, based off of a random number
        //On the start of each step, if the generated room size has reached a threshold, the digger will sto
        //If the digger would run into a previously genereated room, it will simply continue it's direction, not adding to step
        //If the digger would run into a map boundary, it will choose a new direction
        //When the digger is finished, it will call Finalize() which will set roomcell metadata

        //VARIABLES
        //Map Size:  the dimensions of the map
        //  x: horizontal dimension     y: vertical dimension
        //Random Step: after x steps, choose random direction

        public int MapSizeTotal { get; set; } //Sum of X and Y (for square cellage)
        public int MapSizeX { get; set; }
        public int MapSizeY { get; set; }
        public int RandomStep { get; set; }
        public int RoomCountRunning{ get; set; }
        public int RoomCountThreshold { get; set; }
        public RoomCell[,] RoomCells { get; set; }
        public Random rng { get; set; }

        public int[] PlayerStartLocation
        {
            get;
            set;
        }

        public int[] BossLocation
        {
            get;
            set;
        }

        public DiggerAgent(int sizeX, int sizeY, int stepSize)
        {
            MapSizeX = sizeX;
            MapSizeY = sizeY;
            RandomStep = stepSize;

            rng = new Random();
        }


        /// <summary>
        /// Dig Map places the digger at a random location in the cells array
        /// The digger follows the rules stated above, and then calls finalize to link all the rooms
        /// </summary>
        public void DigMap()
        {
            //init cell array
            RoomCells = new RoomCell[MapSizeX, MapSizeY];
            //calculate threshold of room
            //might need tweaking but ideally 35% of the room should be filled
            MapSizeTotal = MapSizeX * MapSizeY;
            RoomCountThreshold = (int)(MapSizeTotal * 0.15f); //might truncate awkwardly, but some variation is okay
            RoomCountRunning = 0; //set room tally to 0

            //this will be the initial digger location
            int xpos = rng.Next(0, MapSizeX);
            int ypos = rng.Next(0, MapSizeY);

            int stepCounter = 0; //local step count for random dig pattern
            Direction diggerDirection = (Direction)rng.Next(0, 4);
            //begin digger step event
            while(RoomCountRunning <= RoomCountThreshold)
            {
                //check room tally on beginning of step event

                //check if room has already been dug
                if(RoomCells[xpos, ypos] != null)
                {
                    //do not increase room count or step count
                    Console.WriteLine("cross over occurred");
                }
                else
                {
                    //dig this room
                    RoomCells[xpos, ypos] = new RoomCell();
                    RoomCountRunning += 1;
                }



                //determine direction
                if(stepCounter >= RandomStep)
                {
                    //if step threshold is reached, reroll direction and reset counter
                    int dir = rng.Next(0, 4);
                    switch(dir){
                        case 0: diggerDirection = Direction.North;
                            break;
                        case 1: diggerDirection = Direction.South;
                            break;
                        case 2: diggerDirection = Direction.East;
                            break;
                        case 3: diggerDirection = Direction.West;
                            break;

                    }
                    stepCounter = 0;
                }

                //temp predicted next positions
                bool validMove = false;
                //

                while (!validMove)
                {
                    int pxpos = xpos;
                    int pypos = ypos;
                    //calculate next position
                    switch (diggerDirection)
                    {
                        case Direction.North: pypos -= 1; break;
                        case Direction.South: pypos += 1; break;
                        case Direction.East: pxpos += 1; break;
                        case Direction.West: pxpos -= 1; break;
                    }

                    //check if next room is valid (is not a boundary and is not a populated room)
                    if (pxpos >= 0 && pxpos < MapSizeX - 1 && pypos >= 0 && pypos < MapSizeY)
                    {
                        if (RoomCells[pxpos, pypos] == null)
                        {
                            //okay to set the positions now
                            xpos = pxpos;
                            ypos = pypos;
                            validMove = true;
                            stepCounter += 1;
                        }
                        else
                        {
                            xpos = pxpos;
                            ypos = pypos;
                            validMove = true;

                        }
                    }
                    else
                    {
                        validMove = false;
                    }

                    if (!validMove)
                    {
                        var oldDiggerDirection = diggerDirection;

                        switch (oldDiggerDirection)
                        {
                            case Direction.North:
                                switch (rng.Next(0, 3))
                                {
                                    case 0: diggerDirection = Direction.East; break;
                                    case 1: diggerDirection = Direction.South; break;
                                    case 2: diggerDirection = Direction.West; break;
                                }
                                break;
                            case Direction.South:
                                switch (rng.Next(0, 3))
                                {
                                    case 0: diggerDirection = Direction.East; break;
                                    case 1: diggerDirection = Direction.North; break;
                                    case 2: diggerDirection = Direction.West; break;
                                }
                                break;
                            case Direction.East:
                                switch (rng.Next(0, 3))
                                {
                                    case 0: diggerDirection = Direction.North; break;
                                    case 1: diggerDirection = Direction.South; break;
                                    case 2: diggerDirection = Direction.West; break;
                                }
                                break;
                            case Direction.West:
                                switch (rng.Next(0, 3))
                                {
                                    case 0: diggerDirection = Direction.North; break;
                                    case 1: diggerDirection = Direction.South; break;
                                    case 2: diggerDirection = Direction.East; break;
                                }
                                break;
                        }

                        stepCounter = 0;
                    }
                }
            }

            //call finalize to link the map
            FinalizeMap();
        }


        /// <summary>
        /// Links and fills init'd Room Cells in the RoomCells array
        /// </summary>
        public void FinalizeMap()
        {
            int playerY = 0;
            int playerX = 0;
            for(int x=0; x <= MapSizeX - 1; x++)
            {
                for (int y = 0; y <= MapSizeY - 1; y++)
                {
                    //skip link step for null room
                    if (RoomCells[x, y] == null)
                    {
                        continue;
                    }

                    //max coord set
                    if(x > playerX && y > playerY){
                        playerX = x;
                        playerY = y;

                    }


                    //set room coordinates
                    RoomCells[x, y].RoomCoords = new int[2] { x, y };

                    //begin linking rooms
                    int px;
                    int py;
                    //check North
                    px = x;
                    py = y - 1;


                    if(CheckBounds(px, py, MapSizeX, MapSizeY))
                    {
                        RoomCell rm = RoomCells[px, py];
                        RoomCells[x, y].North = rm;
                    }
                    else
                    {
                        RoomCells[x, y].North = null;
                    }

                    //check East
                    px = x + 1;
                    py = y;

                    if(CheckBounds(px, py, MapSizeX, MapSizeY))
                    {
                        RoomCell rm = RoomCells[px, py];
                        RoomCells[x, y].East = rm;
                    }
                    else
                    {
                        RoomCells[x,y].East = null;
                    }

                    //check South
                    px = x;
                    py = y + 1;

                    if(CheckBounds(px, py, MapSizeX, MapSizeY))
                    {
                        RoomCell rm = RoomCells[px, py];
                        RoomCells[x, y].South = rm;
                    }
                    else
                    {
                        RoomCells[x, y].South = null;
                    }

                    //check West
                    px = x - 1;
                    py = y;

                    if(CheckBounds(px, py, MapSizeX, MapSizeY))
                    {
                        RoomCell rm = RoomCells[px, py];
                        RoomCells[x, y].West = rm;
                    }
                    else
                    {
                        RoomCells[x, y].West = null;
                    }

                }
            }

            PlayerStartLocation = new int[2] { playerX, playerY };

            //spin the png
            //MapCharter mapc = new MapCharter(RoomCells, MapSizeX, MapSizeY);
        }

        //send map coords and map upper boundaries
        //returns true if location is within bounds
        private bool CheckBounds(int x, int y, int bx, int by)
        {
            if(x >= 0 && x < bx && y >= 0 && y < by)
            {
                //within boundaries
                return true;
            }
            return false;
        }


    }
}
