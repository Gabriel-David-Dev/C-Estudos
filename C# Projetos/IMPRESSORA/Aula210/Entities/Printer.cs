namespace Aula210.Entities
{
    internal class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine($"Printer processing: {doc}");
        }

        public void Print(string doc)
        {
            Console.WriteLine($"Printer print: {doc}");
        }
    }
}
