using System;
using System.Collections.Generic;
using Scacchi.Servizi;

namespace Scacchi.Modello{
    public class BloccoNote : IBloccoNote
    {
        public IEnumerable<string> LeggiMosse()
        {
            return null;
        }

        public async void ScriviMossa(string mossa)
        {
            Database db = new Database();
            Mossa Miamossa = new Mossa();
            Miamossa.miaMossa = mossa;
            db.Mossa.Add(Miamossa);
            await db.SaveChangesAsync();
        }
    }
}