let x = 10
let y = 20

let add x y = x + y

let z = add x y

printf "%d\n" z

//Changes to x and y will not affect z because they are immutable
let x2 = 100
let y2 = 200

printf "%d\n" (add x2 y2)