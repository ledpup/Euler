namespace EulerFs

module Euler30 = 

    let digitPowerSum number power = number.ToString().ToCharArray()
                                    |> Array.map (fun x -> int x - int '0')
                                    |> Array.map (fun x -> pown x power)
                                    |> Array.sum

    let isDigitPowerSum number power = digitPowerSum number power = number

    let ``1634`` = isDigitPowerSum 1634 4

    let fdskjh = [2..10000000]
                    |> List.filter (fun x -> isDigitPowerSum x 5)
                    |> List.sum