using System;
using MapGenAgentBased;
using StackNavogatorRPG.Map;
using UIKit;

namespace StackNavogatorRPG
{
    public partial class VC_DungeonRoom : UIViewController
    {
        public RoomCell rc;
        public bool firstRoom;

        public Direction LeftButtonDuty
        {
            get;
            set;
        }

        public Direction RightButtonDuty
        {
            get;
            set;
        }
     
        public Direction TopButtonDuty
        {
            get;
            set;
        }
 
        public Direction BottomButtonDuty
        {
            get;
            set;
        }
   
    
        public VC_DungeonRoom(bool first) : base("VC_DungeonRoom", null)
        {
            firstRoom = first;
        }

        public override void ViewDidLoad()
        {
            Console.WriteLine(("Heyo!"));
            base.ViewDidLoad();
            main();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        void main()
        {

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            MainMenu.dngNav.SetNavigationBarHidden(true, true);
            RoomImage.Image = rc.Image;
            TopButton.SetTitle(TopButtonDuty.ToString(), UIControlState.Normal);
            BottomButton.SetTitle(BottomButtonDuty.ToString(), UIControlState.Normal);
            RightButton.SetTitle(RightButtonDuty.ToString(), UIControlState.Normal);
            LeftButton.SetTitle(LeftButtonDuty.ToString(), UIControlState.Normal);

        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            if(rc.Treasure){
                //RYAN DO TREASURE HERE
            }

            if (!firstRoom)
            {
                if (!rc.Boss)
                {
                    Random rng = new Random();
                    int chance = rng.Next(0, 4);
                    if (chance == 0)
                    {
                        GameManager gm = GameManager.Instance;
                        gm.GetRandomEnemy();
                    }
                }
                else
                {
                    //boss goes here
                }
            }
        }

        partial void UIButton547_TouchUpInside(UIButton sender)
        {
            Enemies.Enemy_Goblin enemy = new Enemies.Enemy_Goblin();

            VC_BattleRoom battle = new VC_BattleRoom(GameManager.Instance.playerCharacter, enemy);
            PresentViewController(battle, true, null);
        }

        partial void LeftButton_TouchUpInside(UIButton sender)
        {
            if (LeftButtonDuty != Direction.None)
            {
                MapManager man = MapManager.Instance;
                VC_DungeonRoom vc = man.MoveRoom(LeftButtonDuty);
                //TabBarController.ViewControllers[0].PresentViewController(vc, false, null);
                MainMenu.dngNav.PushViewController(vc, true);

            }

        }

        partial void TopButton_TouchUpInside(UIButton sender)
        {
            if (TopButtonDuty != Direction.None)
            {
                Console.WriteLine("Top Button Touch");
                MapManager man = MapManager.Instance;
                VC_DungeonRoom vc = man.MoveRoom(TopButtonDuty);
                //TabBarController.ViewControllers[0].PresentViewController(vc, false, null);
                MainMenu.dngNav.PushViewController(vc, true);


            }
        }

        partial void RightButton_TouchUpInside(UIButton sender)
        {
            if (RightButtonDuty != Direction.None)
            {
                Console.WriteLine("Right Button Touch");
                MapManager man = MapManager.Instance;
                VC_DungeonRoom vc = man.MoveRoom(RightButtonDuty);
                //TabBarController.PresentViewController(vc, false, null);
                //PresentViewController(vc, false, null);
                //TabBarController.ViewControllers[0].PresentViewController(vc, false, null);
                MainMenu.dngNav.PushViewController(vc, true);
            
            }
        }

        partial void BottomButton_TouchUpInside(UIButton sender)
        {
            if (BottomButtonDuty != Direction.None)
            {
                Console.WriteLine("Bottom Button Touch");
                MapManager man = MapManager.Instance;
                VC_DungeonRoom vc = man.MoveRoom(BottomButtonDuty);
                //TabBarController.ViewControllers[0].PresentViewController(vc, false, null);
                MainMenu.dngNav.PushViewController(vc, true);


            }
        }
    }
}

