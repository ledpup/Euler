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

        let _220 = sumProperDivisors 220 = 284
        let _284 = sumProperDivisors 284 = 220

        let test = amicablePair (220, 284)

        let second (x, y) = [1..y]
        
        let am x = [x + 1..9999]
                        |> List.filter (fun y -> amicablePair (x, y))

        let blah = am 220

        let allAmicablePairs = [1..9999]
                                    |> List.collect (fun x -> am x)
                                    |> List.sum

