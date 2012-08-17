namespace EulerFs

module Euler52 = 
    let sameDigits x y = x.ToString().ToCharArray() 
                                        |> Array.forall (fun x -> y.ToString().Contains(string x))

    let sameInBoth x y = sameDigits x y && sameDigits y x

    let _125874 = sameInBoth 125874 (125874 * 2)

    let rec multipliesSame x = let hasSameDigits = sameInBoth x (2 * x) && sameInBoth x (3 * x) && sameInBoth x (4 * x) && sameInBoth x (5 * x) && sameInBoth x (6 * x)
                               if hasSameDigits then x else multipliesSame (x + 1)

    let smallestIntegerWithSameDigits = multipliesSame 1