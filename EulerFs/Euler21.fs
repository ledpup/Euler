namespace EulerFs

module Euler21 = 
        let factors number = seq { for divisor in 1 .. (float >> sqrt >> int) number do
                                    if number % divisor = 0 then
                                        yield divisor
                                        yield number / divisor }
        
        let sumProperDivisors number = factors number
                                            |> Seq.filter (fun x -> x <> number)
                                            |> Seq.sum

        let amicablePair (x, y) = x <> y && (sumProperDivisors y) = x && (sumProperDivisors x) = y

        let test220 = sumProperDivisors 220 = 284
        let test284 = sumProperDivisors 284 = 220

        let testAmicablePair = amicablePair (220, 284)
        
        let allAmicablePairs = [1..9999]
                                    |> List.filter (fun x -> amicablePair (x, (sumProperDivisors x)))
                                    |> List.sum