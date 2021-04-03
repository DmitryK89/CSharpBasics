namespace Patterns.Structural.Fasade
{
    public class Facade
    {
        private SubSystemA _subSystemA = new SubSystemA();
        private SubSystemB _subSystemB = new SubSystemB();
        private SubSystemC _subSystemC = new SubSystemC();

        public static string OperationAB()
        {
            return SubSystemA.MethodA() + SubSystemB.MethodB();
        }
        public static string OperationBC()
        {
            return SubSystemB.MethodB() + SubSystemC.MethodC();
        }
    }
}