namespace GangOfFour.Iterator
{
	/// <summary>
	/// There is already an existing interface IEnumerator that we could have used,
	/// but we created this for the testing purposes
	/// </summary>
	/// <typeparam name="T">Type that will be iterated through</typeparam>
	public interface IIterator<T>
	{
		bool HasNext();
		T Current();
		void Next();
	}
}
