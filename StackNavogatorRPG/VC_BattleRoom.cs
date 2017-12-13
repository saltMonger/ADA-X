using System;
using Foundation;
using UIKit;

namespace StackNavogatorRPG
{
    public partial class VC_BattleRoom : UIViewController
    {
        PlayerCharacter playerCharacter;
        EnemyCharacter enemyCharacter;

        public VC_BattleRoom(PlayerCharacter chr, EnemyCharacter enemy) : base("VC_BattleRoom", null)
        {
            Console.WriteLine("Battle Started");
            playerCharacter = chr;
            enemyCharacter = enemy;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Tbl_AttackList.Source = new AttackListScource(playerCharacter);
            Btn_Enemy1.SetBackgroundImage(enemyCharacter.GetImage(), UIControlState.Normal);
            Txt_BattleSummary.Text = enemyCharacter.GetIntro();
            UpdateStats();
            UpdateHPBars();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        class AttackListScource : UITableViewSource
        {
            PlayerCharacter playerCharacter;

            public AttackListScource(PlayerCharacter player)
            {
                playerCharacter = player;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                int section = indexPath.Section;
                int id = indexPath.Row;
                UITableViewCell cell = new UITableViewCell(UITableViewCellStyle.Subtitle, "reuse");
                if (section == 0)
                {
                    
                    cell.TextLabel.Text = playerCharacter.attacks[id].GetName();
                    cell.DetailTextLabel.Text = "Mana cost: " + playerCharacter.attacks[id].GetManaCost();
                }else{
                    cell.TextLabel.Text = playerCharacter.bag[id].GetName();
                }
                return cell;
            }
            public override nint NumberOfSections(UITableView tableView)
            {
                return 2;
            }
            public override nint RowsInSection(UITableView tableview, nint section)
            {
                if (section == 0)
                {
                    return playerCharacter.attacks.Count;
                }else{
                    return playerCharacter.bag.Count;
                }
            }
            public override string TitleForHeader(UITableView tableView, nint section)
            {
                if (section == 0)
                {
                    return "Attacks";
                }else{
                    return "Items";
                }
            }
        }

        void UpdateStats(){
            Txt_EnemyHealth.Text = "[Lv " + enemyCharacter.Level + "] " + enemyCharacter.GetName() + ": " + enemyCharacter.Health + "/" + enemyCharacter.MaxHealth;
            Txt_PlayerHealth.Text = "[Lv " + playerCharacter.Level + "] " + playerCharacter.GetName() + ": " + playerCharacter.Health + "/" + playerCharacter.MaxHealth;
            Txt_Mana.Text = "Mana: " + playerCharacter.Stamina + "/" + playerCharacter.MaxStamina;
        }

        void UpdateHPBars()
        {
            HPBar_Enemy.Progress = (float)enemyCharacter.Health / (float)enemyCharacter.MaxHealth;
            HPBar_Player.Progress = (float)playerCharacter.Health / (float)playerCharacter.MaxHealth;
            Bar_Mana.Progress = (float)playerCharacter.Stamina / (float)playerCharacter.MaxStamina;
        }

        partial void TouchEvent_AttackEnemy(UIButton sender)
        {
            int attackIndex = -1;
            int tableSection = -1;
            try
            {
                attackIndex = Tbl_AttackList.IndexPathForSelectedRow.Row;
                tableSection = Tbl_AttackList.IndexPathForSelectedRow.Section;
            }catch(System.NullReferenceException){
                attackIndex = -1;
                tableSection = -1;
            }

            if (attackIndex >= 0 && tableSection >= 0)
            {
                if (tableSection == 0)
                {
                    AttackBase playerAttack = playerCharacter.attacks[attackIndex];
                    AttackBase enemyAttack = enemyCharacter.GetRandomAttack();

                    string msg1;
                    string msg2;

                    //perform battle
                    int damage2 = playerCharacter.Attack(playerAttack, enemyCharacter, out msg1);
                    int damage1 = enemyCharacter.Attack(enemyAttack, playerCharacter, out msg2);

                    UpdateStats();
                    UpdateHPBars();

                    Txt_BattleSummary.Text = "";
                    Txt_BattleSummary.Text += msg1 + '\n';
                    Txt_BattleSummary.Text += msg2 + '\n';
                }else{
                    ItemBase playerItem = playerCharacter.bag[attackIndex];
                    Console.WriteLine(attackIndex);
                    string str = playerCharacter.UseItem(attackIndex, playerCharacter);
                    Tbl_AttackList.ReloadData();
                    Txt_BattleSummary.Text = "";
                    Txt_BattleSummary.Text += str + '\n';
                }
            }
            else
            {
                Txt_BattleSummary.Text = "Select an attack or item!";
            }

            Tbl_AttackList.ReloadData();

            if(enemyCharacter.Health <= 0){
                playerCharacter.Experience += enemyCharacter.GetExpValue();
                this.DismissViewController(true,null);
            }
        }
    }
}

