using System;

namespace GangOfFour.Observer
{
	public class Chart : IObserver<DataSource>
	{
		/// <summary>
		/// Used for pull style notifications
		/// </summary>
		private DataSource dataSource;

		public Chart(DataSource dataSource)
		{
			this.dataSource = dataSource;
		}

		/// <summary>
		/// For push stype notification
		/// </summary>
		public void Update(DataSource ds) => Console.WriteLine($"Chart got notified. Value set to {ds.Value}");

		/// <summary>
		/// For pull style notifications
		/// </summary>
		public void Update() => Console.WriteLine($"Chart got notified. Value set to {dataSource.Value}");
	}
}
