using System;

namespace OOP
{
     #region Caso 1

    //Caso de Herança
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
    }

    //Caso de Composição
    public class PessoaFisica2
    {
        public Pessoa Pessoa { get; set; }
        public string Cpf { get; set; }
    }

    public class TestesHerancaComposicao
    {
        public TestesHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisica
            {
                Nome = "Joao",
                DataNascimento = DateTime.Now,
                Cpf = "32165498765"
            };

            var pessoaComposicao = new PessoaFisica2
            {
                Pessoa = new Pessoa
                {
                    Nome = "Joao",
                    DataNascimento = DateTime.Now,
                },
                Cpf = "32165498765"
            };

            var nomeHeranca = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;
        }
    }

    #endregion

    #region Caso 2

    public interface IRepositorio<T>
    {
        void Adicionar(T obj);

        void Excluir(T obj);
    }

    public interface IRepositorioPessoa
    {
        void Adicionar(Pessoa obj);
    }

    public class Repositorio<T> : IRepositorio<T>
    {
        public void Adicionar(T obj)
        {

        }

        public void Excluir(T obj)
        {

        }
    }

    // A desvantagem da herança é que ela traz consigo um alto nivel de acoplamento, neste exemplo abaixo o repositorio tem acesso a todos comportamentos 
    // da classe herdada, no exemplo a seguir iremos conseguir ver o a vantagem da composição, em exibir apenas o que eu desejo
    public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
    {

    }

    //A AVantagem da composição é que eu consigo expor apenas o que eu realmente quero, neste exemplo eu não quiz exportar o comportamento de excluir
    //Com a composição é possivel ter um nivel maior de coesão e um nivel menor de acoplamento
    public class RepositorioComposicaoPessoa : IRepositorioPessoa
    {
        private readonly IRepositorio<Pessoa> _repositorioPessoa;

        public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorioPessoa)
        {
            _repositorioPessoa = repositorioPessoa;
        }

        public void Adicionar(Pessoa obj)
        {
            _repositorioPessoa.Adicionar(obj);
        }
    }

    public class TestesHerancaComposicao2
    {
        public TestesHerancaComposicao2()
        {
            var repoH = new RepositorioHerancaPessoa();
            repoH.Adicionar(new Pessoa());
            repoH.Excluir(new Pessoa());

            var repoC = new RepositorioComposicaoPessoa(new Repositorio<Pessoa>());
            repoC.Adicionar(new Pessoa());
        }
    }

    #endregion
}