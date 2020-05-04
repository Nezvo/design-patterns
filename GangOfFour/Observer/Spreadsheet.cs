using System;

namespace GangOfFour.Observer
{
	public class Spreadsheet : IObserver<DataSource>
	{
		/// <summary>
		/// Used for pull stype notifications
		/// </summary>
		private DataSource dataSource;

		public Spreadsheet(DataSource dataSource)
		{
			this.dataSource = dataSource;
		}

		/// <summary>
		/// For push stype notification
		/// </summary>
		public void Update(DataSource ds) => Console.WriteLine($"Spreadsheet got notified. Value set to {ds.Value}");

		/// <summary>
		/// For pull style notifications
		/// </summary>
		public void Update() => Console.WriteLine($"Spreadsheet got notified. Value set to {dataSource.Value}");
	}
}
