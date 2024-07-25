using System.Threading.Tasks;

namespace Bugfixapp
{
    public interface IDatabaseInitializer
    {
        public Task Seed();
    }
}
