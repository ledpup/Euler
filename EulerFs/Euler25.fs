namespace EulerFs

module Euler25 =
    let rec reverseFib x =
            match x with
            | x when x < 0 -> failwith "Value cannot be less than 0."
            | 1 | 2 -> 1
            | x -> reverseFib(x - 1) + reverseFib(x - 2)

    let rec forwardFib (current:bigint) (previous:bigint) count = match current with
                                                                    | current when current.ToString().Length = 1000 -> count
                                                                    | _ -> forwardFib (current + previous) current (count + 1)

    let result = forwardFib 1I 1I 2

    let imperativeFib =   let mutable previous:bigint = 1I
                          let mutable current:bigint = 1I
                          let mutable temp:bigint = 0I
                          let mutable count = 2
                          while current.ToString().Length <> 1000 do
                                temp <- current
                                current <- previous + current
                                previous <- temp
                                count <- count + 1
                          count