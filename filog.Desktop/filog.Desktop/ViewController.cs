using System;

using AppKit;
using Foundation;

namespace filog.Desktop
{
	public partial class ViewController : NSViewController
	{
		private int numberOfTimesClicked = 0;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
			ClickedLabel.StringValue = "Button has not been clicked yet.";
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

		partial void ClickedButton (Foundation.NSObject sender) {
			this.numberOfTimesClicked++;

			ClickedLabel.StringValue = String.Format("The button has been clicked {0} time{1}.", 
				this.numberOfTimesClicked, 
				(thisnumberOfTimesClicked < 2) ? "" : "s"
			);
		}
	}
}
