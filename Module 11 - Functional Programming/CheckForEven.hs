main = do
    strInput <- getLine
    let intInput = read strInput :: Integer

    let result = (checkForEven intInput)
    let output = show(result)
    putStrLn(output)

checkForEven x = (mod x 2) == 0