using System;
using Foundation;
using UIKit;

namespace StackNavogatorRPG
{
    public partial class VC_BattleRoom : UIViewController
    {
        PlayerCharacter playerCharacter;

        public VC_BattleRoom(PlayerCharacter chr) : base("VC_BattleRoom", null)
        {
            Console.WriteLine("Battle Started");
            playerCharacter = chr;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Tbl_AttackList.Source = new AttackListScource(playerCharacter);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        class AttackListScource : UITableViewSource{
            PlayerCharacter playerCharacter;

            public AttackListScource(PlayerCharacter player)
            {
                playerCharacter = player;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                int id = indexPath.Row;
                UITableViewCell cell = new UITableViewCell();
                cell.TextLabel.Text = playerCharacter.attacks[id].GetName();
                return cell;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return playerCharacter.attacks.Count;
            }
        }
    }
}

