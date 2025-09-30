


using System;
//using System.Windows.Forms


public class UrnaEletronica
{
 
    static int votosMSDN = 0;
    static int votosTechNet = 0;
    static int votosTheSpoke = 0;
    static int votosBranco = 0;
    static int votosNulo = 0;
    static int totalEleitores = 0;

    public static void Main(string[] args)
    {
        
        Console.WriteLine($"Data e Hora Atuais: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
        Console.WriteLine(new string('-', 40));

        
        Console.WriteLine("                Vote certo!                ");
        Console.WriteLine(new string('-', 40));

        
        string continuarVotando = "sim";

        while (continuarVotando.Equals("sim", StringComparison.OrdinalIgnoreCase))
        {
            totalEleitores++;

            
            Console.WriteLine("\n=== Menu de Votação ===");
            Console.WriteLine("1 - MSDN Brasil");
            Console.WriteLine("2 - TechNet Brasil");
            Console.WriteLine("3 - The Spoke .Net");
            Console.WriteLine("4 - Voto em branco");
            Console.WriteLine("5 - Voto nulo");
            Console.WriteLine("-----------------------");

           
            Console.Write($"Eleitor {totalEleitores} - Digite sua opção de voto (1 a 5): ");

            string input = Console.ReadLine();
            int opcao = 0;

            
            if (int.TryParse(input, out opcao))
            {
                
                switch (opcao)
                {
                    case 1:
                        votosMSDN++;
                        Console.WriteLine("Voto para 'MSDN Brasil' registrado.");
                        break;
                    case 2:
                        votosTechNet++;
                        Console.WriteLine("Voto para 'TechNet Brasil' registrado.");
                        break;
                    case 3:
                        votosTheSpoke++;
                        Console.WriteLine("Voto para 'The Spoke .Net' registrado.");
                        break;
                    case 4:
                        votosBranco++;
                        Console.WriteLine("Voto em branco registrado.");
                        break;
                    case 5:
                        votosNulo++;
                        Console.WriteLine("Voto nulo registrado.");
                        break;
                    default:
                      
                        votosNulo++;
                        Console.WriteLine($"Opção inválida ({opcao}). Voto registrado como NULO.");
                        break;
                }
            }
            else
            {
                
                votosNulo++;
                Console.WriteLine("Entrada inválida. Voto registrado como NULO.");
            }

            
            Console.Write("\nDeseja continuar votando? (Digite 'sim' para continuar): ");
            continuarVotando = Console.ReadLine();

            Console.Clear(); 
        }

        // --- FIM DA VOTAÇÃO ---

        
        ExibirResultados();
    }

    
    private static void ExibirResultados()
    {
        string resultados = $@"=== RESULTADO FINAL DA VOTAÇÃO ===

Total de Votos por Opção:
-----------------------------
1. MSDN Brasil: {votosMSDN} votos
2. TechNet Brasil: {votosTechNet} votos
3. The Spoke .Net: {votosTheSpoke} votos
4. Votos em Branco: {votosBranco} votos
5. Votos Nulos: {votosNulo} votos
-----------------------------
Total Geral de Eleitores: {totalEleitores}

Obrigado por utilizar a Urna Eletrônica Simulada!";

       
        
    }
}
