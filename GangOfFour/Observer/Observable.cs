using System.Collections.Generic;

namespace GangOfFour.Observer
{
	/// <summary>
	/// Subject/Observable
	/// There is an already existing IObservable<T> Interface as part of System namespace
	/// </summary>
	public class Observable<T>
	{
		private List<IObserver<T>> observers = new List<IObserver<T>>();

		public void AddObserver(IObserver<T> observer) => observers.Add(observer);
		public void Remove(IObserver<T> observer) => observers.Remove(observer);

		public void RemoveObserver(IObserver<T> observer) => observers.Remove(observer);

		protected void PushNotifyObservers(T value) => observers.ForEach(observer => observer.Update(value));

		protected void PullNotifyObservers() => observers.ForEach(observer => observer.Update());

	}
}
