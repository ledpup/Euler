namespace EulerFs

module Euler26 = 
    let repetitionLength (number:int64) = let numberList = number.ToString().ToCharArray()
                                                                        |> List.ofArray
                                          numberList

    repetitionLength 123456123456L


    [1..1000] |> List.map (fun x -> 1.0 / (float x)) |> List.iter (fun x -> printfn "%A" x)