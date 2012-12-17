namespace EulerFs

open System.IO

module Euler67 =
    // Note: You may need to change the path to be able to read the file from the correct location.
    let triangle = File.ReadAllLines(@"C:\Code\GitHub\Euler\EulerFs\triangle.txt")
    let euler67Data = triangle |> Array.map (fun x -> x.Split(' ') |> Array.map (fun y -> System.Convert.ToInt32(y)) |> List.ofArray) |> Array.rev

    let answer = (Euler18.maximumTotal euler67Data.[0] 1 euler67Data).[0]