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
    [Register ("VC_MapView")]
    partial class VC_MapView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView MapImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MapLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (MapImage != null) {
                MapImage.Dispose ();
                MapImage = null;
            }

            if (MapLabel != null) {
                MapLabel.Dispose ();
                MapLabel = null;
            }
        }
    }
}