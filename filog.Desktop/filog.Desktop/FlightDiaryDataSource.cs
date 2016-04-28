using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;

namespace filog.Desktop
{
	public class FlightDiaryDataSource : NSTableViewDataSource
	{
		const string connectionString = "URI=file:FlightDiary.db";
		IDbConnection connection;

		public FlightDiaryDataSource ()
		{
			this.connection = new SqliteConnection (connectionString);
			this.connection.Open ();
		}

		~FlightDiaryDataSource() {
			this.connection.Dispose ();
		}


		public IEnumerable<Sector> GetSectors() {
			var command = this.connection.CreateCommand ();
			command.CommandText = "SELECT * FROM Sectors";
			var reader = command.ExecuteReader ();
			while (reader.Read ()) {
				yield return new Sector (
					reader.GetInt32 (reader.GetOrdinal ("SectorId")),
					reader.GetString (reader.GetOrdinal ("Airline")),
					reader.GetInt32 (reader.GetOrdinal ("FlightNumber")),
					DateTime.Parse(reader.GetString (reader.GetOrdinal ("Date"))),
					reader.GetString (reader.GetOrdinal ("From")),
					reader.GetString (reader.GetOrdinal ("To")),
					reader.GetInt32 (reader.GetOrdinal ("Distance")),
					reader.GetString (reader.GetOrdinal ("Cabin")),
					reader.GetString (reader.GetOrdinal ("Seat")),
					reader.GetString (reader.GetOrdinal ("Aircraft")));

			}
			command.Dispose();
		}

		public override nint GetRowCount(NSTableView tableView)
		{
			//TODO: Make this dynamic
			return 6;
		}
	}
}

