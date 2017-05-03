namespace Scacchi.Modello
{
    public struct Coordinata
    {
        public Coordinata(Traversa traversa, Colonna colonna)
        {
            Traversa = traversa;
            Colonna = colonna;
        }
        public Traversa Traversa {get;}

        public Colonna Colonna {get;}
    }
}