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

    let rec findTriangle t = match t with
                                            | t when findPentagonal t (triangle t) <> 0 && findHexagonal t (triangle t) <> 0 -> triangle t
                                            | t when findPentagonal t (triangle t) = 0 || findHexagonal t (triangle t) = 0 -> findTriangle t + 1
                                            | _ -> failwith "Invalid"
                                            


    let blah = findTriangle 286

