namespace OpenForExtensionClosedForModification
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> ints = [1, 8, -5, 0, 15, 18];
            SortingAlgorithms<int>(new CustomSorting(), ints);
            
        }
        public static void SortingAlgorithms<T>(ISortingStrategy<T> sorting,List<T> values)
        {
            sorting.Sorting(values);
        }
    }
}
