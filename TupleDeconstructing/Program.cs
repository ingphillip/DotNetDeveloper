
SampleTuple sampleTuple = new SampleTuple();


(string name, int edad, bool active) = sampleTuple.GetDataFromPerson();

Console.WriteLine($"Su nombre es: {name}");
Console.WriteLine($"Su edad es: {edad}");
Console.WriteLine($"Su estado activo es: {active}");


string name1 = "Pedro";
int edad1 = 25;

(name1, edad1, bool active1) = sampleTuple.GetDataFromPerson();

Console.WriteLine($"Su nombre es: {name1}");
Console.WriteLine($"Su edad es: {edad1}");
Console.WriteLine($"Su estado activo es: {active}");

Console.Read();

public class SampleTuple
{
    public (string, int, bool) GetDataFromPerson()
    {
        string name = "Carlos";
        int edad = 40;
        bool active = true;

        return (name, edad, active);
    }
}