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

            EnemyHPBar.Progress = ((float)enemyCharacter.Health / (float)enemyCharacter.MaxHealth);
            PlayerHPBar.Progress = ((float)playerCharacter.Health / (float)playerCharacter.MaxHealth);

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

        partial void TouchEvent_AttackEnemy(UIButton sender)
        {
            int attackIndex = -1;
            try
            {
                attackIndex = Tbl_AttackList.IndexPathForSelectedRow.Row;
            }catch(System.NullReferenceException){
                attackIndex = -1;
            }

            if (attackIndex >= 0)
            {
                AttackBase playerAttack = playerCharacter.attacks[attackIndex];
                AttackBase enemyAttack = enemyCharacter.GetRandomAttack();

                string msg1;
                string msg2;

                //perform battle
                int damage1 = playerCharacter.Attack(playerAttack, enemyCharacter, out msg1);
                int damage2 = enemyCharacter.Attack(enemyAttack, playerCharacter, out msg2);

                Txt_BattleSummary.Text = "";
                Txt_BattleSummary.Text += msg1 + '\n';
                Txt_BattleSummary.Text += msg2 + '\n';

                EnemyHPBar.Progress = ((float)enemyCharacter.Health / (float)enemyCharacter.MaxHealth);
                PlayerHPBar.Progress = ((float)playerCharacter.Health / (float)playerCharacter.MaxHealth);
            }else{
                Txt_BattleSummary.Text = "Select an attack!";
            }

            if(enemyCharacter.Health <= 0){
                this.DismissViewController(true,null);
            }
        }
    }
}

