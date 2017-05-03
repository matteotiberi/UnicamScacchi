using System;
using System.Collections.Generic;
using Scacchi.Modello;

namespace Scacchi.Modello
{
    public class Tavolo : ITavolo
    {
        public Dictionary<Colore, IGiocatore> Giocatori
        {
            get;
            private set;
        }
        private readonly IScacchiera scacchiera;
        private readonly IOrologio orologio;

        public Tavolo(IScacchiera scacchiera, IOrologio orologio)
        {
            this.scacchiera = scacchiera;
            this.orologio = orologio;

        }
        public void AvviaPartita()
        {
            if (Giocatori == null)
            {
                throw new InvalidOperationException("Attenzione, prima devi indicare il nome dei giocatori");
            }
            orologio.Accendi();
            orologio.Avvia();
        }

        public void RiceviGiocatori(String nomeBianco, String nomeNero)
        {
            Giocatori = new Dictionary<Colore, IGiocatore>();
            Giocatori.Add(Colore.Bianco, new Giocatore(nomeBianco));
            Giocatori.Add(Colore.Nero, new Giocatore(nomeNero));
        }

        public void InserisciMossa(string mossa)
        {
            Coordinata partenza = interpretaCoordinataCasa(mossa.Substring(0,2));
            Coordinata arrivo = interpretaCoordinataCasa(mossa.Substring(4,2));
            
        }

        internal Coordinata interpretaCoordinataCasa(string mossa){
            Enum.TryParse<Colonna>(mossa.Substring(0,1), out Colonna colonna);
            int.TryParse(mossa.Substring(1,1), out int traversaInt);
            Traversa traversa = (Traversa) traversaInt;
            return new Coordinata(traversa, colonna);
        }
    }
}