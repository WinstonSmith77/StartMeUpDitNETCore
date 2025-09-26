using Interfaces;

namespace ImplementationInner
{
    public class Inner : IFirst
    {
        public void DoIt()
        {
            var a = 321 + 2 + 1 + 215;
            throw new NotImplementedException();
        }
    }
}