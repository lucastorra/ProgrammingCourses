namespace ByteBank.Systems
{
    public interface Authenticatable
    {
        bool Authenticate(string password);     
    }
}
