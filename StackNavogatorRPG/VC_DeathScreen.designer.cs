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
    [Register ("VC_DeathScreen")]
    partial class VC_DeathScreen
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DeadOrEscapeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SummaryLabel { get; set; }

        [Action ("UIButton19442_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton19442_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (DeadOrEscapeLabel != null) {
                DeadOrEscapeLabel.Dispose ();
                DeadOrEscapeLabel = null;
            }

            if (SummaryLabel != null) {
                SummaryLabel.Dispose ();
                SummaryLabel = null;
            }
        }
    }
}