using System;

using UIKit;

namespace StackNavogatorRPG
{
    public partial class MainMenu : UIViewController
    {
        public MainMenu() : base("MainMenu", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void StartGameButton_TouchUpInside(UIButton sender)
        {
            var dungeonRoom = new VC_DungeonRoom();

            PresentViewController(dungeonRoom, true, null);
        }
    }
}

