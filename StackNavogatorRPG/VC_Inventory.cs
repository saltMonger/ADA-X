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
            UpdatePreview(0);
            // Perform any additional setup after loading the view, typically from a nib.
            EquipmentTableView.Source = new EquipmentListSource(this);
            PackTableView.Source = new BagListSource(this);

        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            UpdateStatsDisplay();
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
            StatsHPText.Text = player.Health.ToString();
            StatsStamText.Text = player.Stamina.ToString();
            StatsXPText.Text = player.Experience.ToString();
            StatsXPNextText.Text = player.ExperienceToNextLevel.ToString();

        }

        partial void EquipUseButton_TouchUpInside(UIButton sender)
        {
            //player.addEquipment(player.bag[PackTableView.IndexPathForSelectedRow.Row]);
        }

        public void UpdatePreview(int table)
        {
            int Index = -1;
            int equippedOrBagNum = table; // 0 for none, 1 for equipped, 2 for bag
            try
            {
                if (equippedOrBagNum == 1)
                    Index = EquipmentTableView.IndexPathForSelectedRow.Row;
                else if (equippedOrBagNum == 2)
                    Index = PackTableView.IndexPathForSelectedRow.Row;
            }
            catch (System.NullReferenceException)
            {
                Index = -1;
            }

            if (Index >= 0 && equippedOrBagNum == 1)
            {
                ItemPreviewImage.Hidden = false;
                ItemPreviewTitle.Hidden = false;
                ItemPreviewEffect1Text.Hidden = false;
                ItemPreviewEffect2Text.Hidden = false;
                EquipUseButton.Hidden = true;

                ItemPreviewImage.Image = player.equipment[Index].Sprite;
                ItemPreviewTitle.Text = player.equipment[Index].GetName();

                ItemPreviewEffect1Text.Text = player.equipment[Index].GetDescription1();
                ItemPreviewEffect2Text.Text = player.equipment[Index].GetDescription2();


            }
            else if (Index >= 0 && equippedOrBagNum == 2)
            {
                ItemPreviewImage.Hidden = false;
                ItemPreviewTitle.Hidden = false;
                ItemPreviewEffect1Text.Hidden = false;
                ItemPreviewEffect2Text.Hidden = false;
                EquipUseButton.Hidden = false;

                ItemPreviewImage.Image = player.bag[Index].Sprite;
                ItemPreviewTitle.Text = player.bag[Index].GetName();

                ItemPreviewEffect1Text.Text = player.bag[Index].GetDescription1();
                ItemPreviewEffect2Text.Text = player.bag[Index].GetDescription2();

            }
            else
            {
                ItemPreviewImage.Hidden = true;
                ItemPreviewTitle.Hidden = true;
                ItemPreviewEffect1Text.Hidden = true;
                ItemPreviewEffect2Text.Hidden = true;
                EquipUseButton.Hidden = true;
            }
        }


        class EquipmentListSource : UITableViewSource
        {
            PlayerCharacter player = GameManager.Instance.playerCharacter;
            VC_Inventory screen;

            public EquipmentListSource(VC_Inventory owner)
            {
                screen = owner;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                int id = indexPath.Row;
                UITableViewCell cell = new UITableViewCell();
                cell.TextLabel.Text = player.equipment[id].GetName();
                return cell;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return player.equipment.Count;
            }

            public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
            {
                //base.RowSelected(tableView, indexPath);

                screen.UpdatePreview(1);
                screen.PackTableView.DeselectRow(screen.PackTableView.IndexPathForSelectedRow, false);
            }
        }


        class BagListSource : UITableViewSource
        {
            PlayerCharacter player = GameManager.Instance.playerCharacter;
            VC_Inventory screen;

            public BagListSource(VC_Inventory owner)
            {
                screen = owner;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                int id = indexPath.Row;
                UITableViewCell cell = new UITableViewCell();
                cell.TextLabel.Text = player.bag[id].GetName();
                return cell;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return player.bag.Count;
            }

            public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
            {
                //base.RowSelected(tableView, indexPath);

                screen.UpdatePreview(2);
                screen.EquipmentTableView.DeselectRow(screen.EquipmentTableView.IndexPathForSelectedRow, false);
            }
        }
    }
}

