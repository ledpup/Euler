namespace EulerFs

module Euler56 =
    let digitSum number = number.ToString().ToCharArray()
                                    |> Array.map (fun x -> int x - int '0')
                                    |> Array.sum

    let _55 = digitSum 55 = 10

    let cartesian xs ys = xs |> List.collect (fun x -> ys |> List.map (fun y -> x, y))

    let dsadjkh = cartesian [1I..99I] [1..99]
                        |> List.map (fun (x, y) -> x ** y)
                        |> List.map (fun x -> digitSum x)
                        |> List.max