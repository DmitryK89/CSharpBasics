namespace Patterns.Behavioral.Strategy.Base
{
    public class Context
    {
        private ISort _sortImplementation;

        public Context(ISort sortImplementation)
        {
            _sortImplementation = sortImplementation;
        }

        public void Sort(ref int[] array)
        {
            _sortImplementation.Sort(ref array);
        }
    }
}