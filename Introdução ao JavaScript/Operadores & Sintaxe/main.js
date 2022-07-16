const line = gets().split('')
const a = line[0]
const b = line[1]
const c = line[2]

if (a + b == c || a + c == b || b + c == a || a == b || a == c || b == c) {
  print('S')
} else {
  print('N')
}

console.log(line)
