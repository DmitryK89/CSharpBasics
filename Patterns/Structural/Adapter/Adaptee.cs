namespace Patterns.Structural.Adapter
{
    /// <summary>
    /// Поставщик / Provider
    /// Содержит интерфейс (набор методов) требующий адаптации.
    /// </summary>
    public class Adaptee
    {
        public static string SpecificRequest(string convertedInput)
        {
            return convertedInput.Contains("Converted") ? "Accepted" : null;
        }
    }
}