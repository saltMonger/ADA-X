using System;

using UIKit;

namespace StackNavogatorRPG
{
    public partial class VC_DeathScreen : UIViewController
    {
        bool win;

        public VC_DeathScreen( bool won ) : base("VC_DeathScreen", null)
        {
            win = won;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            if(win)
                ChangeToWinScreen();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton19442_TouchUpInside(UIButton sender)
        {
            AppDelegate theApp = (AppDelegate)UIApplication.SharedApplication.Delegate;
            theApp.RestartGame();
        }

        public void ChangeToWinScreen()
        {
            DeadOrEscapeLabel.Text = "Escape!";
            SummaryLabel.Text = "You have defeated the Demon King and escaped his dungeons!  Congratulations!";
        }
    }
}

