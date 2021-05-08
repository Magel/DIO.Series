namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos
            private Genero Genero { get; set; }
            private string Titulo { get; set; }
            private string Descrica { get; set; }
            private int Ano { get; set; }
            private bool Excluido { get; set; }

        //Metodos
            public Serie(int id, Genero genero, string titulo, string descricao, int ano)
            {
                this.Id = id;
                this.Genero = genero
            }


    }
}