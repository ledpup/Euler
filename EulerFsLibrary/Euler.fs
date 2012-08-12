﻿namespace EulerFs

open System

module Euler4 =
    let revNumberToCharArray x = x.ToString().ToCharArray()
                                |> Array.rev

    let revNumberToString x = String.Join(null, revNumberToCharArray x)

    let isPalindrome x = x.ToString() = revNumberToString x

    let isProductPalindrome (x, y) = isPalindrome (x * y)

    let rec count x =
        if x >= 999 then
            x
        else
            count (x + 1)

    let palindrome =
        let mutable max = 0
        for i = 999 downto 100 do
            for j = 999 downto i do
                if i * j > max then
                    if (isProductPalindrome (i, j)) then
                        max <- i * j
        printfn "%d" max

module Euler6 = // What is the difference between the sum of the squares and the square of the sums?
    let limit = 100
    let sum = limit * (limit + 1) / 2
    let sum_sq = (2 * limit + 1) * (limit + 1) * limit / 6
    let result = int (double sum ** 2.0) - sum_sq

module Euler8 =
    let string = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450"
    let sequence = string.ToCharArray()
                |> Seq.map (fun a -> (char >> int32) <| a)
                |> Seq.map (fun x -> x - 48)
    
    let productSeq x =
        Seq.windowed x sequence
        |> Seq.map (fun i -> (i |> Seq.fold (fun acc y -> acc * y) 1))

    let highest x = productSeq x |> Seq.max  

module Euler9 =
    let square x = x * x
    let range = 
        [0..500]

module Euler13 =
    let data = [37107287533902102798797998220837590246510135740250I; 46376937677490009712648124896970078050417018260538I; 74324986199524741059474233309513058123726617309629I; 91942213363574161572522430563301811072406154908250I; 23067588207539346171171980310421047513778063246676I; 89261670696623633820136378418383684178734361726757I; 28112879812849979408065481931592621691275889832738I; 44274228917432520321923589422876796487670272189318I; 47451445736001306439091167216856844588711603153276I; 70386486105843025439939619828917593665686757934951I; 62176457141856560629502157223196586755079324193331I; 64906352462741904929101432445813822663347944758178I; 92575867718337217661963751590579239728245598838407I; 58203565325359399008402633568948830189458628227828I; 80181199384826282014278194139940567587151170094390I; 35398664372827112653829987240784473053190104293586I; 86515506006295864861532075273371959191420517255829I; 71693888707715466499115593487603532921714970056938I; 54370070576826684624621495650076471787294438377604I; 53282654108756828443191190634694037855217779295145I; 36123272525000296071075082563815656710885258350721I; 45876576172410976447339110607218265236877223636045I; 17423706905851860660448207621209813287860733969412I; 81142660418086830619328460811191061556940512689692I; 51934325451728388641918047049293215058642563049483I; 62467221648435076201727918039944693004732956340691I; 15732444386908125794514089057706229429197107928209I; 55037687525678773091862540744969844508330393682126I; 18336384825330154686196124348767681297534375946515I; 80386287592878490201521685554828717201219257766954I; 78182833757993103614740356856449095527097864797581I; 16726320100436897842553539920931837441497806860984I; 48403098129077791799088218795327364475675590848030I; 87086987551392711854517078544161852424320693150332I; 59959406895756536782107074926966537676326235447210I; 69793950679652694742597709739166693763042633987085I; 41052684708299085211399427365734116182760315001271I; 65378607361501080857009149939512557028198746004375I; 35829035317434717326932123578154982629742552737307I; 94953759765105305946966067683156574377167401875275I; 88902802571733229619176668713819931811048770190271I; 25267680276078003013678680992525463401061632866526I; 36270218540497705585629946580636237993140746255962I; 24074486908231174977792365466257246923322810917141I; 91430288197103288597806669760892938638285025333403I; 34413065578016127815921815005561868836468420090470I; 23053081172816430487623791969842487255036638784583I; 11487696932154902810424020138335124462181441773470I; 63783299490636259666498587618221225225512486764533I; 67720186971698544312419572409913959008952310058822I; 95548255300263520781532296796249481641953868218774I; 76085327132285723110424803456124867697064507995236I; 37774242535411291684276865538926205024910326572967I; 23701913275725675285653248258265463092207058596522I; 29798860272258331913126375147341994889534765745501I; 18495701454879288984856827726077713721403798879715I; 38298203783031473527721580348144513491373226651381I; 34829543829199918180278916522431027392251122869539I; 40957953066405232632538044100059654939159879593635I; 29746152185502371307642255121183693803580388584903I; 41698116222072977186158236678424689157993532961922I; 62467957194401269043877107275048102390895523597457I; 23189706772547915061505504953922979530901129967519I; 86188088225875314529584099251203829009407770775672I; 11306739708304724483816533873502340845647058077308I; 82959174767140363198008187129011875491310547126581I; 97623331044818386269515456334926366572897563400500I; 42846280183517070527831839425882145521227251250327I; 55121603546981200581762165212827652751691296897789I; 32238195734329339946437501907836945765883352399886I; 75506164965184775180738168837861091527357929701337I; 62177842752192623401942399639168044983993173312731I; 32924185707147349566916674687634660915035914677504I; 99518671430235219628894890102423325116913619626622I; 73267460800591547471830798392868535206946944540724I; 76841822524674417161514036427982273348055556214818I; 97142617910342598647204516893989422179826088076852I; 87783646182799346313767754307809363333018982642090I; 10848802521674670883215120185883543223812876952786I; 71329612474782464538636993009049310363619763878039I; 62184073572399794223406235393808339651327408011116I; 66627891981488087797941876876144230030984490851411I; 60661826293682836764744779239180335110989069790714I; 85786944089552990653640447425576083659976645795096I; 66024396409905389607120198219976047599490197230297I; 64913982680032973156037120041377903785566085089252I; 16730939319872750275468906903707539413042652315011I; 94809377245048795150954100921645863754710598436791I; 78639167021187492431995700641917969777599028300699I; 15368713711936614952811305876380278410754449733078I; 40789923115535562561142322423255033685442488917353I; 44889911501440648020369068063960672322193204149535I; 41503128880339536053299340368006977710650566631954I; 81234880673210146739058568557934581403627822703280I; 82616570773948327592232845941706525094512325230608I; 22918802058777319719839450180888072429661980811197I; 77158542502016545090413245809786882778948721859617I; 72107838435069186155435662884062257473692284509516I; 20849603980134001723930671666823555245252804609722I; 53503534226472524250874054075591789781264330331690I]

    let sumData = data |> List.sum

