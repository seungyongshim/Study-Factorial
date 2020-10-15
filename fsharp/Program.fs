 
 let rec factorial (x: decimal) : decimal = 
    match x with
    | 0m  -> 1m
    | _  -> x * factorial (x - 1m) 

printfn "%A" (factorial 15m)
// 1307674368000M
// No Tail recursion 