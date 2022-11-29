using Projeto_Console.Classes;


PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica();

// ****************************** PESSOA FÍSICA *****************************

// CADASTRO
// //Endereço PF
Endereco endPf = new Endereco();
endPf.Logradouro = "Rua Lá de Casa";
endPf.Numero = 123;
endPf.Comercial = false;
//Cadastrando Pessoa Física
PessoaFisica novaPf = new PessoaFisica();
novaPf.Nome = "Eduardo Costa";
novaPf.Cpf = "5826384796";
novaPf.DataNascimento = "20/07/2006";
novaPf.Rendimento = 12000;
novaPf.Endereco = endPf;


//EXIBIÇÃO
Console.WriteLine($"***** Pessoa Física *****");

Console.WriteLine(@$"
Nome: {novaPf.Nome}
Cpf: {novaPf.Cpf}
Data Nascimento: {novaPf.DataNascimento}
Maior de Idade: {metodosPf.ValidarDataNascimento(novaPf.DataNascimento)}
Rendimento: R${novaPf.Rendimento}
Endereço: {novaPf.Endereco.Logradouro}
Número: {novaPf.Endereco.Numero}
Endereço Comercial: {novaPf.Endereco.Comercial}
");

// ****************************** PESSOA JURÍDICA *****************************

// CADASTRO
// //Endereço PJ
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

// EXIBIÇÃO
Console.WriteLine($"***** Pessoa Jurídica *****");
Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}
CNPJ Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Rendimento: R${novaPf.Rendimento}
Endereço: {novaPj.Endereco.Logradouro}
Número: {novaPj.Endereco.Numero}
Endereço Comercial: {novaPj.Endereco.Comercial}
");












// ************** Atividade ER3- ValidarDataNascimento **************
// PessoaFisica novaPf = new PessoaFisica();

// // Console.WriteLine( novaPf.ValidarDataNascimento("1982,07,20") );
// Console.WriteLine( $"Maior de Idade? {novaPf.ValidarDataNascimento("20/07/2005")}");



// ************** Get && Set **************
// Pessoa edu = new Pessoa();
// edu.Nome = "Eduardo";
// edu.SetCorDeOlhos("red");


// Console.WriteLine($"Cor dos olhos: {edu.corDeOlhos}");
// edu.SetCorDaPele("Branca");//set

// Console.WriteLine($"Cor da Pele: {edu.GetCorDaPele()}");//get






// ************** Métodos e Construtores **************

// ************** Sobrescrita **************
// PessoaFisica edu = new PessoaFisica();
// edu.Nome = "Eduardo";
// edu.Idade = 40;

// Console.WriteLine($"Nome: {edu.Nome}");
// Console.WriteLine($"Idade: {edu.Idade}");

// edu.Envelhecer();

// Console.WriteLine($"Nova Idade: {edu.Idade}");



// ************** Sobrecarga **************

// //Endereço PF
// Endereco endPf = new Endereco();
// endPf.Logradouro = "Rua Lá de Casa";
// endPf.Numero = 123;
// endPf.Comercial = false;


// Pessoa eduardoCosta = new Pessoa();
// eduardoCosta.Nome = "Eduardo Mendes da Costa";
// eduardoCosta.Endereco = endPf;
// eduardoCosta.Rendimento = 100000;


// Pessoa roseCosta = new Pessoa("Rose Mendes da Costa Santos");
// roseCosta.Endereco = endPf;
// roseCosta.Rendimento = 200000;

// Pessoa thePeople = new Pessoa("The People", endPf, 1500);

// Console.WriteLine($"Nome: {eduardoCosta.Nome}");
// Console.WriteLine($"Nome: {roseCosta.Nome}");
// Console.WriteLine($"Nome: {thePeople.Nome}");


// //Endereço PJ
// Endereco endPj = new Endereco();
// endPj.Logradouro = "Rua Niterói";
// endPj.Numero = 180;
// endPj.Comercial = true;
// //Cadastrando Pessoa Jurídica
// PessoaJuridica novaPj = new PessoaJuridica();
// novaPj.Nome = "Paulo Skaf";
// novaPj.RazaoSocial = "Serviço Nacional de Aprendizagem Industrial";
// novaPj.Cnpj = "73.482.002/0001-38";
// novaPj.Rendimento = 100000;
// novaPj.Endereco = endPj;

// //Endereço PF
// Endereco endPf = new Endereco();
// endPf.Logradouro = "Rua Lá de Casa";
// endPf.Numero = 123;
// endPf.Comercial = false;
// //Cadastrando Pessoa Física
// PessoaFisica novaPf = new PessoaFisica();
// novaPf.Nome = "Eduardo Costa";
// novaPf.Cpf = "5826384796";
// novaPf.DataNascimento = "20/07/1982";
// novaPf.Rendimento = 12000;
// novaPf.Endereco = endPf;


// //Exibindo Pessoa Física
// Console.WriteLine($"***** Pessoa Física *****");
// Console.WriteLine(@$"
// Nome: {novaPf.Nome}
// Cpf: {novaPf.Cpf}
// Data Nascimento: {novaPf.DataNascimento}
// Rendimento: R${novaPf.Rendimento}
// Endereço: {novaPf.Endereco.Logradouro}
// Número: {novaPf.Endereco.Numero}
// Endereço Comercial: {novaPf.Endereco.Comercial}
// ");

// Console.WriteLine();

// Console.WriteLine($"***** Pessoa Jurídica *****");
// Console.WriteLine(@$"
// Nome: {novaPj.Nome}
// Razão Social: {novaPj.RazaoSocial}
// CNPJ: {novaPj.Cnpj}
// Rendimento: R${novaPf.Rendimento}
// Endereço: {novaPj.Endereco.Logradouro}
// Número: {novaPj.Endereco.Numero}
// Endereço Comercial: {novaPj.Endereco.Comercial}
// ");

