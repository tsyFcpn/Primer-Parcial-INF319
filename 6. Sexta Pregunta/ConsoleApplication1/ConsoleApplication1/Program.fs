// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System
let suma x y = x + y
let resta x y = x - y
let multi x y = x * y
let divi x y = x / y

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    printfn "Suma Ingrese dos numeros"
    let num1 = Console.ReadLine()
    let num2 = Console.ReadLine()
    let sum = suma num1 num2
    let print = sum.ToString() 
    Console.WriteLine(print)
    printfn "Resta Ingrese dos numeros"
    num1 = Console.ReadLine()
    num2 = Console.ReadLine()
    sum = resta num1 num2
    print = sum.ToString()
    Console.WriteLine(print)
    printfn "Multiplicacion Ingrese dos numeros"
    num1 = Console.ReadLine()
    num2 = Console.ReadLine()
    sum = multi num1 num2
    print = sum.ToString()
    Console.WriteLine(print)
    printfn "Division Ingrese dos numeros"
    num1 = Console.ReadLine()
    num2 = Console.ReadLine()
    sum = divi num1 num2
    print = sum.ToString()
    Console.WriteLine(print)
    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
