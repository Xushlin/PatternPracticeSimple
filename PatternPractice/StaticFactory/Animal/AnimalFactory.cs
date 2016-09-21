using System;

namespace PatternPractice.StaticFactory.Animal
{
    public static class AnimalFactory
    {
        public static IAnimal CreateAnimal(AnimalType animalType)
        {
            switch (animalType)
            {
                case AnimalType.Cat:
                    return new Cat();
                case AnimalType.Dog:
                    return new Dog();
                case AnimalType.Mouse:
                    return new Mouse();
                default:
                    throw new ArgumentOutOfRangeException(nameof(animalType), animalType, null);
            }
        }
    }
}