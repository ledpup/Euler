namespace EulerFs

module Euler55 = 
    let revNumberToString number = new string(number.ToString().ToCharArray() |> Array.rev)

    let reverseNumber number = int (revNumberToString number)
    
    let isPalindrome x = x.ToString() = revNumberToString x
                                
    let ``123456`` = reverseNumber 123456 = 654321

    let ``151`` = isPalindrome 151

