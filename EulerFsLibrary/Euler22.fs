namespace EulerFsLibrary

open System.IO

module Euler22 = 
    let charValue (c:char) = (int c) - (int 'A') + 1

    let stringValue (s:string) = s.ToCharArray()
                                            |> List.ofArray
                                            |> List.map (fun x -> charValue (x))
                                            |> List.sum

    let Colin = stringValue "COLIN" = 53

    let sortedNames = File.ReadAllText(@"C:\Code\GitHub\Euler\EulerFsLibrary\names.txt").Replace("\"","").Split(',')
                                                    |> List.ofArray
                                                    |> List.sort

    let namesScore x = x 
                        |> List.mapi (fun index element -> index, element)
                        |> List.map (fun (index, element) -> (index + 1) * (stringValue element))

    let colinScore = (namesScore sortedNames).Item(937) = 49714

    printfn "%A" ((namesScore sortedNames) |> List.sum)