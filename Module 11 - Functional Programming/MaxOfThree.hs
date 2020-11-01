main = do
    strX <- getLine
    let intX = read strX :: Integer
    strY <- getLine
    let intY = read strY :: Integer
    strZ <- getLine
    let intZ = read strZ :: Integer

    let result = (maxOfThree intX intY intZ)
    let output = show(result)
    putStrLn(output)

maxOfThree x y z = max z (max x y)