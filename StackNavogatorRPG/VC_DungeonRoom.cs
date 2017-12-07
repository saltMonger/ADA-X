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
            #region test
            PlayerCharacter chr1 = new PlayerCharacter();
            chr1.PhysicalAttack = 10;
            chr1.MagicDefense = 5;
            chr1.attacks.Add(new Attack_Punch());
            chr1.attacks.Add(new Attack_Magic());
            chr1.attacks.Add(new Attack_Healing());



            for (int i = 0; i < 4; i++)
            {
                //chr1.Attack(new Attack_Punch(), chr2);
                //chr2.Attack(new Attack_Magic(), chr1);
            }
            #endregion
        }

        partial void UIButton547_TouchUpInside(UIButton sender)
        {
            PlayerCharacter chr1 = new PlayerCharacter();
            chr1.PhysicalAttack = 10;
            chr1.MagicDefense = 5;
            chr1.attacks.Add(new Attack_Punch());
            chr1.attacks.Add(new Attack_Magic());
            chr1.attacks.Add(new Attack_Healing());

            Enemies.Enemy_Goblin enemy = new Enemies.Enemy_Goblin();

            VC_BattleRoom battle = new VC_BattleRoom(chr1, enemy);
            PresentViewController(battle, true, null);
        }
    }
}

