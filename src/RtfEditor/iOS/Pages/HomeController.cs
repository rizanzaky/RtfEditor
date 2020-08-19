using System;

using UIKit;

namespace RtfEditor.iOS.Pages
{
    public partial class HomeController : UIViewController
    {
        public HomeController()
        {
        }

        public override void LoadView()
        {
            base.LoadView();

            View = new HomeView();
            Title = "RTF Editor";
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

