namespace EulerFs

module Euler27 =
    let factors number = seq { for divisor in 1 .. (float >> sqrt >> int) number do
                                if number % divisor = 0 then
                                    yield divisor
                                    yield number / divisor }

    
    let cartesian xs ys = xs |> List.collect (fun x -> ys |> List.map (fun y -> x, y))
