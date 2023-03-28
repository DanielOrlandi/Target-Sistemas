using System;

class Percentual {
    static void Main(string[] args) {
        double sp = 67836.43, rj = 36678.66, mg = 29229.88, es = 27165.48, outros = 19849.53;
        
        double total = sp + rj + mg + es + outros;

        double pct_sp = (sp / total) * 100;
        double pct_rj = (rj / total) * 100;
        double pct_mg = (mg / total) * 100;
        double pct_es = (es / total) * 100;
        double pct_outros = (outros / total) * 100;

        Console.WriteLine("A representação em percentual de cada estado:");
        Console.WriteLine("SP: {0:F2}%", pct_sp);
        Console.WriteLine("RJ: {0:F2}%", pct_rj);
        Console.WriteLine("MG: {0:F2}%", pct_mg);
        Console.WriteLine("ES: {0:F2}%", pct_es);
        Console.WriteLine("Outros: {0:F2}%", pct_outros);
    }
}