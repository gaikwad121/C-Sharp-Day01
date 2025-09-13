
namespace C_Pattern
{
	internal class ArrayList<T> : List<int>
	{
		public ArrayList(IEnumerable<int> collection) : base(collection)
		{
		}
	}
}