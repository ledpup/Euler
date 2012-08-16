namespace EulerFs

module Euler26 = 
    let rec repetition (number:char[]) repeater = 
    
    let repetitionLength (number:int64) = number.ToString().ToCharArray()
                                                                        
    repetitionLength 123456123456L


    [1..1000] |> List.map (fun x -> 1.0M / (decimal x)) |> List.iter (fun x -> printfn "%A" x)