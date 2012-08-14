namespace EulerFs

module Euler29 =

    let crossProduct l1 l2 =
                        seq { for el1 in l1 do
                                for el2 in l2 do
                                    yield el1, el2 }

    let series = crossProduct [2I..100I] [2..100] 
                                |> Seq.map (fun (x, y) -> pown x y)
                                |> Set.ofSeq
                                |> Set.count