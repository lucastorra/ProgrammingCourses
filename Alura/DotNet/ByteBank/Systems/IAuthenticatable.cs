namespace ByteBank.Systems
{
    public interface IAuthenticatable
    {
        bool Authenticate(string password);     
    }
}
