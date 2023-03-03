public class AnimalFactory
{
    public IAnimal CreateAnimal<T>()
    {
        T animalType = Activator.CreateInstance<T>();
        return (IAnimal)animalType ?? throw new NullReferenceException();
    }
}