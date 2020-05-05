namespace GangOfFour.Decorator
{
	/// <summary>
	/// Decorator
	/// </summary>
	public class EncryptedCloudStream : IStream
	{
		private readonly IStream stream;

		public EncryptedCloudStream(IStream stream)
		{
			this.stream = stream;
		}

		public void Write(string data)
		{
			var encrypted = Encrypt(data);
			stream.Write(encrypted);
		}

		private string Encrypt(string data) => "#$%#&%)&$)(/$";
	}
}
