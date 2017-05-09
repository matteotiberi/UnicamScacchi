using System;
using System.Collections.Generic;
using Scacchi.Servizi;

namespace Scacchi.Modello{
<<<<<<< HEAD
    public class BloccoNote : IBloccoNote
    {
        public IEnumerable<string> LeggiMosse()
        {
            return null;
=======

    public class BloccoNote : IBloccoNote
    {
        public IEnumerable<string> RecuperaMosse()
        {
           return null;
>>>>>>> upstream/master
        }

        public async void ScriviMossa(string mossa)
        {
<<<<<<< HEAD
            Database db = new Database();
            Mossa Miamossa = new Mossa();
            Miamossa.miaMossa = mossa;
            db.Mossa.Add(Miamossa);
            await db.SaveChangesAsync();
=======
            using (DataBase db = new DataBase()){
                Mossa miaMossa = new Mossa();
                miaMossa.Valore = mossa;
                db.Mosse.Add(miaMossa);
                await db.SaveChangesAsync();
            }
>>>>>>> upstream/master
        }
    }
}