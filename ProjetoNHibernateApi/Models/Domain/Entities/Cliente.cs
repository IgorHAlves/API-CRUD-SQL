namespace ProjetoNHibernateApi.Models.Domain.Entities
{
    public class Cliente
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual string Fone { get; set; }
        public virtual string DataNascimento { get; set; }
        public virtual int Divida { get; set; }
    }
}
