﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Lion.XiOS
{
    [Register ("AdsViewCell")]
    partial class AdsViewCell
    {
        [Outlet]
        //[GeneratedCode ("iOS Designer", "1.0")]
        public Google.MobileAds.BannerView GADBannerView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (GADBannerView != null) {
                GADBannerView.Dispose ();
                GADBannerView = null;
            }
        }
    }
}