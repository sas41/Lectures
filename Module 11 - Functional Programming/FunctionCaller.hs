main = do
    strFun <- getLine
    strX <- getLine
    let intX = read strX :: Integer

    let result = (execute strFun intX)
    let output = show(result)
    putStrLn(output)


execute fun x = do
    if (fun == "add1")
        then add1 x
    else if (fun == "remove1")
        then remove1 x
    else
        x

add1 x = x + 1
remove1 x = x - 1