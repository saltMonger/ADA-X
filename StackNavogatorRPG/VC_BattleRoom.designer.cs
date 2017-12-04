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
        UIKit.UITableView Tbl_AttackList { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Tbl_AttackList != null) {
                Tbl_AttackList.Dispose ();
                Tbl_AttackList = null;
            }
        }
    }
}