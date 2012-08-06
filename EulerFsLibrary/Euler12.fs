namespace EulerFsLibrary

module Euler12 = 
    let triangle x = x * (x + 1) / 2
                       
    let factors number = seq {
        for divisor in 1 .. (float >> sqrt >> int) number do
        if number % divisor = 0 then
            yield divisor
            yield number / divisor
    }

    let countDivisors x = factors x
                                |> Seq.length

    factors (triangle 12375) |> Seq.iter (printf "%d ")
    printfn "%A" (countDivisors (triangle 12375))
    
    let triangleWithXDivisors factors = seq { 1..1..1000000000 }
                                                |> Seq.find (fun a -> (countDivisors (triangle a)) > factors)

    printfn "%A" (triangleWithXDivisors 500 |> triangle) 

