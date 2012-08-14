namespace EulerFs

module Euler24 =

    let isPermutation number = let mutable numberAsString = number.ToString()
                               if numberAsString.Length = 9 then numberAsString <- "0" + numberAsString
                               numberAsString.ToCharArray()
                                                |> Set.ofArray
                                                |> Set.count = 10

    let isPermutation1 = isPermutation 1234567890
    let isPermutation2 = isPermutation 123456789
    let isNotPermutation1 = isPermutation 1123456789
    let isNotPermutation2 = isPermutation 139846536

    let rec permutations (number:uint64) count = if count = 1000000 && isPermutation number then number
                                                 else
                                                    if isPermutation number then permutations (number + 9UL) (count + 1) 
                                                    else permutations (number + 9UL) count

    let result = permutations 123456789UL 1