namespace GangOfFour.Observer
{
	/// <summary>
	/// There is an already existing IObserver<T> Interface as part of System namespace
	/// </summary>
	public interface IObserver<T>
	{
		/// <summary>
		/// Used for push tyle notifications
		/// </summary>
		/// <param name="value"></param>
		void Update(T value);
		/// <summary>
		/// Used for pull style notifications
		/// </summary>
		void Update();
	}
}
