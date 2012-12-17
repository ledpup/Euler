module Euler34

    let rec factorial = function
        | 0 -> 1
        | n -> n * factorial(n - 1)

    let isSumOfDigitsEqualToNumber n = n.ToString().ToCharArray() 
                                                    |> Array.map (fun x -> factorial (System.Convert.ToInt32(x.ToString()))) 
                                                    |> Array.sum = n

    let test145 = isSumOfDigitsEqualToNumber 145

    let answer = [3..10000000] |> List.filter (fun x -> isSumOfDigitsEqualToNumber x) |> List.sum