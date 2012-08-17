namespace EulerFs

open System

module Euler36 =
    let revNumberToString x = new string (x.ToString().ToCharArray() |> Array.rev)

    let isPalindrome x = x.ToString() = revNumberToString x

    let intAsBinary (x:int) = Convert.ToString(x, 2)

    let five = "101" = intAsBinary 5

    let numbersThatArePalindromeInDecimalAndBinary = [1..1000000]
                                                        |> List.filter (fun x -> isPalindrome x && isPalindrome (intAsBinary x))
    
    let sumPalindromes = numbersThatArePalindromeInDecimalAndBinary |> List.sum