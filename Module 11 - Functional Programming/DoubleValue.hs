main = do
    strInput <- getLine
    let intInput = read strInput :: Integer
    
    let result = (doubleValue intInput)
    let output = show(result)
    putStrLn(output)

doubleValue x = x * 2
