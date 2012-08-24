namespace EulerFs

module Euler18 =

    let sampleData = [| [3;]; [7; 4;]; [2; 4; 6;]; [8; 5; 9; 3;]; |]

    let findHighest numberList = numberList |> Seq.windowed 2 |> Seq.mapi (fun i el -> i, el |> Seq.max)

    let highest = findHighest [8; 5; 9; 3;]

    printfn "%A" highest