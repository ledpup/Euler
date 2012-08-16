namespace EulerFs

module Euler45 = 
    let triangle number:int64 = number * (number + 1L) / 2L
    let pentagonal number:int64 = number * (3L * number - 1L) / 2L
    let hexagonal number:int64 = number * (2L * number - 1L)

    let rec findPentagonal (number:int64) (target:int64) =  match number with
                                                                    | number when pentagonal number > target -> findPentagonal (number - 1L) target
                                                                    | number when pentagonal number = target -> number
                                                                    | number when pentagonal number < target -> 0L
                                                                    | _ -> failwith "Invalid input"

    let rec findHexagonal (number:int64) (target:int64) = match number with
                                                                    | number when hexagonal number > target -> findHexagonal (number - 1L) target
                                                                    | number when hexagonal number = target -> number
                                                                    | number when hexagonal number < target -> 0L
                                                                    | _ -> failwith "Invalid input"

    let isTrianglePentagonalAndHexagonal (t:int64) = findPentagonal t (triangle t) <> 0L && findHexagonal t (triangle t) <> 0L

    let twoEightFive = isTrianglePentagonalAndHexagonal 285L

    let rec findTriangle (t:int64) : int64 = if isTrianglePentagonalAndHexagonal t then triangle t else findTriangle (t + 1L)

    let nextTriangleNumber = findTriangle 286L

