namespace ConsoleApp1
{
   
    public class Phone //задание №1
    {
        public long Number; public string Model; public float Weight; public string Name; //задание №1
        public Phone(long number, string model, float weight, string name)
        {
            Number = number;
            Model = model;
            Weight = weight;
            Name = name;
        }
        public Phone(long number, string model, float weight) //задание №5
        {
            Number = number;
            Model = model;
            Weight = weight;

            Phone Nvidia = new Phone(898989898, "GGX007"); //задание №8

        }
        public Phone(long number, string model) //задание №6
        {
            Number = number;
            Model = model;
        }
        public Phone() //задание №7
        {
            return;
        }
        public long GetNumber(long number) //задание №4
        {
            return number;
        }
        public string Receivecall(string name)  //задание №4
        {
            string Name = "Звонит" + " " + name;
            return Name;
        }
        public void Receivecall(string name, long number) //задание №9
        {
            Name = name;
            Number = number;
        }
    }
    public partial class Program : Phone
    {
        static void Main(string[] args)
        {
            Phone Nidiva = new Phone(1234, "TG1050", 20, "Август"); //задание №2

            Console.WriteLine("Nidiva " + Nidiva.Model);
            Console.WriteLine(Nidiva.GetNumber(Nidiva.Number));
            Console.WriteLine(Nidiva.Receivecall(Nidiva.Name)); //задание №4

            Console.WriteLine("");

            Nidiva.Receivecall("Ада" + "89806789098"); //задание №9

            Phone MAD = new Phone(4567, "RX580", 15, "Аврора"); //задание №2

            Console.WriteLine("AMD " + MAD.Model);
            Console.WriteLine(MAD.GetNumber(MAD.Number));
            Console.WriteLine(MAD.Receivecall(MAD.Name));//задание №4

            Console.WriteLine("");

            MAD.Receivecall("Акайо" + "89806789097"); //задание №9

            Phone AMX = new Phone(78910, "ABC1550", 10, "Агата"); //задание №2

            Console.WriteLine("AMX " + AMX.Model);
            Console.WriteLine(AMX.GetNumber(AMX.Number));
            Console.WriteLine(AMX.Receivecall(AMX.Name));  //задание №4

            Console.WriteLine("");

            AMX.Receivecall("Агафон" + "89806789099"); //задание №9

            sendMessage(79250150922, 79250160823, 79250186697); //задание №10
            static void sendMessage(params long[] parametres)
            {
                foreach (long number in parametres)
                {
                    Console.WriteLine(number);
                }
            } 
        }
    }
}