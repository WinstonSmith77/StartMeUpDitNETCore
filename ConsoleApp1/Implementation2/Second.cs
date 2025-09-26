using ImplementationInner;
using Interfaces;

namespace Implementation2
{
    public class Second : IFirst
    {
        public void DoIt()
        {
            var inner = new Inner();
            var a = 321 + 2 + 1 + 21 + 31;
            throw new NotImplementedException();
        }
    }
}
