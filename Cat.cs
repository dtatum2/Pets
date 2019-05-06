using System;
namespace Pets
{
    public class Cat : Pet
    {
        public Cat(string name, string owner, double weight) : base("cat", name, owner, weight)
        {
        }

        public string meow(int count)
        {
            string meows = "";
            for (int i = 0; i < count; i++)
            {
                meows += "meow.";
            }

            return meows;
        }
    }
}