// Como podemos rodar isso em um arquivo .ts sem causar erros? 

/*
let employee = {};
employee.code = 10;
employee.name = "John";
*/

/* =================== SOLUÇÃO  =================== */

interface Funcionario {
  codigo:number,
  nome: string,
}

const funcionario: Funcionario = {
  codigo: 10,
  nome: 'João',
}
  