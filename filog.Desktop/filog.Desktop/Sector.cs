using System;

namespace filog.Desktop
{
	public class Sector
	{
		public int SectorId { get; set; }
		public string Airline { get; set; }
		public int FlightNumber { get; set; }
		public DateTime Date { get; set; }
		public string From { get; set; }
		public string To { get; set; }
		public int Distance { get; set; }
		public string Cabin { get; set; }
		public bool IsUpgrade { get; set; }
		public string Seat { get; set; }
		public string Aircraft {get; set; }
		public Sector (int sectorId, string airline, int flightNumber, DateTime date, string from, string to, int distance)
		{
			this.SectorId = sectorId;
			this.Airline = airline;
			this.FlightNumber = flightNumber;
			this.Date = date;
			this.From = from;
			this.To = to;
			this.Distance = distance;
		}

		public Sector (int sectorId, string airline, int flightNumber, DateTime date, string from, string to, int distance, string cabin, string seat, string aircraft) : this(sectorId, airline, flightNumber, date, from, to, distance) {
			this.Cabin = cabin;
			this.Seat = seat;

			this.Aircraft = aircraft;
		}

			}
}

