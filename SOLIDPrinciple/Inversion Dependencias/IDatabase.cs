namespace SOLIDPrinciple.Inversion_Dependencias
{
    public interface IDatabase
    {
        void OpenConnection();
        void Diconnect();
    }
}
