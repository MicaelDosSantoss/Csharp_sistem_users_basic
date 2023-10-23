
public class Users
{
    public string Nome {get; set;}
    public string Email {get; set;}
    public string Senha {get; set;}

        // O metodo abaixo é um contrutor de class;
        public Users(string nome, string email, string senha) {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
}

