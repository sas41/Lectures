main = do
    strX <- getLine
    let intX = read strX :: Integer

    let result = (fibonacci intX)
    let output = show(result)
    putStrLn(output)

fibonacci x = 
    if(x == 1 || x == 2)
        then (1)
    else
        (fibonacci (x-1)) + (fibonacci (x-2))