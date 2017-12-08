using System;
using System.Collections.Generic;

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
            var TabView = new UITabBarController();

            var dungeonRoom = new VC_DungeonRoom();
            var mapView = new UIViewController();
            var inventoryView = new UIViewController();

            List<UIViewController> tabs = new List<UIViewController>();

            tabs.Add(dungeonRoom);
            tabs.Add(mapView);
            tabs.Add(inventoryView);

            UIImage GameViewIcon = UIImage.FromBundle("Item Images/bronzeSword");
            UIImage MapViewIcon = UIImage.FromBundle("Item Images/bronzeSword");
            UIImage InventoryViewIcon = UIImage.FromBundle("Item Images/bronzeSword");

            tabs[0].TabBarItem = new UITabBarItem("Game View", GameViewIcon, GameViewIcon);
            tabs[1].TabBarItem = new UITabBarItem("Map View", MapViewIcon, MapViewIcon);
            tabs[2].TabBarItem = new UITabBarItem("Inventory View", InventoryViewIcon, InventoryViewIcon);
            TabView.SetViewControllers(tabs.ToArray(),true);


            PresentViewController(TabView, true, null);
        }
    }
}

