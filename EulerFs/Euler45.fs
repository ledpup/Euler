namespace EulerFs

module Euler45 = 
    let triangle number = number * (number + 1L) / 2L
    let pentagonal number = number * (3L * number - 1L) / 2L
    let hexagonal number = number * (2L * number - 1L)

    let rec findPentagonal number target =  match number with
                                                                    | number when pentagonal number > target -> findPentagonal (number - 1L) target
                                                                    | number when pentagonal number = target -> number
                                                                    | number when pentagonal number < target -> 0L
                                                                    | _ -> failwith "Invalid input"

    let rec findHexagonal number target = match number with
                                                                    | number when hexagonal number > target -> findHexagonal (number - 1L) target
                                                                    | number when hexagonal number = target -> number
                                                                    | number when hexagonal number < target -> 0L
                                                                    | _ -> failwith "Invalid input"

    let isTrianglePentagonalAndHexagonal t = findPentagonal t (triangle t) <> 0L && findHexagonal t (triangle t) <> 0L

    let twoEightFive = isTrianglePentagonalAndHexagonal 285L

    let rec findTriangle t = if isTrianglePentagonalAndHexagonal t then triangle t else findTriangle (t + 1L)

    let nextTriangleNumber = findTriangle 286L