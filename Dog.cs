﻿using System;
namespace Pets
{
    public class Dog : Pet
    {
        public Dog(string name, string owner, double weight) : base("dog", name, owner, weight)
        {
        }

        public string bark(int count)
        {
            string barks = "";
            for (int i = 0; i < count; i++)
            {
                barks += "bark!";
            }

            return barks;
        }
    }
}