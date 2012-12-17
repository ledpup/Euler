namespace EulerFs

module Euler26 = 
    
    // UNFINSIHED

    let onlyRemainder number = (1.0M / number).ToString().Split('.').[1]

    let rec countStringOccurances (text : string) (pattern : string) (i : int) c = let index = text.IndexOf(pattern, i)
                                                                                   if index = -1 then 
                                                                                        c 
                                                                                    else 
                                                                                        countStringOccurances text pattern (index + pattern.Length) (c + 1)

    let rec repeater index (string : string) longestOccurance =    if index >= (string.Length - 1) then longestOccurance
                                                                   else
                                                                       let array = string.ToCharArray()
                                                                       let charToFind = array.[index]
                                                                       let nextOccurance = string.Substring(index + 1, array.Length - (index + 1)).ToCharArray() |> Array.findIndex (fun x -> x = charToFind)
                                                                       let subString = string.Substring(index, nextOccurance + 1)
                                                                       let occurances = countStringOccurances string subString 0 0
                                                                       if occurances > 1 && occurances > longestOccurance then repeater (index + 1) string occurances 
                                                                       else repeater (index + 1) string longestOccurance

    let answer = repeater 0 (onlyRemainder 7.0M) 0
    printfn "%A" (repeater 0 (onlyRemainder 7.0M) 0)
    [1..1000] |> List.map (fun x -> 1 % x) |> List.iter (fun x -> printfn "%A" x)