
namespace Juego
{
    class Program {

        static void Main(string[] args)
        {
            int[,] matrix = new int[9,9] {{1,2,3,4,5,6,7,8,9},{1,2,3,4,5,6,7,8,9},{1,2,3,4,5,6,7,8,9},{1,2,3,4,5,6,7,8,9},{1,2,3,4,5,6,7,8,9},{1,2,3,4,5,6,7,8,9},{1,2,3,4,5,6,7,8,9},{1,2,3,4,5,6,7,8,9},{1,2,3,4,5,6,7,8,9}};
            Tablero mapa = new Tablero(matrix);
            Console.Write(mapa);
            

        }
    }
    
}