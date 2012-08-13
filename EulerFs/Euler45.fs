namespace EulerFs

module Euler45 = 
    let triangle number = number * (number + 1) / 2
    let pentagonal number = number * (3 * number - 1) / 2
    let hexagonal number = number * (2 * number - 1)

    let allThreeSame t p h result = triangle t = result && pentagonal 165 = result && hexagonal h = result

    let _40755 = allThreeSame 285 165 143 40755

    let rec findPentagonal number target = match number with
                                                | number when pentagonal number > target -> findPentagonal (number - 1) target
                                                | number when pentagonal number = target -> number
                                                | number when pentagonal number < target -> 0
                                                | _ -> failwith "Invalid input"

    let rec findHexagonal number target = match number with
                                                | number when hexagonal number > target -> findHexagonal (number - 1) target
                                                | number when hexagonal number = target -> number
                                                | number when hexagonal number < target -> 0
                                                | _ -> failwith "Invalid input"

    let dsa = findHexagonal 287 (triangle 287)
    let dsa2 = findPentagonal 287 (triangle 287)

    let dscv = dsa = 0 || dsa2 = 0

    let rec findTriangle t =  
                                let mutable continueLooping = true
                                let mutable x = t
                                while continueLooping do
                                       continueLooping <- (findPentagonal x (triangle x) = 0 || findHexagonal x (triangle x) = 0)
                                       if continueLooping then x <- x + 1
                                       //printfn "%A" x

                                x

    let r = findTriangle 285

    let r2 = findTriangle 286

