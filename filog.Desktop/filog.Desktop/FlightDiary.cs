using System;
using System.Data;
using Mono.Data.Sqlite;

namespace filog.Desktop
{
	public class FlightDiary
	{
		const string connectionString = "URI=file:FlightDiary.db";
		IDbConnection connection;

		public FlightDiary ()
		{
			this.connection = new SqliteConnection (connectionString);
			this.connection.Open ();
		}

		~FlightDiary() {
			this.connection.Dispose ();
		}


		public void LoadBa97Csv(string csvFilePath) {
			var deleteCommand = this.connection.CreateCommand ();
			deleteCommand.CommandText = "DELETE FROM flightsDiary";
			deleteCommand.ExecuteNonQuery ();
			deleteCommand.Dispose ();


		}
	}
}

