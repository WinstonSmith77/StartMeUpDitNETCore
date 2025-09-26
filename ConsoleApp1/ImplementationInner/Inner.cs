using Interfaces;

namespace ImplementationInner
{
    public class Inner : IFirst
    {
        public void DoIt()
        {
            var a = 321 + 2 + 1 + 21;
            throw new NotImplementedException();
        }
    }
}