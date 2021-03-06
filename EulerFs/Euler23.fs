﻿namespace EulerFs

module Euler23 =
    let factors number = seq { for divisor in 1 .. (float >> sqrt >> int) number do
                                if number % divisor = 0 then
                                    yield divisor
                                    yield number / divisor }
                            |> Set.ofSeq
                            |> Set.toSeq
        
    let sumProperDivisors number = factors number
                                        |> Seq.filter (fun x -> x <> number)
                                        |> Seq.sum

    let isPerfectNumber number = sumProperDivisors number = number
    let isDeficientNumber number = sumProperDivisors number < number
    let isAbundantNumber number = sumProperDivisors number > number

    let four = isDeficientNumber 4
    let twelve = isAbundantNumber 12
    let twentyEight = isPerfectNumber 28

    let abundantNumbers = [1..28123]
                            |> List.filter (fun x -> isAbundantNumber x)

    let cartesian xs ys = xs |> List.collect (fun x -> ys |> List.map (fun y -> x, y))

    let sumAbundantNumbers = cartesian abundantNumbers abundantNumbers
                                        |> Seq.map (fun (x, y) -> x + y)
                                        |> Seq.filter (fun x -> x <= 28123)
                                        |> Seq.toList
    
    let nonAbundant = [1..28123] 
                            |> List.filter (fun x -> not (sumAbundantNumbers |> List.exists(fun y -> y = x)))
                            |> List.sum
                                                                