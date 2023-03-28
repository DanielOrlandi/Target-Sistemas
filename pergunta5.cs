using System;

class Inverter {
    static void Main(string[] args) {
        string input = "Olá! Meu nome é Daniel.";
        char[] letras = input.ToCharArray();
        int length = letras.Length;
        
        for (int i = 0; i < length / 2; i++) {
            char letraTemporario = letras[i];
            letras[i] = letras[length - i - 1];
            letras[length - i - 1] = letraTemporario;
        }

        string palavraInvertida = new string(letras);
        Console.WriteLine(palavraInvertida);
    }
}