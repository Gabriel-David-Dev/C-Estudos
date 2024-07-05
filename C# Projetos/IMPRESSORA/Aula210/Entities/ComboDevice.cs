namespace Aula210.Entities
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine($"Combodevice processing: {doc}");
        }

        public string Scan() 
        {
            return "Combodevice scan result";
        }

        public void Print(string doc)
        {
            Console.WriteLine($"Combodevice print: {doc}");
        }
    }
}
