
AnimalFactory animalFactory = new AnimalFactory();

List<IAnimal> animals = new List<IAnimal>();
animals.Add(animalFactory.CreateAnimal<Dog>());
animals.Add(animalFactory.CreateAnimal<Fish>());
animals.Add(animalFactory.CreateAnimal<Cat>());
animals.Add(animalFactory.CreateAnimal<Bird>());

foreach (var item in animals)
{
    string sound = item.CreateSound();
    Console.WriteLine(sound);
}

Console.ReadLine();