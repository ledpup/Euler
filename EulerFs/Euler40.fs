namespace EulerFs

module Euler40 =
    let rec numberBuilder (number:string) (count:bigint) = if number.Length = 1000000 then number else numberBuilder (number + count.ToString()) (count + 1I)

    let stupidNumber = numberBuilder "" 0I

