namespace EulerFs

module Euler55 = 
    let reverseAsString (number:bigint) = new string(number.ToString().ToCharArray() |> Array.rev)
    let reverse number = bigint.Parse(reverseAsString number)
    
    let isPalindrome x = x.ToString() = reverseAsString x
                                
    let ``123456`` = reverse 123456I = 654321I
    let ``151`` = isPalindrome 151I

    let sumNumberAndReverse number = number + reverse number

    let rec isLychrel number count = if count < 50 then 
                                        if isPalindrome (sumNumberAndReverse number) then false
                                        else isLychrel (sumNumberAndReverse number) (count + 1)
                                     else
                                        true

    let ``349`` = isLychrel 349I 0 = false
    let ``196`` = isLychrel 196I 0 = true

    let lychrelNumbersLessThan10000 = [1..9999] 
                                            |> List.filter (fun x -> isLychrel (bigint x) 0)
                                            |> List.length