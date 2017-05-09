using System;
using System.Collections.Generic;
using System.Linq;
using Scacchi.Modello;
using Scacchi.Modello.Pezzi;

namespace Scacchi.Modello
{
    public class Tavolo : ITavolo
    {


        public Tavolo(IScacchiera scacchiera, IOrologio orologio, IBloccoNote bloccoNote)
        {
            Scacchiera = scacchiera;
            Orologio = orologio;
            BloccoNote = bloccoNote;
        }
        public Dictionary<Colore, IGiocatore> Giocatori { get; private set; }

        public IScacchiera Scacchiera { get; private set; }
        public IOrologio Orologio { get; private set; }

        public IBloccoNote BloccoNote {get; private set;}

        public event EventHandler<Colore> Vittoria;

        public void AvviaPartita()
        {
            if (Giocatori == null)
                throw new InvalidOperationException("Attenzione, prima devi indicare i nomi dei giocatori!");

            Orologio.Accendi();
            Orologio.Avvia();
            Orologio.TempoScaduto += (Orologio, colore) => {
                if(colore == Colore.Bianco)
                    Vittoria.Invoke(Orologio, Colore.Nero);
                else
                    Vittoria.Invoke(Orologio, Colore.Bianco);
            };
        }

        public void FinisciPartita() {
            Orologio.Reset();
            Scacchiera = new Scacchiera();
            Giocatori = null;
        }

        public void InserisciMossa(string mossa)
        {
            BloccoNote.ScriviMossa(mossa);
            Coordinata partenza = interpretaCoordinataCasa(mossa.Substring(0,2));
            Coordinata arrivo = interpretaCoordinataCasa(mossa.Substring(4,2));
            
        }

        public void RiceviGiocatori(string nomeBianco, string nomeNero)
        {
            throw new NotImplementedException();
        }

        internal Coordinata interpretaCoordinataCasa(string mossa){
            Enum.TryParse<Colonna>(mossa.Substring(0,1), out Colonna colonna);
            int.TryParse(mossa.Substring(1,1), out int traversaInt);
            Traversa traversa = (Traversa) traversaInt;
            return new Coordinata(traversa, colonna);
        }
    }
}
