using System.Text;
namespace Juego;

class Tablero {

    int[,] tableroJuego = new int[9,9];
    public int[,] TableroJuego { get; set; }
    public Tablero() {
        for(int i = 0; i < 9; i++){
            for(int j = 0; j < 9; j++){
                tableroJuego[i,j] = 1;
            }
        }
        TableroJuego = tableroJuego;
    }

    public Tablero(int[,] valoresIniciales) {
        for(int i = 0; i < 9; i++){
            for(int j = 0; j < 9; j++){
                tableroJuego[i,j] = valoresIniciales[i,j];
            }
        }
        TableroJuego = tableroJuego;
    }

    public string printTable() {
        StringBuilder SB = new StringBuilder();
        for(int i = 0; i < 9; i++){
            for(int j = 0; j < 9; j++){
                SB.Append(tableroJuego[i,j]);
                if((j+1) % 3 == 0){
                    SB.Append(" ");
                }
            }
            SB.Append("\n");
            if((i+1) % 3 == 0){
                SB.Append("\n");
            }
        }
        return SB.ToString();
    }



    public override string ToString()
    {
        return printTable();
    }
}
