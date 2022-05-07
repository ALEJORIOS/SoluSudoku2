using System.Text;
namespace Juego;

class Tablero3 {
    int[,,] tableroPosibilidades = new int[9,9,9];
    public int[,,] TableroPosibilidades { get; set; }

    public Tablero3() {
        for(int i = 0; i < 9; i++){
            for(int j = 0; j < 9; j++){
                for(int k = 0; k < 9; k++){
                    tableroPosibilidades[i,j,k] = k+1;
                }
            }
        }
        TableroPosibilidades = tableroPosibilidades;
    }

    public string printTable(int row) {
        StringBuilder SB = new StringBuilder();
        foreach (var item in tableroPosibilidades)
        {
            Console.WriteLine(item);
        }
        return SB.ToString();
    }
}