namespace GangOfFour.Observer
{
	public class DataSource : Observable<DataSource>
	{
		private int value;
		public int Value
		{
			get
			{
				return value;
			}
			set
			{
				this.value = value;
				PullNotifyObservers();
			}
		}
	}
}
