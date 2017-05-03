using System.Collections.Generic;
using System.Linq;
using Scacchi.Modello;
using Xunit;

namespace Scacchi.Tests{
    public class TavoloTest{
        [Fact]
        public void TestName()
        {
        //Given
        ITavolo tavolo = new Tavolo();
        //When
        tavolo.riceviGiocatori("Bianco", "Nero");
        Dictionary<Colore,IGiocatore> dict = tavolo.Giocatori;
        IGiocatore bianco = dict[Colore.Bianco];
        IGiocatore nero = dict[Colore.Nero];
        //Then
        Assert.Equal(2,dict.Count);
        //Assert.Equal(1,dict.Where(c => c.Key == Colore.Bianco).Count());
        //Assert.Equal(1,dict.Where(c => c.Key == Colore.Nero).Count());
        Assert.Equal("Bianco", bianco.Nome);
        Assert.Equal("Nero", nero.Nome);
        }

        [Fact]
        public void allAvvioDelTestIlTavoloDeveAvereRiferimentiAllaScacchieraEAllOrologio()
        {
        //Given
        IScacchiera scacchiera = new Scacchiera();
        IOrologio orologio = new Orologio();
        ITavolo tavolo = new Tavolo(scacchiera,orologio);
        //When
        tavolo.RiceviGiocatori("","");
        tavolo.AvviaPartita();
        //Then
        Assert.NotEqual(null, tavolo.Scacchiera);
        Assert.NotEqual(null, tavolo.cacchiera);
        }
    }
}