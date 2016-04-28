using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace filog.Desktop
{
	public class SectorsTableDelegate:NSTableViewDelegate
	{
		private FlightDiaryDataSource dataSource;
		private const string CellIdentifier = "SectorsCell";

		public SectorsTableDelegate(FlightDiaryDataSource dataSource)
		{
			this.dataSource = dataSource;
		}

		public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
		{

			var view = (NSTextField)tableView.MakeView(CellIdentifier, this);
			if (view == null) {
				view = new NSTextField();
				view.Identifier = CellIdentifier;
				view.BackgroundColor = NSColor.Clear;
				view.Bordered = false;
				view.Selectable = false;
				view.Editable = false;
			}

			switch (tableColumn.Title) {
			case "Airline": 
				view.StringValue = this.dataSource.GetSectors().ToList()[(int)row].Airline;
				break;
			case "FlightNumber": 
				view.IntValue = this.dataSource.GetSectors().ToList()[(int)row].FlightNumber;
				break;
			case "Date": 
				view.StringValue = this.dataSource.GetSectors().ToList()[(int)row].Date.ToString();
				break;
			case "From": 
				view.StringValue = this.dataSource.GetSectors().ToList()[(int)row].From;
				break;
			case "To": 
				view.StringValue = this.dataSource.GetSectors().ToList()[(int)row].To;
				break;
			case "Distance": 
				view.IntValue = this.dataSource.GetSectors().ToList()[(int)row].Distance;
				break;
			case "Cabin": 
				view.StringValue = this.dataSource.GetSectors().ToList()[(int)row].Cabin;
				break;
			case "Seat": 
				view.StringValue = this.dataSource.GetSectors().ToList()[(int)row].Seat;
				break;
			case "Aircraft": 
				view.StringValue = this.dataSource.GetSectors().ToList()[(int)row].Aircraft;
				break;
			}


			return view;
		}
	}
}

