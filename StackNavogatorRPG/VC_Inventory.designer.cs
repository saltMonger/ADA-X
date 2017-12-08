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
    [Register ("VC_Inventory")]
    partial class VC_Inventory
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView EquipmentTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView PackTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (EquipmentTableView != null) {
                EquipmentTableView.Dispose ();
                EquipmentTableView = null;
            }

            if (PackTableView != null) {
                PackTableView.Dispose ();
                PackTableView = null;
            }
        }
    }
}