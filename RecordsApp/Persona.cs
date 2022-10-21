namespace RecordsApp;

public record Persona (string Nombre, string Apellido, int Edad);

public record Empleado (string Nombre, string Apellido, int Edad, string Profesion) : Persona(Nombre, Apellido, Edad);

public record struct Cuenta(int id, decimal monto);

public record class Empresa(string Nombre);

public record class Numero
{
    public int Num;

    public Numero(int num)
    {
        Num = num;
    }

    public override sealed string ToString()
    {
        return $"El número ingresado es {Num}";
    }
}

public record class NumeroComodin : Numero
{
    public NumeroComodin(int num) : base(num)
    {

    }
    public override sealed string ToString()
    {
        return $"El numero {Num} es un comodín";
    }
}