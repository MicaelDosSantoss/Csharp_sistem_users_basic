// See https://aka.ms/new-console-template for more information
using System;



class Progr
{
    static void Main(string[] args) {
        Console.Clear(); 
        List<Users> list_users = new List<Users>();
        
        Pergunta pergunta_users = new Pergunta(); 

        list_users.Add(new Users($"{pergunta_users.quest_name}",$"{pergunta_users.quest_email}",$"{pergunta_users.quest_senha}"));
        Console.Clear(); 

        foreach (var users in list_users){
            Console.WriteLine($"Nome: {users.Nome}, E-mail: {users.Email}, Senha: {users.Senha}\n"); 
        };
    }
}

public class Pergunta
{   
    
    public string? quest_name {get;}
    public string? quest_email {get;}
    public string? quest_senha {get;}
    public Pergunta() {
        Console.Write("Digite o sua nome: ");
        quest_name =  Console.ReadLine();
        
        Console.Write("Digite o seu e-mail: ");
        quest_email = Console.ReadLine();

        Console.Write("Digite o sua senha: ");
        quest_senha = Console.ReadLine();
    }

}