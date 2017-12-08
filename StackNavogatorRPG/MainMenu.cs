﻿using System;
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

            UIImage GameViewIcon = UIImage.FromBundle("Tab Icon Images/ViewTabIcon.png");
            UIImage MapViewIcon = UIImage.FromBundle("Tab Icon Images/MapTabIcon.png");
            UIImage InventoryViewIcon = UIImage.FromBundle("Tab Icon Images/itemsTabIcon.png");

            tabs[0].TabBarItem = new UITabBarItem("Game", GameViewIcon, GameViewIcon);
            tabs[1].TabBarItem = new UITabBarItem("Map", MapViewIcon, MapViewIcon);
            tabs[2].TabBarItem = new UITabBarItem("Inventory", InventoryViewIcon, InventoryViewIcon);
            TabView.SetViewControllers(tabs.ToArray(),true);


            PresentViewController(TabView, true, null);
        }
    }
}

