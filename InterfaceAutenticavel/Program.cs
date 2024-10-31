//main

using InterfaceAutenticavel;

//IAutenticavel ia = new IAutenticavel(); Nunca acontecerá pois isso da erro de compilação

Cliente c = new Cliente();
c.Senha = 123;
IAutenticavel iaut = c;
Console.WriteLine(iaut.Autentica(123));

Gerente g = new Gerente();
g.Senha = 100;
iaut = g;
Console.WriteLine(iaut.Autentica(100));

Diretor d = new Diretor();
d.Senha = 200;
iaut = d;
Console.WriteLine(iaut.Autentica(200));