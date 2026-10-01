 //Você vai criar uma variavel que seja chamado "jogada"
 
 //Exiba as seguintes informações
 
 Console.WriteLine("""
                   ----Jokenpô----
                   Escolha a sua jogada:
                   1- Pedra
                   2- Papel
                   3- Tesoura
                   """);
 Console.Write("Sua opção");
 
 // Ler a opção da pessoa, converter para inteiro e salvar em algum lugar
 // Crie uma variavel > atribuir valor > converter para inteiro > Ler a proxima linha do console.

 int opcaoUsuario; 
 bool converteuOpcao = int.TryParse(Console.ReadLine(), out opcaoUsuario);

 while (opcaoUsuario < 1 || opcaoUsuario > 3 || !converteuOpcao)
 {
 Console.WriteLine("Erro. Tente Novamente escolhendo opções 1 e 3.");
 converteuOpcao = int.TryParse(Console.ReadLine(), out opcaoUsuario);
 }

 var aleatorio = new Random();
 int opcaoComputador = aleatorio.Next(1, 4);
 
 // Estrutura Switch-Case
 
 string escolhaUsuarioTexto;
 switch (opcaoUsuario)
 {
     case 1 :
         //Aqui vem os comandos do caso 1
         escolhaUsuarioTexto = "Pedra";
         break;
     case 2 :
         escolhaUsuarioTexto = "Papel";
         break;
     case 3 :
         escolhaUsuarioTexto = "Tesoura";
         break;
     default:
         escolhaUsuarioTexto = "nenhum";
         break;
     
 }
 
 string escolhaComputadorTexto;
 switch (opcaoUsuario)
 {
     case 1 :
         //Aqui vem os comandos do caso 1
         escolhaComputadorTexto = "Pedra";
         break;
     case 2 :
         escolhaComputadorTexto = "Papel";
         break;
     case 3 :
         escolhaComputadorTexto = "Tesoura";
         break;
     default:
         escolhaComputadorTexto = "nenhum";
         break;
     
 }
     Console.WriteLine($"O usuario escolheu {escolhaUsuarioTexto} e o computador escolheu {escolhaComputadorTexto}");
 
 
 