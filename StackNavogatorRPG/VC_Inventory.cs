using System;
using Foundation;
using UIKit;

namespace StackNavogatorRPG
{
    public partial class VC_Inventory : UIViewController
    {
        PlayerCharacter player = GameManager.Instance.playerCharacter;

        public VC_Inventory() : base("VC_Inventory", null)
        {
            //equipmentList 
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            UpdateStatsDisplay();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public void UpdateStatsDisplay()
        {
            StatsLevelText.Text = player.Level.ToString();
            StatsMaxHPText.Text = player.MaxHealth.ToString();
            StatsMaxStamText.Text = player.MaxStamina.ToString();
            StatsPAttackText.Text = player.PhysicalAttack.ToString();
            StatsPDefenseText.Text = player.PhysicalDefense.ToString();
            StatsMAttackText.Text = player.MagicAttack.ToString();
            StatsMDefenseText.Text = player.MagicDefense.ToString();

        }

        partial void EquipUseButton_TouchUpInside(UIButton sender)
        {
            //throw new NotImplementedException();
        }


        class EquipmentListSource : UITableViewSource
        {

            public EquipmentListSource()
            {
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                int id = indexPath.Row;
                UITableViewCell cell = new UITableViewCell();
                cell.TextLabel.Text = ""; //TODO
                return cell;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return 0; //TODO
            }
        }
    }
}

