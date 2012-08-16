namespace EulerFs

module Euler28 =
    let cornersSum x = let topRight = x * x
                       let topLeft = x * x - x + 1
                       let bottomLeft = x * x - 2 * x + 2
                       let bottomRight = x * x - 3 * x + 3
                       [topRight; topLeft; bottomLeft; bottomRight;] |> List.sum

    let squaresSum = ([3..2..1001] |> List.map (fun x -> cornersSum x) |> List.sum) + 1