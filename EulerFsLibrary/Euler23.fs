﻿namespace EulerFs

module Euler23 =
    let factors number = seq { for divisor in 1 .. (float >> sqrt >> int) number do
                                if number % divisor = 0 then
                                    yield divisor
                                    yield number / divisor }
        
    let sumProperDivisors number = factors number
                                        |> Seq.filter (fun x -> x <> number)
                                        |> Seq.sum

    let isPerfectNumber number = sumProperDivisors number = number
    let isDeficientNumber number = sumProperDivisors number < number
    let isAbundantNumber number = sumProperDivisors number > number

    let abundantNumbers = [12..28123]
                            |> List.filter (fun x -> isAbundantNumber x)