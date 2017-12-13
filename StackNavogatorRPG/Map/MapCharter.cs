using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using UIKit;
using Foundation;
using StackNavogatorRPG.Map;

namespace MapGenAgentBased
{
    public enum Markers
    {
        Explored,
        Occupied,
        Wall
    }

    public class MapCharter
    {
        public RoomCell[,] Map { get; set; }
        public int MaxSizeX { get; set; }
        public int MaxSizeY { get; set; }
        public byte[] imageBuffer { get; set; }
        public string MapString
        {
            get;
            set;
        
        }


        public MapCharter(RoomCell[,] map, int maxX, int maxY)
        {
            Map = map;
            MaxSizeX = maxX;
            MaxSizeY = maxY;
        }

        public byte[] PixelMaker(Markers marker)
        {
            switch (marker)
            {
                case Markers.Explored: return new byte[4] { 255, 255, 255, 255 };
                case Markers.Occupied: return new byte[4] { 255, 0, 0, 255 };
                case Markers.Wall: return new byte[4] { 0, 0, 0, 255 };
                default: return new byte[4] { 0, 255, 0, 255 };
            }
        } 


        //create thumbnail
        public void ChartMap()
        {
            int resBytes = (MaxSizeX * 4) * MaxSizeY;
            imageBuffer = new byte[resBytes];
            StringBuilder sb = new StringBuilder();
            MapManager man = MapManager.Instance;
            for(int x = 0; x < MaxSizeX; x++)
            {
                for(int y = 0; y < MaxSizeY; y++)
                {
                    RoomCell rm = Map[y, x];

                    ////int[] coords = TranslateCoords(x, y, MaxSizeX, MaxSizeY);

                    //if(rm == null)
                    //{
                    //    //PlotPixel(coords[0], coords[1], PixelMaker(Markers.Wall));
                    //    PlotPixel(y, x, PixelMaker(Markers.Wall));

                    //}
                    //else
                    //{
                    //    //PlotPixel(coords[0], coords[1], PixelMaker(Markers.Explored));
                    //    PlotPixel(y, x, PixelMaker(Markers.Explored));

                    //}
                    if(rm == null || !rm.Visited){
                        sb.Append(" ");
                    }
                    else if(rm.Boss){
                        sb.Append("B");
                    }
                    else if (x == man.PlayerCoords[1] && y == man.PlayerCoords[0]){
                        sb.Append("O");
                    }
                    else{
                        sb.Append("X");
                    }

                }
                sb.AppendLine();
            }

            //unsafe
            //{
            //    fixed(byte* ptr = imageBuffer)
            //    {
            //        using (Bitmap image = new Bitmap(MaxSizeX, MaxSizeY, MaxSizeX * 4, System.Drawing.Imaging.PixelFormat.Format32bppRgb, new IntPtr(ptr)))
            //        {
            //            image.Save(@"map.png");
            //        }
            //    }
            //

            //creating coregraphics bitmap context is overly difficult,
            //instead of relying on gfx, we'll make a string array

            //TODO: Implement string array
            MapString = sb.ToString();

        }


        public int[] TranslateCoords(int x, int y, int bx, int by)
        {
            int newX = (bx - 1) - x;
            int newY = (by - 1) - y;
            return new int[] { newX, newY };
        }

        public void PlotPixel(int x, int y, byte[] pixel)
        {
            int offset = ((MaxSizeX * 4) * y) + (x * 4);

            //redundant
            imageBuffer[offset] = pixel[0];
            imageBuffer[offset + 1] = pixel[1];
            imageBuffer[offset + 2] = pixel[2];
            imageBuffer[offset + 3] = pixel[3];


        }

    }
}
