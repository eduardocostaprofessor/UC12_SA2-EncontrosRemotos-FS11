using Projeto_Console.Classes;



//Endereço PJ
Endereco endPj = new Endereco();
endPj.Logradouro = "Rua Niterói";
endPj.Numero = 180;
endPj.Comercial = true;
//Cadastrando Pessoa Jurídica
PessoaJuridica novaPj = new PessoaJuridica();
novaPj.Nome = "Paulo Skaf";
novaPj.RazaoSocial = "Serviço Nacional de Aprendizagem Industrial";
novaPj.Cnpj = "73.482.002/0001-38";
novaPj.Rendimento = 100000;
novaPj.Endereco = endPj;

//Endereço PF
Endereco endPf = new Endereco();
endPf.Logradouro = "Rua Lá de Casa";
endPf.Numero = 123;
endPf.Comercial = false;
//Cadastrando Pessoa Física
PessoaFisica novaPf = new PessoaFisica();
novaPf.Nome = "Eduardo Costa";
novaPf.Cpf = "5826384796";
novaPf.DataNascimento = "20/07/1982";
novaPf.Rendimento = 12000;
novaPf.Endereco = endPf;


//Exibindo Pessoa Física
Console.WriteLine($"***** Pessoa Física *****");
Console.WriteLine(@$"
Nome: {novaPf.Nome}
Cpf: {novaPf.Cpf}
Data Nascimento: {novaPf.DataNascimento}
Rendimento: R${novaPf.Rendimento}
Endereço: {novaPf.Endereco.Logradouro}
Número: {novaPf.Endereco.Numero}
Endereço Comercial: {novaPf.Endereco.Comercial}
");

Console.WriteLine();

Console.WriteLine($"***** Pessoa Jurídica *****");
Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}
Rendimento: R${novaPf.Rendimento}
Endereço: {novaPj.Endereco.Logradouro}
Número: {novaPj.Endereco.Numero}
Endereço Comercial: {novaPj.Endereco.Comercial}
");


// Pessoa novaPessoa = new Pessoa();
// novaPessoa.Nome = "Eduardo";
// novaPessoa.Endereco = "Rua lá de Casa";
// novaPessoa.Rendimento = 2000;

// Pessoa novaPessoa2 = new Pessoa();
// novaPessoa2.Nome = "Maria";
// novaPessoa2.Endereco = "Rua lá do Lado";
// novaPessoa2.Rendimento = 3000;


// Console.WriteLine($"***** Pessoa 1 *****");
// Console.WriteLine(@$"
// Nome: {novaPessoa.Nome}
// Endereço: {novaPessoa.Endereco}
// Rendimento: {novaPessoa.Rendimento}
// ");

// Console.WriteLine();

// Console.WriteLine($"***** Pessoa 2 *****");
// Console.WriteLine(@$"
// Nome: {novaPessoa2.Nome}
// Endereço: {novaPessoa2.Endereco}
// Rendimento: {novaPessoa2.Rendimento}
// ");



