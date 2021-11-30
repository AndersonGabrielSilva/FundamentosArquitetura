namespace OOP
{
    public interface IRepositorio
    {
        void Adicionar();
    }

    public class Repositorio : IRepositorio
    {
        //public Repositorio(int a)
        //{

        //}

        public void Adicionar()
        {
            // Adiciona item
        }
    }

    public class RepositorioFake : IRepositorio
    {
        public void Adicionar()
        {
            // Adiciona item
        }
    }

    public class UsoImplementacao
    {
        public void Processo()
        {
            //Neste exemplo podemos notar o inicio de um aclopamento, pois dentro do metodo há de fato uma implementação
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    public class UsoAbstracao
    {
        private readonly IRepositorio _repositorio;

        public UsoAbstracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            // Neste exemplo podemos notar que há um baixo acoplamento, pois para o UsoAbstracao conhece apenas a interface
            _repositorio.Adicionar();
        }
    }

    public class TesteInterfaceImplementacao
    {
        public TesteInterfaceImplementacao()
        {
            var repoImp = new UsoImplementacao();
            repoImp.Processo();

            var repoAbs = new UsoAbstracao(new Repositorio());
            repoAbs.Processo();

            var repoAbsFake = new UsoAbstracao(new RepositorioFake());
            repoAbsFake.Processo();
        }
    }
}
