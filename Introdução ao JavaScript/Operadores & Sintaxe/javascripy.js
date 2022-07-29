let salary = Number()
let percent

if (salary != 0 && salary <= 400.0) {
  percent = 15
} else if (salary >= 400.01 && salary <= 800.0) {
  percent = 12
} else if (salary >= 800.01 && salary <= 1200.0) {
  percent = 10
} else if (salary >= 1200.01 && salary <= 2000.0) {
  percent = 7
} else {
  percent = 4
}

let reajust = (salary * percent) / 100
let newSalary = salary + reajust

console.log('Novo salario: ' + newSalary.toFixed(2))
console.log('Reajuste ganho: ' + reajust.toFixed(2))
console.log('Em percentual: ' + percent + '%')
