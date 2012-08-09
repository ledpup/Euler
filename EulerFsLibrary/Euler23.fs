namespace EulerFs

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

    let twelve = isAbundantNumber 12
    let twentyEight = isPerfectNumber 28

    let abundantNumbers = [12..28123]
                            |> List.filter (fun x -> isAbundantNumber x)

    let matchingAbundantNumbers x = abundantNumbers
                                        |> List.filter (fun y -> y < x && x % y = 0)

    let dads x = matchingAbundantNumbers x
                        |> List.length
    
    let dsa x = match (dads x) with        
                        | 1 -> (matchingAbundantNumbers x).Item(0) * 2 = x
                        | y -> (matchingAbundantNumbers x) 
                                        |> List.toSeq 
                                        |> Seq.windowed 2 
                                        |> Seq.map (fun i -> (i |> Seq.fold (fun acc y -> acc + y) 1)) 
                                        |> Seq.find(fun y -> y = x) 
                                        |> Seq.length = 1
                            
                        //|> List.length

    let blah = [12..28123]
                    