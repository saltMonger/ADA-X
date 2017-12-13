using System;
using StackNavogatorRPG.Map;
using UIKit;

namespace StackNavogatorRPG
{
    public partial class VC_MapView : UIViewController
    {
        public VC_MapView() : base("VC_MapView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            MapManager man = MapManager.Instance;
            MapLabel.Text = man.WriteMap();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