module Euler14 =
    let even x = x / 2L
    let odd x = 3L * x + 1L
    let collatz x = 
            if x % 2L = 0L then 
                even x 
            else 
                odd x
    
    let rec collatzList x = 
        match x with
        | x when x < 1L -> failwith "Value cannot be less than 1."
        | 1L -> 1L :: []
        | x -> x :: collatzList (collatz x)

    let longestSubList x =
            [x / 2L .. x]
            |> List.map collatzList
                            |> Seq.maxBy Seq.length
        
    let result = longestSubList 1000000L

module Euler17 =
    let mutable separator = " "
    let rec numberWord x =
        match x with
        | 1 -> "one"
        | 2 -> "two"
        | 3 -> "three"
        | 4 -> "four"
        | 5 -> "five"
        | 6 -> "six"
        | 7 -> "seven"
        | 8 -> "eight"
        | 9 -> "nine"
        | 10 -> "ten"
        | 11 -> "eleven"
        | 12 -> "twelve"
        | 13 -> "thirteen"
        | 14 -> "fourteen"
        | 15 -> "fifteen"
        | 16 -> "sixteen"
        | 17 -> "seventeen"
        | 18 -> "eighteen"
        | 19 -> "nineteen"
        | 20 -> "twenty"
        | 30 -> "thirty"
        | 40 -> "forty"
        | 50 -> "fifty"
        | 60 -> "sixty"
        | 70 -> "seventy"
        | 80 -> "eighty"
        | 90 -> "ninety"
        | x when (x > 20 && x < 100) -> numberWord (x - (x % 10)) + separator + numberWord (x % 10)
        | x when (x > 100 && (x % 100 = 0) && x < 1000) -> numberWord (x / 100) + separator + "hundred"
        | x when (x > 100 && x < 1000) -> numberWord (x / 100) + separator + "hundred" + separator + "and" + separator + numberWord (x % 100)
        | 1000 -> "one" + separator + "thousand"
        | _ -> ""
    
    let countTo x =
        [1..x]
        |> List.iter (fun x -> printfn "%s" (numberWord x))

    let rec countToList x = 
        match x with
        | h :: t -> numberWord(h) + countToList(t)
        | [] -> ""

    let justTextCountTo x =
        separator <- ""
        countToList ([1..x])

module Euler19 =
    type date = { day : int; month: int; year: int; }
    
    let equalDate (x, y) = if x.day = y.day && x.month = y.month && x.year = y.year then true else false
    let lessThanDate (x, y) = if x.year <= y.year && x.month <= y.month && x.day <= y.day then not (equalDate (x, y)) else false
    
    let febDays y = match y with
                        | y when y % 400 = 0 -> 29
                        | y when y % 100 = 0 -> 28
                        | y when y % 4 = 0 -> 29
                        | _ -> 28

    let daysInMonth (m, y) =
            match m with
            | 2 -> febDays y
            | 4 | 6 | 9 | 11 -> 30
            | _ -> 31
           
    let addDay date =
        match date.day with
        | d when d < 1 || d > daysInMonth(date.month, date.year) -> failwith "Not a valid day of the month."
        | d when d = daysInMonth(date.month, date.year) -> match date.month with 
                                                        | m when m < 1 || m > 12 -> failwith "Not a valid month."
                                                        | m when m = 12 -> { day = 1; month = 1; year = date.year + 1}
                                                        | _ -> { day = 1; month = date.month + 1; year = date.year} 
        | _ -> { day = date.day + 1; month = date.month; year = date.year}
    
    let rec addDays (x, y) = match x with
                                | y when y < 0 -> failwith "Can not subtract days."
                                | 0 -> y
                                | _ -> addDays (x - 1, (addDay y))

    let rec sundays (x, y) = if lessThanDate (x, y) then
                                    match x with
                                    | s when x.day = 1 -> x :: sundays (addDays (7, x), y)
                                    | _ -> sundays (addDays (7, x), y)
                                    else
                                        []

module Euler20 =
    let rec factorial (x : bigint) =
        if x = 0I then 1I
        else factorial (x - 1I) * x

    let convert (x : char) = Convert.ToInt32(x) - 48

    

    let sumOfDigits (x : bigint) =
            x.ToString().ToCharArray()
            |> Seq.map (string >> int)
            |> Seq.sum

module Euler25 =
    let rec fibonaci x =
            match x with
            | x when x < 0 -> failwith "Value cannot be less than 0."
            | 1 | 2 -> 1
            | x -> fibonaci(x - 1) + fibonaci(x - 2)

    
    let rec fib x n = match x with
                        | x when x.ToString().Length = 11 -> x
                        | _ -> fib (x + n) x

    let dsa = fib 1 1