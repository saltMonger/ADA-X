// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace StackNavogatorRPG
{
    [Register ("VC_BattleRoom")]
    partial class VC_BattleRoom
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIProgressView Bar_Mana { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Btn_Enemy1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIProgressView HPBar_Enemy { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIProgressView HPBar_Player { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView Img_Backroung { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView Tbl_AttackList { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView Txt_BattleSummary { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Txt_EnemyHealth { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Txt_Mana { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Txt_PlayerHealth { get; set; }

        [Action ("TouchEvent_AttackEnemy:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TouchEvent_AttackEnemy (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Bar_Mana != null) {
                Bar_Mana.Dispose ();
                Bar_Mana = null;
            }

            if (Btn_Enemy1 != null) {
                Btn_Enemy1.Dispose ();
                Btn_Enemy1 = null;
            }

            if (HPBar_Enemy != null) {
                HPBar_Enemy.Dispose ();
                HPBar_Enemy = null;
            }

            if (HPBar_Player != null) {
                HPBar_Player.Dispose ();
                HPBar_Player = null;
            }

            if (Img_Backroung != null) {
                Img_Backroung.Dispose ();
                Img_Backroung = null;
            }

            if (Tbl_AttackList != null) {
                Tbl_AttackList.Dispose ();
                Tbl_AttackList = null;
            }

            if (Txt_BattleSummary != null) {
                Txt_BattleSummary.Dispose ();
                Txt_BattleSummary = null;
            }

            if (Txt_EnemyHealth != null) {
                Txt_EnemyHealth.Dispose ();
                Txt_EnemyHealth = null;
            }

            if (Txt_Mana != null) {
                Txt_Mana.Dispose ();
                Txt_Mana = null;
            }

            if (Txt_PlayerHealth != null) {
                Txt_PlayerHealth.Dispose ();
                Txt_PlayerHealth = null;
            }
        }
    }
}