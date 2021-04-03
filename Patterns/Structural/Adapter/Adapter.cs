namespace Patterns.Structural.Adapter
{
    /// <summary>
    /// Адаптирует интерфейс Adaptee к интерфейсу Target.
    /// </summary>
    public class Adapter: Adaptee, ITarget
    {
        public string Request(string input)
        {
            var converterInput = "Converted" + input; 
            return SpecificRequest(converterInput);
        }
    }
}