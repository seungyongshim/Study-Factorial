let rec factorial (x: decimal) : decimal = 
    match x with
    | 0m  -> 1m
    | _  -> x * factorial (x - 1m) 

let rec factorial_tail (v: decimal) (acc: decimal) : decimal =
    match v with
    | 0m -> acc
    | _ -> factorial_tail (v - 1m) (acc * v)



printfn "%A" (factorial 15m)
printfn "%A" (factorial_tail 15m 1m)

// 1307674368000M
