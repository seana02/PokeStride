using Stride.Engine;

namespace PokeStride
{
    class PokeStrideApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
