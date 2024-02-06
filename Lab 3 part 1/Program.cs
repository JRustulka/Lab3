namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a dog name: ");
            string name = Console.ReadLine();
            Dog goodBoy = new Dog();
            goodBoy.name = name;
            goodBoy.color = "White";
            goodBoy.age = 3;
            Console.WriteLine($"Name: {goodBoy.name}\n Color: {goodBoy.color}\n Age: {goodBoy.age}");

            Console.WriteLine("Enter a cat name: ");
            string catName = Console.ReadLine();
            Dog kittyCat = new Dog();
            kittyCat.name = catName;
            kittyCat.color = "Orange";
            kittyCat.age = 4;
            Console.WriteLine($"Name: {kittyCat.name}\n Color: {kittyCat.color}\n Age: {kittyCat.age}");
        }
    }
}
