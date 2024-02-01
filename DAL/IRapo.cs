using DAL.Models;

namespace DAL
{
    public interface IRapo<T1, T2, T3>
    {
        object Create(Token token);
    }
}