#if _NET_CORECLR
namespace System
{
    public class ApplicationException : Exception
    {
        public ApplicationException(string message) : base(message)
        {
        }
    }
}
#endif