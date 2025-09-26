using Interfaces;

namespace Implementation2
{
    public class Second : IFirst
    {
        public void DoIt()
        {
            var a = 321 + 2 + 1 + 21;
            throw new NotImplementedException();
        }
    }
}
