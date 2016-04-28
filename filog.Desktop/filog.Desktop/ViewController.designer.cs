// WARNING
//
// This file has been generated automatically by Xamarin Studio Community to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace filog.Desktop
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTableColumn AircraftColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn AirlineColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn CabinColumn { get; set; }

		[Outlet]
		AppKit.NSTextField ClickedLabel { get; set; }

		[Outlet]
		AppKit.NSTableColumn DateColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn DistanceColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn FlightNumberColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn FromColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn SeatColumn { get; set; }

		[Outlet]
		AppKit.NSTableView SectorsTable { get; set; }

		[Outlet]
		AppKit.NSTableColumn ToColumn { get; set; }

		[Action ("ClickedButton:")]
		partial void ClickedButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ClickedLabel != null) {
				ClickedLabel.Dispose ();
				ClickedLabel = null;
			}

			if (SectorsTable != null) {
				SectorsTable.Dispose ();
				SectorsTable = null;
			}

			if (AirlineColumn != null) {
				AirlineColumn.Dispose ();
				AirlineColumn = null;
			}

			if (FlightNumberColumn != null) {
				FlightNumberColumn.Dispose ();
				FlightNumberColumn = null;
			}

			if (DateColumn != null) {
				DateColumn.Dispose ();
				DateColumn = null;
			}

			if (FromColumn != null) {
				FromColumn.Dispose ();
				FromColumn = null;
			}

			if (ToColumn != null) {
				ToColumn.Dispose ();
				ToColumn = null;
			}

			if (DistanceColumn != null) {
				DistanceColumn.Dispose ();
				DistanceColumn = null;
			}

			if (CabinColumn != null) {
				CabinColumn.Dispose ();
				CabinColumn = null;
			}

			if (SeatColumn != null) {
				SeatColumn.Dispose ();
				SeatColumn = null;
			}

			if (AircraftColumn != null) {
				AircraftColumn.Dispose ();
				AircraftColumn = null;
			}
		}
	}
}
