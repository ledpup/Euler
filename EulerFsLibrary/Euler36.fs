namespace EulerFsLibrary

open System

module Euler36 =

    let revNumberToCharArray x = x.ToString().ToCharArray()
                                |> Array.rev

    let revNumberToString x = String.Join(null, revNumberToCharArray x)

    let isPalindrome x = x.ToString() = revNumberToString x

    let intAsBinary (x:int) = Convert.ToString(x, 2)

    let five = "101" = intAsBinary 5

    let numbersThatArePalindromeInDecimalAndBinary = [1..1000000]
                                                        |> List.filter (fun x -> isPalindrome x && isPalindrome (intAsBinary x))
    
    let sumPalindromes = numbersThatArePalindromeInDecimalAndBinary |> List.sum