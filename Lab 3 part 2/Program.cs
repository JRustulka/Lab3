namespace Lab_3_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dogs name: ");
            string dogName = Console.ReadLine();
            Console.WriteLine("Enter the dogs color: ");
            string dogColor = Console.ReadLine();
            Console.WriteLine("Enter the dogs height: ");
            string dogHeight = Console.ReadLine();
            Console.WriteLine("Enter the dogs age: ");
            string dogAge = Console.ReadLine();
            Dog goodDog = new Dog(dogName, dogColor, dogHeight, dogAge);
            Console.WriteLine($"Name: {goodDog.Name}\nColor: {goodDog.Color}\n Height: {goodDog.Height}\nAge: {goodDog.Age}");
            goodDog.Eat();
            Console.WriteLine(goodDog.Cry());

            Console.WriteLine("Enter the cats name: ");
            string catName = Console.ReadLine();
            Console.WriteLine("Enter the cats color: ");
            string catColor = Console.ReadLine();
            Console.WriteLine("Enter the cats height: ");
            string catHeight = Console.ReadLine();
            Console.WriteLine("Enter the cats age: ");
            string catAge = Console.ReadLine();
            Cat goodCat = new Cat(catName, catColor, catHeight, catAge);
            Console.WriteLine($"Name: {goodCat.Name}\nColor: {goodCat.Color}\n Height: {goodCat.Height}\nAge: {goodCat.Age}");
            goodCat.Eat();
            Console.WriteLine(goodCat.Cry());
        }
    }
}
