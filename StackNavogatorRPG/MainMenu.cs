using System;
using System.Collections.Generic;
using StackNavogatorRPG.Map;
using UIKit;

namespace StackNavogatorRPG
{
    public partial class MainMenu : UIViewController
    {
        public static UINavigationController dngNav;
       

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

            MapManager mapman = MapManager.Instance;
            mapman.GenMap();
            //mapman.WriteMap();


            dngNav = new UINavigationController(mapman.GetFirstRoom());


            //var dungeonRoom = mapman.GetFirstRoom();
            var mapView = new VC_MapView();
            var inventoryView = new VC_Inventory();

            List<UIViewController> tabs = new List<UIViewController>();

            tabs.Add(dngNav);
            tabs.Add(mapView);
            tabs.Add(inventoryView);

            UIImage GameViewIcon = UIImage.FromBundle("Tab Icon Images/ViewTabIcon.png");
            UIImage MapViewIcon = UIImage.FromBundle("Tab Icon Images/MapTabIcon.png");
            UIImage InventoryViewIcon = UIImage.FromBundle("Tab Icon Images/itemsTabIcon.png");

            tabs[0].TabBarItem = new UITabBarItem("Game", GameViewIcon, GameViewIcon);
            tabs[1].TabBarItem = new UITabBarItem("Map", MapViewIcon, MapViewIcon);
            tabs[2].TabBarItem = new UITabBarItem("Inventory", InventoryViewIcon, InventoryViewIcon);
            TabView.SetViewControllers(tabs.ToArray(),true);

            Item rustySword = new Item(1);
            rustySword.SetItem(0);
            GameManager.Instance.playerCharacter.addEquipment(rustySword);

            Item bronzeSword = new Item(1);
            bronzeSword.SetItem(10);
            GameManager.Instance.playerCharacter.bag.Add(bronzeSword);

            Item HPPotion = new Item(1);
            HPPotion.SetItem(8);
            GameManager.Instance.playerCharacter.bag.Add(HPPotion);




            PresentViewController(TabView, true, null);
        }
    }
}

