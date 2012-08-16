namespace EulerFs

module Euler29 =

    let cartesian xs ys = xs |> List.collect (fun x -> ys |> List.map (fun y -> x, y))

    let series = cartesian [2I..100I] [2..100] 
                                |> Seq.map (fun (x, y) -> pown x y)
                                |> Set.ofSeq
                                |> Set.count