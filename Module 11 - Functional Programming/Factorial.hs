main = do
    strX <- getLine
    let intX = read strX :: Integer


    let result = (factorial intX)
    let output = show(result)
    putStrLn(output)

factorial x =
    if (x == 1)
        then x
    else
        x * (factorial (x-1))