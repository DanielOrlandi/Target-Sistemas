/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Fibonacci {
    static void Main(string[] args) {
        int n = 1597; // número que desejamos verificar se pertence à sequência
        int a = 0;
        int b = 1;
        int c;
        while (b < n) {
            c = a + b;
            a = b;
            b = c;
            if (b == n) {
                Console.WriteLine("O número " + n + " pertence à sequência de Fibonacci!");
                return;
            }
        }
        Console.WriteLine("O número " + n + " não pertence à sequência de Fibonacci.");
        Console.ReadKey();
    }
}
