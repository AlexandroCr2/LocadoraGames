using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraGames
{
    public class Player
    {
        private int idPlayer;
        private char nomePlayer;
        private char telefonePlayer;
        private char enderecoPlayer;
        private int ativoPlayer;

        int IdPlayer { get => idPlayer; set => idPlayer = value; }
        char NomePlayer { get => nomePlayer; set => nomePlayer = value; }
        char TelefonePlayer { get => telefonePlayer; set => telefonePlayer = value; }
        char EnderecoPlayer { get => enderecoPlayer; set => enderecoPlayer = value; }
        int AtivoPlayer { get => ativoPlayer; set => ativoPlayer = value; }
    }
}
