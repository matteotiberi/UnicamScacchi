﻿using System;
using System.Collections.Generic;
using System.Linq;
using Scacchi.Modello;
using Scacchi.Modello.Pezzi;

namespace Scacchi
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleXUnitRunner.SimpleXUnit.RunTests();
            //Console.ReadKey();
            var pedone1 = new Pedone(Colore.Bianco);
            var pedone2 = new Pedone(Colore.Bianco);
            Console.WriteLine(pedone1.Equals(pedone2));
            var dizionario = new Dictionary<Pedone, string>();
            dizionario.Add(pedone1, "Giocatore1");
            dizionario.Add(pedone2, "Giocatore1");
            /*Dictionary<int, IScacchiera> partite = new Dictionary<int, IScacchiera>();
            int contatore = 1;
            partite.Add(contatore, new Scacchiera());

            //L'utente ha mosso un pezzo
            int chiave = 2;
            if(partite.ContainsKey(chiave)){
                Console.WriteLine(partite[chiave].Case.Count());
            } else{
                Console.WriteLine("Non riesco a creare questa partita");
            }
            Console.ReadKey();
        }*/


            /*IScacchiera scacchiera = new Scacchiera();
            scacchiera
            .Case
            .ConPezzi(Colore.Bianco)
            .DiTipo<Pedone>();*/

        /*
        private static void NotificaSconfitta(object sender, Colore colore)
        {
            Console.WriteLine($"(Dal metodo): Il giocatore {colore} ha perso la partita, secondo l'orologio {sender}!");
        }
        */
    }
    }
}
