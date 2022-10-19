using System.Text;
using System.Text.Json;
using WebEjemploHttp;

internal class ConsumoWebApi
{
    HttpClient httpClient;

    public ConsumoWebApi()
    {
        httpClient = new HttpClient();
    }

    public void BusacarListaPersonas()
    {
        var resultado = httpClient.GetAsync("https://localhost:7233/Persona").Result;
        var contenido = resultado.Content.ReadAsStringAsync().Result;
        Console.WriteLine(contenido);
    }

    public void CrearPersona()
    {
        Persona persona = new Persona();
        persona.Id = 9;
        persona.Nombre = "Gustavo";
        persona.Apellido = "Péz";
        persona.Dirección = "Crra 6  # 5-06";

        var content = new StringContent(JsonSerializer.Serialize(persona), Encoding.UTF8, "application/json");
        var result = httpClient.PostAsync("https://localhost:7233/Persona", content);
        var response = result.Result.Content.ReadAsStringAsync().Result;
        Console.WriteLine(response);
    }

    public void ActualizarPersona()
    {
        Persona persona = new Persona();
        persona.Id = 1;
        persona.Nombre = "Cesar";
        persona.Apellido = "Sotelo";
        persona.Dirección = "Crra 8  # 5-06";

        var content = new StringContent(JsonSerializer.Serialize(persona), Encoding.UTF8, "application/json");
        var result = httpClient.PutAsync("https://localhost:7233/Persona", content);
        var response = result.Result.Content.ReadAsStringAsync().Result;
        Console.WriteLine(response);
    }

    public void EliminarPersona()
    {
        int id = 1;
        var result = httpClient.DeleteAsync("https://localhost:7233/Persona/" + id.ToString());
        var contenido = result.Result.Content.ReadAsStringAsync().Result;
        Console.WriteLine(contenido);
    }
}