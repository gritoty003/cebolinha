
        Console.Write("Digite uma frase: ");
        string fraseOriginal = Console.ReadLine()!;

      
        string fraseCebolinha = fraseOriginal
            .Replace('r', 'l')
            .Replace('R', 'L');

        Console.WriteLine(fraseCebolinha);
    


