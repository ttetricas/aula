// Limpar a tela
Console.Clear();

// Exibe uma string no terminal
// string ---> "texto literal"

Console.Write("Etec");
Console.Write("Adolpho");
Console.Write("Berezin");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Etec");
Console.WriteLine("Adolpho");
Console.WriteLine("Berezin");

// Quebra de linha: "\n" (new line)
Console.Write("---\n---\n---\n");

// Exibir isso: \o/ --> sequência de escape
Console.WriteLine("\\o/");

// String com várias linhas
Console.WriteLine(@"Batatinha quando nasce espalha a rama pelo chão.
menininha quando dorme põe a mão no coração.
Sou pequenininha do tamanho de um botão,
carrego papai no bolso e mamãe no coração
O bolso furou e o papai caiu no chão.
Mamãe que é mais querida ficou no coração.");

// Emitir sinal sonoro
// Console.Beep();
// Thread.Sleep(1500);

// Mudar o tom
// Console.Beep(1320, 500);
// Thread.Sleep(1500);
// Console.Beep(1485, 500);
// Thread.Sleep(1500);
// Console.Beep(1650, 500);
// Thread.Sleep(1500);

// Mudar cor da letra
// Vermelho
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Etec ");
// Verde
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Adolpho ");
// Azul
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Berezin");

// Voltar à cor padrão
Console.ResetColor();

// Mudar a cor de fundo
// Vermelho
Console.BackgroundColor = ConsoleColor.Red;
Console.Write("Etec ");
// Verde
Console.BackgroundColor = ConsoleColor.Green;
Console.Write("Adolpho ");
// Azul
Console.BackgroundColor = ConsoleColor.Blue;
Console.Write("Berezin");

// Voltar à cor padrão
Console.ResetColor();
Console.WriteLine();

// Mudando ambas as cores
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Write("Etec Adolpho Berezin");

// Voltar à cor padrão
Console.ResetColor();
Console.WriteLine();

// Exibindo caixas
Console.WriteLine(@"
+---------------------+
| Boa noite, usuário! |
+---------------------+
");

// ASCII art
Console.Write(@"
      )  (
     (   ) )
      ) ( (
    _______)_");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(@"
 .-'---------|  
( C|/\/\/\/\/|
 '-./\/\/\/\/|
   '_________'
    '-------'");
Console.ResetColor();

Console.Write(@"
                                                         _..._     
                                                      .-'_..._''.  
       __.....__                    __.....__       .' .'      '.\ 
   .-''         '.              .-''         '.    / .'            
  /     .-''""'-.  `.      .|   /     .-''""'-.  `. . '              
 /     /________\   \   .' |_ /     /________\   \| |              
 |                  | .'     ||                  || |              
 \    .-------------''--.  .-'\    .-------------'. '              
  \    '-.____...---.   |  |   \    '-.____...---. \ '.          . 
   `.             .'    |  |    `.             .'   '. `._____.-'/ 
     `''-...... -'      |  '.'    `''-...... -'       `-.______ /  
                        |   /                                  `   
                        `'-'                                       
");

Console.Write("Pressione uma tecla para continuar...");
Console.ReadKey();