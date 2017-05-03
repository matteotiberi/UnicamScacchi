using System;
using System.Collections.Generic;

namespace Scacchi.Modello{
    public interface ITavolo{
        void RiceviGiocatori(String nomeBianco,String nomeNero);
        void AvviaPartita();

        void InserisciMossa(string mossa);
        Dictionary<Colore,IGiocatore> Giocatori{get;}
    }
}