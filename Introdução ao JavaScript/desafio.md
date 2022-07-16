Desafio 1:

const DDD = parseInt(gets());

switch (DDD) {
	case 61: print("Brasilia"); break;
	case 71: print("Salvador"); break;
	case 11: print("Sao Paulo"); break;
	case 21: print("Rio de Janeiro"); break;
	case 32: print("Juiz de Fora"); break;
	case 19: print("Campinas"); break;
	case 27: print("Vitoria"); break;
	case 31: print("Belo Horizonte"); break;
    default: print("DDD nao cadastrado");
}





Desafio 2:

// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados e a função print para imprimir a saída(output) de dados.
// Abaixo segue um exemplo de código que você pode ou não utilizar

let x = gets(); 
let y = gets(); 
let z = gets(); 

if ((x == "vertebrado") && (y == "ave")  && (z == "carnivoro")) {
  print("aguia\n");
}

//TODO: Complete os espaços em branco com uma possível solução para o desafio

if ((x == "vertebrado") && (y == "ave")  && (z == "onivoro")) {
  print(            );
}

if ((x == "vertebrado") && (y == "mamifero")  && (z == "onivoro")) {
  print(               );
}

if ((x == "vertebrado") && (y == "mamifero")  && (z == "herbivoro")) {
  print(                );
}

if ((x == "invertebrado") && (y == "inseto")  && (z == "hematofago")) {
  print(                 );
}

if ((x ==  "invertebrado") && (y == "inseto")  && (z == "herbivoro")) {
  print(                        );
}

if ((x  == "invertebrado") && (y == "anelideo") && (z == "hematofago")) {
  print(                     );
}

if ((x  == "invertebrado") && (y == "anelideo") && (z == "onivoro")) {
  print(                       );
}







// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados e a função print para imprimir a saída(output) de dados.
// Abaixo segue um exemplo de código que você pode ou não utilizar

/*
let x = gets(); 
let y = gets(); 
let z = gets(); 

if ((x == "vertebrado") && (y == "ave")  && (z == "carnivoro")) {
  print("aguia\n");
}*/


let x = gets(); 
let y = gets(); 
let z = gets(); 

function animal(x, y, z);

switch (animal){
  case (x=vertebrado) && (y=ave) && (z=carnivoro): print("aguia\n");break;
  case (x=vertebrado) && (y=ave) && (z=onivoro): print("pomba\n");break;
  case (x=vertebrado) && (y=mamifero) && (z=onivoro):  print("homem\n");break;
  case (x=vertebrado) && (y=mamifero) && (z=herbivoro): print("vaca\n");break;
  case (x=invertebrado) && (y=inseto) && (z=hematofago):print("pulga\n");break;
  case (x=invertebrado) && (y=inseto) && (z=herbivoro):print("lagarta\n");break;
  case (x=invertebrado) && (y=anelideo) && (z=hematofago):print("sanguessuga\n");break;
  case (x=invertebrado) && (y=anelideo) && (z=onivoro):print("minhoca\n");break;
} 

Desafio 3:

// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados e a função print para imprimir a saída(output) de dados.
// Abaixo segue um exemplo de código que você pode ou não utilizar

const line = gets().split("")
const a = line[0];
const b = line[1];
const c = line[2];

//TODO: Complete os espaços em branco com uma possível solução para o problema

if (a + b == c || a + c == b ||          ||         ||           ||  b == c) {
    print(        );
} else {
    print(        );
}



const line = gets()
const line = gets().split("")
const a = line[0];
const b = line[1];
const c = line[2];


if (a + b == c || a + c == b || b + c == a || a == b || a == c ||  b == c) {
    print("S");
} else {
    print("N");
}

