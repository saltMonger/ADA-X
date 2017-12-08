using System;

using UIKit;

namespace StackNavogatorRPG
{
    public partial class VC_DungeonRoom : UIViewController
    {
        public VC_DungeonRoom() : base("VC_DungeonRoom", null)
        {
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

        partial void UIButton547_TouchUpInside(UIButton sender)
        {
            Enemies.Enemy_Goblin enemy = new Enemies.Enemy_Goblin();

            VC_BattleRoom battle = new VC_BattleRoom(GameManager.Instance.playerCharacter, enemy);
            PresentViewController(battle, true, null);
        }
    }
}

