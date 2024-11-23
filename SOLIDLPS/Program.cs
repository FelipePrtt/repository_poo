//main

using SOLIDLPS;

IPagamento ipagamento;

CartaoCredito cc = new CartaoCredito();
string idconta = "7569";
decimal valor = 100;
ipagamento = cc;
cc.ProcessarPagamento(idconta, valor);

PayPal pp = new PayPal();
idconta = "1345";
valor = 200;
ipagamento = pp;
pp.ProcessarPagamento(idconta, valor);

Especie ep = new Especie();
valor = 1233;
ipagamento = ep;
ep.ProcessarPagamento(null, valor);
