namespace EulerFs

open System.IO

module Euler42 = 

    let charValue (c:char) = (int c) - (int 'A') + 1

    let stringValue (s:string) = s.ToCharArray()
                                        |> List.ofArray
                                        |> List.map (fun x -> charValue (x))
                                        |> List.sum

    let triangleNumber x = x * (x + 1) / 2

    // Note: You may need to change the path to be able to read the file from the correct location.
    let words = File.ReadAllText(@"C:\Users\ledpup\Documents\GitHub\Euler\EulerFsLibrary\words.txt").Replace("\"","").Split(',')
                                                    |> List.ofArray

    let triangleNumbers = {1..100}
                           |> Seq.map (fun x -> triangleNumber x)

    let isTriangleNumber x = triangleNumbers
                                |> Seq.exists(fun y -> y = x)

    let triangleWords = words 
                            |> List.map (fun x -> stringValue x)
                            |> List.filter (fun x -> (isTriangleNumber x))

    let sumTriangleWords = triangleWords |> List.length