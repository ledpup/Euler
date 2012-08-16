namespace EulerFs

module Euler28 =
    let cornersSum x = [x * x; x * x - x + 1; x * x - 2 * x + 2; x * x - 3 * x + 3;] |> List.sum

    let squaresSum = ([3..2..1001] |> List.map (fun x -> cornersSum x) |> List.sum) + 1