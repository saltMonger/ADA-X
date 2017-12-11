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
        UIKit.UIButton EquipUseButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ItemPreviewEffect1Text { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ItemPreviewEffect2Text { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ItemPreviewImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ItemPreviewTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView PackTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel StatsHPText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel StatsLevelText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel StatsMAttackText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel StatsMaxHPText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel StatsMaxStamText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel StatsMDefenseText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel StatsPAttackText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel StatsPDefenseText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel StatsStamText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel StatsXPNextText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel StatsXPText { get; set; }

        [Action ("EquipUseButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void EquipUseButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (EquipmentTableView != null) {
                EquipmentTableView.Dispose ();
                EquipmentTableView = null;
            }

            if (EquipUseButton != null) {
                EquipUseButton.Dispose ();
                EquipUseButton = null;
            }

            if (ItemPreviewEffect1Text != null) {
                ItemPreviewEffect1Text.Dispose ();
                ItemPreviewEffect1Text = null;
            }

            if (ItemPreviewEffect2Text != null) {
                ItemPreviewEffect2Text.Dispose ();
                ItemPreviewEffect2Text = null;
            }

            if (ItemPreviewImage != null) {
                ItemPreviewImage.Dispose ();
                ItemPreviewImage = null;
            }

            if (ItemPreviewTitle != null) {
                ItemPreviewTitle.Dispose ();
                ItemPreviewTitle = null;
            }

            if (PackTableView != null) {
                PackTableView.Dispose ();
                PackTableView = null;
            }

            if (StatsHPText != null) {
                StatsHPText.Dispose ();
                StatsHPText = null;
            }

            if (StatsLevelText != null) {
                StatsLevelText.Dispose ();
                StatsLevelText = null;
            }

            if (StatsMAttackText != null) {
                StatsMAttackText.Dispose ();
                StatsMAttackText = null;
            }

            if (StatsMaxHPText != null) {
                StatsMaxHPText.Dispose ();
                StatsMaxHPText = null;
            }

            if (StatsMaxStamText != null) {
                StatsMaxStamText.Dispose ();
                StatsMaxStamText = null;
            }

            if (StatsMDefenseText != null) {
                StatsMDefenseText.Dispose ();
                StatsMDefenseText = null;
            }

            if (StatsPAttackText != null) {
                StatsPAttackText.Dispose ();
                StatsPAttackText = null;
            }

            if (StatsPDefenseText != null) {
                StatsPDefenseText.Dispose ();
                StatsPDefenseText = null;
            }

            if (StatsStamText != null) {
                StatsStamText.Dispose ();
                StatsStamText = null;
            }

            if (StatsXPNextText != null) {
                StatsXPNextText.Dispose ();
                StatsXPNextText = null;
            }

            if (StatsXPText != null) {
                StatsXPText.Dispose ();
                StatsXPText = null;
            }
        }
    }
}