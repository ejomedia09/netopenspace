namespace NOS.Registration
{
	public interface IEntryFormatter
	{
		string FormatUserEntry(User user, string entryTemplate);
	}
}