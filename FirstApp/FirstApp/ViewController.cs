// /*
//  * Project: /Users/Haubir/XamarinProjects/FirstApp/FirstApp 
//  * Class:   ViewController
//  *
//  * Version info
//  * Created: 4/24/2017
//  * Creator: Haubir - haubir95@hotmail.com
//  *
//  * Copyright notice
//  * Property of Haubir Mariwani. Do not copy, alter, distribute, or sell in any way unless given explicit permission.
//  */
using System;

using UIKit;

namespace FirstApp
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
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
