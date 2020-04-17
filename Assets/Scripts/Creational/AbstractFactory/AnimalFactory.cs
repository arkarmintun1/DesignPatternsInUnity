namespace Creational.AbstractFactory
{
    public class AnimalFactory: AbstractFactory
    {
        public override IHuman GetHuman(HumanType humanType)
        {
            return null;
        }

        public override IAnimal GetAnimal(AnimalType animalType)
        {
            switch (animalType)
            {
                case AnimalType.Cat:
                    IAnimal cat = new Cat();
                    return cat;
                case AnimalType.Dog:
                    IAnimal dog = new Dog();
                    return dog;
            }
            return null;
        }
    }
}