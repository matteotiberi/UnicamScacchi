using System;
using System.Collections.Generic;
using System.Linq;
using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Modello
{
    public class PezziTest
    {

        [Fact]
        public void IlPedoneBiancoPuoMuovereAvantiDiUnaCasa()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Bianco);
            //When
            bool esito = pedone.PuòMuovere(
                    colonnaPartenza: Colonna.A,
                    traversaPartenza: Traversa.Seconda,
                    colonnaArrivo: Colonna.A,
                    traversaArrivo: Traversa.Terza);

            //Then
            Assert.True(esito);
        }


        [Fact]
        public void IlPedoneNonPuòRestareFermo() {
            //Given
            Pedone pedone = new Pedone(Colore.Bianco);
            //When
            bool esito = pedone.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Prima
            );
            Assert.False(esito);
        }
        [Theory]
        [InlineData(Colore.Bianco)]
        [InlineData(Colore.Nero)]
        public void LAlfiereNonPuòRestareFermo(Colore c) {
            //Given
            Alfiere alfiere = new Alfiere(c);
            //When
            bool esito = alfiere.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Prima
            );
            Assert.False(esito);
        }
        [Theory]
        [InlineData(Colore.Bianco)]
        [InlineData(Colore.Nero)]
        public void IlCavalloNonPuòRestareFermo(Colore c) {
            //Given
            Cavallo cavallo = new Cavallo(c);
            //When
            bool esito = cavallo.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Prima
            );
            Assert.False(esito);
        }
        [Theory]
        [InlineData(Colore.Bianco)]
        [InlineData(Colore.Nero)]
        public void LaDonnaNonPuòRestareFerma(Colore c) {
            //Given
            Donna donna = new Donna(c);
            //When
            bool esito = donna.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Prima
            );
            Assert.False(esito);
        }
        [Theory]
        [InlineData(Colore.Bianco)]
        [InlineData(Colore.Nero)]
        public void IlReNonPuòRestareFermo(Colore c) {
            //Given
            Re re = new Re(c);
            //When
            bool esito = re.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Prima
            );
            Assert.False(esito);
        }
        [Theory]
        [InlineData(Colore.Bianco)]
        [InlineData(Colore.Nero)]
        public void LaTorreNonPuòRestareFerma(Colore c) {
            //Given
            var torre = new Torre(c);
            //When
            bool esito = torre.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Prima
            );
            Assert.False(esito);
        }

        [Fact]
        public void IlCavalloPuòMuovereAvantiASinistraDiDueCase()
        {
        //Given
        Cavallo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.C,
            traversaArrivo: Traversa.Sesta);
        //Then
        Assert.True(esito);
        }

                [Fact]
        public void IlCavalloPuòMuovereAvantiADestraDiDueCase()
        {
        //Given
        Cavallo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.E,
            traversaArrivo: Traversa.Sesta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloPuòMuovereIndietroASinistraDiDueCase()
        {
        //Given
        Cavallo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.C,
            traversaArrivo: Traversa.Seconda);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloPuòMuovereIndietroADestraDiDueCase()
        {
        //Given
        Cavallo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.E,
            traversaArrivo: Traversa.Seconda);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloPuòMuovereADestraAvantiDiUnaCasa()
        {
        //Given
        Cavallo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.F,
            traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloPuòMuovereADestraIndietroDiUnaCasa()
        {
        //Given
        Cavallo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.F,
            traversaArrivo: Traversa.Terza);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloPuòMuovereASinistraAvantiDiUnaCasa()
        {
        //Given
        Cavallo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.B,
            traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloPuòMuovereASinistraIndietroDiUnaCasa()
        {
        //Given
        Cavallo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.B,
            traversaArrivo: Traversa.Terza);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaTorreMuoveAvantiDiUnaCasa()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaTorreMuoveIndietroDiUnaCasa()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Terza);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaTorreMuoveAvantiDiDueCase()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Sesta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaTorreMuoveIndietroDiDueCase()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Seconda);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaTorreMuoveAvantiDiQuattroCase()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Ottava);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaTorreMuoveIndietroDiTreCase()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Prima);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LaTorreMuoveASinistraDiUnaCasa()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.E,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaTorreMuoveADestraDiUnaCasa()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.G,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaTorreMuoveASinistraDiDueCase()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.D,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaTorreMuoveADestraDiDueCase()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.H,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaTorreMuoveASinistraDiQuattroCase()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.B,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaTorreMuoveASinistraDiCinqueCase()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.A,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        public void LaTorreNonPuòRimanereFermaUnaVoltaScelta()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.False(esito);
        }

        [Fact]
        public void LAlfiereMuoveAvantiADestradiUnaCasa()
        {
        //Given
        Alfiere alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.E,
        traversaArrivo: Traversa.Sesta);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LAlfiereMuoveAvantiADestradiDueCase()
        {
        //Given
        Alfiere alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Settima);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LAlfiereMuoveAvantiADestradiTreCase()
        {
        //Given
        Alfiere alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.G,
        traversaArrivo: Traversa.Ottava);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LAlfiereMuoveAvantiASinistradiUnaCasa()
        {
        //Given
        Alfiere alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.C,
        traversaArrivo: Traversa.Sesta);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LAlfiereMuoveAvantiASinistradiDueCase()
        {
        //Given
        Alfiere alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.B,
        traversaArrivo: Traversa.Settima);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LAlfiereMuoveAvantiASinistradiTreCase()
        {
        //Given
        Alfiere alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.A,
        traversaArrivo: Traversa.Ottava);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LAlfiereMuoveIndietroADestradiUnaCasa()
        {
        //Given
        Alfiere alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.E,
        traversaArrivo: Traversa.Quarta);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LAlfiereMuoveIndietroADestradiDueCase()
        {
        //Given
        Alfiere alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Terza);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LAlfiereMuoveIndietroADestradiTreCase()
        {
        //Given
        Alfiere alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.G,
        traversaArrivo: Traversa.Seconda);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LAlfiereMuoveIndietroADestradiQuattroCase()
        {
        //Given
        Alfiere alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.H,
        traversaArrivo: Traversa.Prima);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LAlfiereMuoveIndietroASinistradiUnaCasa()
        {
        //Given
        Alfiere alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.C,
        traversaArrivo: Traversa.Quarta);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LAlfiereMuoveIndietroASinstradiDueCase()
        {
        //Given
        Alfiere alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.B,
        traversaArrivo: Traversa.Terza);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LAlfiereMuoveIndietroASinistradiTreCase()
        {
        //Given
        Alfiere alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.A,
        traversaArrivo: Traversa.Seconda);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlReMuoveAvantidiUnaCasa()
        {
        //Given
        Re re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.C,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }
        [Fact]
        public void IlReMuoveAvantiADestradiUnaCasa()
        {
        //Given
        Re re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.D,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }
        [Fact]
        public void IlReMuoveAvantiASinistradiUnaCasa()
        {
        //Given
        Re re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.B,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }
        [Fact]
        public void IlReMuoveASinistradiUnaCasa()
        {
        //Given
        Re re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.B,
        traversaArrivo: Traversa.Quarta);
        //Then
        Assert.True(esito);
        }
        
        [Fact]
        public void IlReMuoveADestradiUnaCasa()
        {
        //Given
        Re re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.D,
        traversaArrivo: Traversa.Quarta);
        //Then
        Assert.True(esito);
        }
        
        [Fact]
        public void IlReMuoveIndietrodiUnaCasa()
        {
        //Given
        Re re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.C,
        traversaArrivo: Traversa.Terza);
        //Then
        Assert.True(esito);
        }
        [Fact]
        public void IlReMuoveIndietroADestradiUnaCasa()
        {
        //Given
        Re re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.D,
        traversaArrivo: Traversa.Terza);
        //Then
        Assert.True(esito);
        }
        [Fact]
        public void IlReMuoveIndieitroASinistradiUnaCasa()
        {
        //Given
        Re re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.B,
        traversaArrivo: Traversa.Terza);
        //Then
        Assert.True(esito);
        }
        [Fact]
        public void IlReNonMuovediDueCasa()
        {
        //Given
        Re re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.C,
        traversaArrivo: Traversa.Sesta);
        //Then
        Assert.False(esito);
        }
        
        [Fact]
        public void LaDonnaMuoveAvantidiUnaCasa()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.C,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }
        [Fact]
        public void LaDonnaMuoveAvantiADestradiUnaCasa()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.D,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }
        [Fact]
        public void LaDonnaMuoveAvantiASinistradiUnaCasa()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.B,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }
        [Fact]
        public void LaDonnaMuoveASinistradiUnaCasa()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.B,
        traversaArrivo: Traversa.Quarta);
        //Then
        Assert.True(esito);
        }
        
        [Fact]
        public void LaDonnaMuoveADestradiUnaCasa()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.D,
        traversaArrivo: Traversa.Quarta);
        //Then
        Assert.True(esito);
        }
        
        [Fact]
        public void LaDonnaMuoveIndietrodiUnaCasa()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.C,
        traversaArrivo: Traversa.Terza);
        //Then
        Assert.True(esito);
        }
        [Fact]
        public void LaDonnaMuoveIndietroADestradiUnaCasa()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.D,
        traversaArrivo: Traversa.Terza);
        //Then
        Assert.True(esito);
        }
        [Fact]
        public void LaDonnaMuoveIndieitroASinistradiUnaCasa()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.C,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.B,
        traversaArrivo: Traversa.Terza);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LaDonnaMuoveAvantiDiUnaCasa()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaDonnaMuoveIndietroDiUnaCasa()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Terza);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaDonnaMuoveAvantiDiDueCase()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Sesta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaDonnaMuoveIndietroDiDueCase()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Seconda);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaDonnaMuoveAvantiDiQuattroCase()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Ottava);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaDonnaMuoveIndietroDiTreCase()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quarta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Prima);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LaDonnaMuoveASinistraDiUnaCasa()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.E,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaDonnaMuoveADestraDiUnaCasa()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.G,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaDonnaMuoveASinistraDiDueCase()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.D,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaDonnaMuoveADestraDiDueCase()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.H,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaDonnaMuoveASinistraDiQuattroCase()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.B,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaDonnaMuoveASinistraDiCinqueCase()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.A,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        public void LaDonnaNonPuòRimanereFermaUnaVoltaScelta()
        {
        //Given
        Donna donna = new Donna(Colore.Bianco);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.F,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Quinta);
        //Then
        Assert.False(esito);
        }

        [Fact]
        public void LaDonnaMuoveAvantiADestradiDueCase()
        {
        //Given
        Donna donna = new Donna(Colore.Nero);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Settima);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LaDonnaMuoveAvantiADestradiTreCase()
        {
        //Given
        Donna donna = new Donna(Colore.Nero);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.G,
        traversaArrivo: Traversa.Ottava);
        //Then
        Assert.True(esito);
        }
        
        [Fact]
        public void LaDonnaMuoveAvantiASinistradiDueCase()
        {
        //Given
        Donna donna = new Donna(Colore.Nero);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.B,
        traversaArrivo: Traversa.Settima);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LaDonnaMuoveAvantiASinistradiTreCase()
        {
        //Given
        Donna donna = new Donna(Colore.Nero);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.A,
        traversaArrivo: Traversa.Ottava);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaDonnaMuoveIndietroADestradiDueCase()
        {
        //Given
        Donna donna = new Donna(Colore.Nero);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.F,
        traversaArrivo: Traversa.Terza);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LaDonnaMuoveIndietroADestradiTreCase()
        {
        //Given
        Donna donna = new Donna(Colore.Nero);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.G,
        traversaArrivo: Traversa.Seconda);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaDonnaMuoveIndietroADestradiQuattroCase()
        {
        //Given
        Donna donna = new Donna(Colore.Nero);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.H,
        traversaArrivo: Traversa.Prima);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LaDonnaMuoveIndietroASinstradiDueCase()
        {
        //Given
        Donna donna = new Donna(Colore.Nero);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.B,
        traversaArrivo: Traversa.Terza);
        //Then
        Assert.True(esito);
        }

        
        [Fact]
        public void LaDonnaMuoveIndietroASinistradiTreCase()
        {
        //Given
        Donna donna = new Donna(Colore.Nero);
        //When
        bool esito = donna.PuòMuovere(
        colonnaPartenza: Colonna.D,
        traversaPartenza: Traversa.Quinta,
        colonnaArrivo: Colonna.A,
        traversaArrivo: Traversa.Seconda);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlPedoneBiancoPuoMuovereDiagonalmenteSeCatturaUnPezzo()
        {
        //Given
        var pedone = new Pedone(Colore.Bianco);
        IEnumerable<ICasa> listaCase = new List<Casa>{ 
            new Casa(Colonna.A,Traversa.Prima){
                PezzoPresente = pedone
            },
            new Casa(Colonna.B,Traversa.Seconda){
                PezzoPresente = new Pedone(Colore.Nero)
            }
        };

        //When
        
        bool esito = pedone.PuòMuovere(
            colonnaPartenza: Colonna.A,
            traversaPartenza: Traversa.Prima,
            colonnaArrivo: Colonna.B,
            traversaArrivo: Traversa.Seconda,
            listaCase: listaCase
        );
        //Then
        Assert.True(esito);
        }
        [Fact]
        public void IlPedoneNonPuoMuovereSeHaQualcunoDavanti()
        {
        //Given
        var pedone = new Pedone(Colore.Bianco);
        IEnumerable<ICasa> listaCase = new List<Casa> {
            new Casa(Colonna.A,Traversa.Prima){
                PezzoPresente = pedone
            },
            new Casa(Colonna.A,Traversa.Seconda){
                PezzoPresente = new Pedone(Colore.Bianco)
            }
        };
        //When
        bool esito = pedone.PuòMuovere(
            colonnaPartenza: Colonna.A,
            traversaPartenza: Traversa.Prima,
            colonnaArrivo: Colonna.A,
            traversaArrivo: Traversa.Seconda,
            listaCase: listaCase
        );
        //Then
        Assert.False(esito);
        }

        [Fact]
        public void IlPedoneNonPuoMuovereDiDueCaseInAvantiSeCaseNelPercorsoSonoOccupate()
        {
        //Given
        var pedone = new Pedone(Colore.Bianco);
        IEnumerable<ICasa> listaCase = new List<Casa> {
            new Casa(Colonna.A,Traversa.Seconda){
                PezzoPresente = pedone
            },
            new Casa(Colonna.A,Traversa.Terza){
                PezzoPresente = new Pedone(Colore.Bianco)
            },
            new Casa(Colonna.A, Traversa.Quarta)
        };
        //When
        bool esito = pedone.PuòMuovere(
            colonnaPartenza: Colonna.A,
            traversaPartenza: Traversa.Seconda,
            colonnaArrivo: Colonna.A,
            traversaArrivo: Traversa.Quarta,
            listaCase: listaCase
        );
        //Then
        Assert.False(esito);
        }

        [Fact]
        public void LAlfiereNonPuoMuovereInAvantiADestraSeCaseNelPercorsoSonoOccupate()
        {
        //Given
        var alfiere = new Alfiere(Colore.Bianco);
        IEnumerable<ICasa> listaCase = new List<Casa> {
            new Casa(Colonna.D,Traversa.Quarta){
                PezzoPresente = alfiere
            },
            new Casa(Colonna.F,Traversa.Sesta){
                PezzoPresente = new Pedone(Colore.Nero)
            },
            new Casa(Colonna.H, Traversa.Ottava)
        };
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.H,
            traversaArrivo: Traversa.Ottava,
            listaCase: listaCase
        );
        //Then
        Assert.False(esito);
        }

        [Fact]
        public void LAlfiereNonPuoMuovereInAvantiASinistraSeCaseNelPercorsoSonoOccupate()
        {
        //Given
        var alfiere = new Alfiere(Colore.Bianco);
        IEnumerable<ICasa> listaCase = new List<Casa> {
            new Casa(Colonna.D,Traversa.Quarta){
                PezzoPresente = alfiere
            },
            new Casa(Colonna.C,Traversa.Quinta){
                PezzoPresente = new Pedone(Colore.Nero)
            },
            new Casa(Colonna.A, Traversa.Settima)
        };
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.A,
            traversaArrivo: Traversa.Settima,
            listaCase: listaCase
        );
        //Then
        Assert.False(esito);
        }

        [Fact]
        public void LAlfiereNonPuoMuovereIndietroADestraSeCaseNelPercorsoSonoOccupate()
        {
        //Given
        var alfiere = new Alfiere(Colore.Bianco);
        IEnumerable<ICasa> listaCase = new List<Casa> {
            new Casa(Colonna.D,Traversa.Quarta){
                PezzoPresente = alfiere
            },
            new Casa(Colonna.F,Traversa.Seconda){
                PezzoPresente = new Pedone(Colore.Nero)
            },
            new Casa(Colonna.G, Traversa.Prima)
        };
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.G,
            traversaArrivo: Traversa.Prima,
            listaCase: listaCase
        );
        //Then
        Assert.False(esito);
        }

        [Fact]
        public void LAlfiereNonPuoMuovereIndietroASinistraSeCaseNelPercorsoSonoOccupate()
        {
        //Given
        var alfiere = new Alfiere(Colore.Bianco);
        IEnumerable<ICasa> listaCase = new List<Casa> {
            new Casa(Colonna.D,Traversa.Quarta){
                PezzoPresente = alfiere
            },
            new Casa(Colonna.C,Traversa.Terza){
                PezzoPresente = new Pedone(Colore.Nero)
            },
            new Casa(Colonna.A, Traversa.Prima)
        };
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.A,
            traversaArrivo: Traversa.Prima,
            listaCase: listaCase
        );
        //Then
        Assert.False(esito);
        }

        [Fact]
        public void LAlfierePuòMuovereIndietroASinistraSeCaseNonNelPercorsoSonoOccupate()
        {
        //Given
        var alfiere = new Alfiere(Colore.Bianco);
        IEnumerable<ICasa> listaCase = new List<Casa> {
            new Casa(Colonna.D,Traversa.Quarta){
                PezzoPresente = alfiere
            },
            new Casa(Colonna.E,Traversa.Quinta){
                PezzoPresente = new Pedone(Colore.Nero)
            },
            new Casa(Colonna.A, Traversa.Prima)
        };
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.A,
            traversaArrivo: Traversa.Prima,
            listaCase: listaCase
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LAlfierePuoMuovereInAvantiADestraSeCaseNonNelPercorsoSonoOccupate()
        {
        //Given
        var alfiere = new Alfiere(Colore.Bianco);
        IEnumerable<ICasa> listaCase = new List<Casa> {
            new Casa(Colonna.D,Traversa.Quarta){
                PezzoPresente = alfiere
            },
            new Casa(Colonna.H,Traversa.Ottava){
                PezzoPresente = new Pedone(Colore.Nero)
            },
            new Casa(Colonna.G, Traversa.Settima)
        };
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.G,
            traversaArrivo: Traversa.Settima,
            listaCase: listaCase
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void LAlfiereNonPuoMuovereInAvantiASinistraSeLaCasaÈOccupataDaUnPezzoDelloStessoColore()
        {
        //Given
        var alfiere = new Alfiere(Colore.Bianco);
        IEnumerable<ICasa> listaCase = new List<Casa> {
            new Casa(Colonna.D,Traversa.Quarta){
                PezzoPresente = alfiere
            },
            new Casa(Colonna.A,Traversa.Settima){
                PezzoPresente = new Pedone(Colore.Bianco)
            }
        };
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.A,
            traversaArrivo: Traversa.Settima,
            listaCase: listaCase
        );
        //Then
        Assert.False(esito);
        }

        [Fact]
        public void LAlfierePuoMuovereInAvantiASinistraSeLaCasaÈOccupataDaUnPezzoDiDiversoColore()
        {
        //Given
        var alfiere = new Alfiere(Colore.Bianco);
        IEnumerable<ICasa> listaCase = new List<Casa> {
            new Casa(Colonna.D,Traversa.Quarta){
                PezzoPresente = alfiere
            },
            new Casa(Colonna.A,Traversa.Settima){
                PezzoPresente = new Pedone(Colore.Nero)
            }
        };
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza: Colonna.D,
            traversaPartenza: Traversa.Quarta,
            colonnaArrivo: Colonna.A,
            traversaArrivo: Traversa.Settima,
            listaCase: listaCase
        );
        //Then
        Assert.True(esito);
        }
    }
}