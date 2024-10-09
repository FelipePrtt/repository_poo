// main

using Heranca;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Ana";

c.Mostrar();


ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Bia";
cf.Cpf = 1112223334;
cf.Rg = 123123123;

cf.Mostrar(); //O método mostrar usado esta sendo herdado da clase Cliente, e não usando o da ClienteFisico


Cliente c2 = new Cliente(3, "Leo");
c2.Mostrar();


ClienteFisico cf2 = new ClienteFisico(4, "Bia", 1234567890,1112223334);
cf2.Mostrar();