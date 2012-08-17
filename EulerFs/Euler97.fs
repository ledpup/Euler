namespace EulerFs

module Euler97 = 
    let stripDigits value digits = let valueAsString = value.ToString()
                                   if (valueAsString.Length <= digits) then value
                                   else uint64 (valueAsString.Substring(valueAsString.Length - digits, digits))

    let rec power number count target = if count < target then power (stripDigits (number * 2UL) 10) (count + 1) target
                                        else stripDigits (number) 10

    let ``64`` = power 2UL 1 64 = 3709551616UL

    let x = stripDigits (28433UL * (power 2UL 1 7830457) + 1UL) 10

