module Euler15

// UNFINSIHED

let squares = 20
let rec countSquares point count = match point with
                                               | (x, y) when x < squares && y < squares -> countSquares (x + 1, y) (count + 1) 
                                               | (x, y) when x = squares && y < squares -> countSquares (0, y + 1) (count + 1) 
                                               //| (x, y) when x = squares && y = squares -> count + 1
                                               | _ -> count + 1

let answer = countSquares (0, 0) 0