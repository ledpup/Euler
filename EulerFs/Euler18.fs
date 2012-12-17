namespace EulerFs

module Euler18 =

    let sampleData = [| [3;]; [7; 4;]; [2; 4; 6;]; [8; 5; 9; 3;]; |] |> Array.rev
    let euler18Data = [| [75;]; [95; 64;]; [17; 47; 82;]; [18; 35; 87; 10;]; [20; 04; 82; 47; 65;]; [19; 01; 23; 75; 03; 34;]; [88; 02; 77; 73; 07; 63; 67;]; [99; 65; 04; 28; 06; 16; 70; 92;]; [41; 41; 26; 56; 83; 40; 80; 70; 33;]; [41; 48; 72; 33; 47; 32; 37; 16; 94; 29;]; [53; 71; 44; 65; 25; 43; 91; 52; 97; 51; 14;]; [70; 11; 33; 28; 77; 73; 17; 78; 39; 68; 17; 57;]; [91; 71; 52; 38; 17; 14; 91; 43; 58; 50; 27; 29; 48;]; [63; 66; 04; 68; 89; 53; 67; 30; 73; 16; 69; 87; 40; 31;]; [04; 62; 98; 27; 23; 09; 70; 98; 73; 93; 38; 53; 60; 04; 23;]; |] |> Array.rev

    let findHighest numberList = numberList |> Seq.windowed 2 |> Seq.map (fun el -> el |> Seq.max) |> List.ofSeq
    let addLists a b = List.map2 (fun x y -> x + y) a b
    let sumHighest a b = addLists (findHighest a) b

    let rec maximumTotal list x (data : list<int> array) = if data.[x].Length = 1 then 
                                                            sumHighest list data.[x] 
                                                           else 
                                                            maximumTotal (sumHighest list data.[x]) (x + 1) data

    printfn "%A" (maximumTotal euler18Data.[0] 1 euler18Data)