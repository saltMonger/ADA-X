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
    [Register ("VC_DungeonRoom")]
    partial class VC_DungeonRoom
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BottomButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LeftButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton RightButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView RoomImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TopButton { get; set; }

        [Action ("BottomButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BottomButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("LeftButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LeftButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("RightButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void RightButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("TopButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TopButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton547_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton547_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BottomButton != null) {
                BottomButton.Dispose ();
                BottomButton = null;
            }

            if (LeftButton != null) {
                LeftButton.Dispose ();
                LeftButton = null;
            }

            if (RightButton != null) {
                RightButton.Dispose ();
                RightButton = null;
            }

            if (RoomImage != null) {
                RoomImage.Dispose ();
                RoomImage = null;
            }

            if (TopButton != null) {
                TopButton.Dispose ();
                TopButton = null;
            }
        }
    }
}