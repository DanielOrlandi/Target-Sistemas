fetch('dados.json')
  .then(response => response.json())
  .then(data => {
    let faturamentoDiario = data.faturamentoDiario;
    let menorFaturamento = faturamentoDiario[0];
    let maiorFaturamento = faturamentoDiario[0];
    let somaFaturamento = 0;
    let diasComFaturamento = 0;
    let mediaMensal = 0;
    let diasAcimaDaMedia = 0;

    for (let i = 0; i < faturamentoDiario.length; i++) {
        if (faturamentoDiario[i] != 0){
            if (faturamentoDiario[i] < menorFaturamento) {
                menorFaturamento = faturamentoDiario[i];
            }
            if (faturamentoDiario[i] > maiorFaturamento) {
                maiorFaturamento = faturamentoDiario[i];
            }
            somaFaturamento += faturamentoDiario[i];
            diasComFaturamento ++;
        }
    }
    if (diasComFaturamento != 0) {
        mediaMensal = somaFaturamento / diasComFaturamento;
    }
    for (let i = 0; i < faturamentoDiario.length; i++) {
      if (faturamentoDiario[i] > mediaMensal) {
        diasAcimaDaMedia++;
      }
    }

    console.log(`Menor faturamento do mês: R$ ${menorFaturamento}`);
    console.log(`Maior faturamento do mês: R$ ${maiorFaturamento}`);
    console.log(`Número de dias com faturamento diário acima da média mensal: ${diasAcimaDaMedia}`);
  })
  .catch(error => console.log(error));