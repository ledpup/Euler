namespace EulerFs

open System.Collections.Generic

module Euler40 =
    let processNumber number baseIndex exp = let nthExponent = (pown 10 exp)
                                             number.ToString().ToCharArray()
                                                |> List.ofArray
                                                |> List.mapi (fun index el -> if (baseIndex + index) % nthExponent = 0 then (int el - int '0') else -1)
                                                |> List.filter (fun x -> x >= 0)

    let numbers = new List<int>()

    let rec numberBuilder number index exp = let result = processNumber number index exp
                                             let newExp = if result = [] then exp else exp + 1
                                             if result <> [] then numbers.Add(result |> List.head)
                                             if number < 1000000 then numberBuilder (number + 1) (index + number.ToString().Length) newExp 
    
    numberBuilder 1 1 1

    let finalResult = Seq.fold (fun acc el -> el * acc) 1 numbers