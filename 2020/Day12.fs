module Day12

open Commons

let data = 
    [|
        "R90";
        "F56";
        "R90";
        "F56";
        "R90";
        "R180";
        "W5";
        "L90";
        "E2";
        "L90";
        "S5";
        "E1";
        "F11";
        "L90";
        "F46";
        "S2";
        "E2";
        "S1";
        "E2";
        "E3";
        "N4";
        "W1";
        "N4";
        "L90";
        "W4";
        "L90";
        "N1";
        "E1";
        "S4";
        "F45";
        "S4";
        "W4";
        "S1";
        "E3";
        "E3";
        "E1";
        "F76";
        "S5";
        "E1";
        "N3";
        "W2";
        "F55";
        "E3";
        "F34";
        "S2";
        "S2";
        "E3";
        "S5";
        "L90";
        "L90";
        "W5";
        "F23";
        "R90";
        "F14";
        "F21";
        "L90";
        "N3";
        "L180";
        "N3";
        "F98";
        "R180";
        "S5";
        "F94";
        "R90";
        "N5";
        "L90";
        "S3";
        "F85";
        "R90";
        "F77";
        "S1";
        "R90";
        "E3";
        "S2";
        "E5";
        "R180";
        "W3";
        "F46";
        "R90";
        "F44";
        "S3";
        "W3";
        "L180";
        "N4";
        "L90";
        "N1";
        "E2";
        "L90";
        "S4";
        "R90";
        "E1";
        "N4";
        "F100";
        "L90";
        "S4";
        "F94";
        "L180";
        "W2";
        "S1";
        "R90";
        "E5";
        "L90";
        "S4";
        "L90";
        "W3";
        "E1";
        "R270";
        "S4";
        "E2";
        "N5";
        "F3";
        "R180";
        "F21";
        "L90";
        "F57";
        "W1";
        "F77";
        "F24";
        "N4";
        "E5";
        "S3";
        "L90";
        "F64";
        "N5";
        "L90";
        "N1";
        "F42";
        "S5";
        "W1";
        "F50";
        "S1";
        "W3";
        "N5";
        "E5";
        "F19";
        "R180";
        "W4";
        "S4";
        "F20";
        "L90";
        "W1";
        "F88";
        "R90";
        "F57";
        "L90";
        "N4";
        "W5";
        "R90";
        "S3";
        "E2";
        "S1";
        "E2";
        "N1";
        "E4";
        "S1";
        "F3";
        "R90";
        "W1";
        "N4";
        "R90";
        "F38";
        "E5";
        "E1";
        "N2";
        "R90";
        "N5";
        "S4";
        "E3";
        "F8";
        "W5";
        "R90";
        "E4";
        "F19";
        "N1";
        "F50";
        "E1";
        "F54";
        "W5";
        "L90";
        "F10";
        "S2";
        "E3";
        "R90";
        "S5";
        "L90";
        "F59";
        "N3";
        "R90";
        "W5";
        "F33";
        "N4";
        "R270";
        "F46";
        "S2";
        "L270";
        "F97";
        "E4";
        "N2";
        "E5";
        "R90";
        "F31";
        "R180";
        "N1";
        "W1";
        "R90";
        "F40";
        "R90";
        "S5";
        "F15";
        "L90";
        "E2";
        "L90";
        "L90";
        "F53";
        "N4";
        "F28";
        "E5";
        "F58";
        "L90";
        "W1";
        "L90";
        "E1";
        "L90";
        "N1";
        "F42";
        "S2";
        "S3";
        "F62";
        "E5";
        "F73";
        "W1";
        "R270";
        "F10";
        "R90";
        "E5";
        "N3";
        "E4";
        "S1";
        "E2";
        "N4";
        "E4";
        "F47";
        "E3";
        "E5";
        "S5";
        "F24";
        "L90";
        "N2";
        "L180";
        "S2";
        "F82";
        "W3";
        "S2";
        "W1";
        "R90";
        "N5";
        "E3";
        "N4";
        "L90";
        "N1";
        "F53";
        "S3";
        "L90";
        "S5";
        "F88";
        "F40";
        "S1";
        "E4";
        "N4";
        "F66";
        "W3";
        "L90";
        "E1";
        "R180";
        "F73";
        "R90";
        "W4";
        "N4";
        "F85";
        "E4";
        "F66";
        "S1";
        "W4";
        "F16";
        "R180";
        "N5";
        "L90";
        "S3";
        "E4";
        "N4";
        "W2";
        "L90";
        "R90";
        "W3";
        "N5";
        "R90";
        "F45";
        "E2";
        "S5";
        "R90";
        "F6";
        "W4";
        "S2";
        "E4";
        "F74";
        "W4";
        "L90";
        "F75";
        "W2";
        "L90";
        "F97";
        "R90";
        "N4";
        "F27";
        "L180";
        "F45";
        "S1";
        "L90";
        "W2";
        "F10";
        "W3";
        "S4";
        "F42";
        "W1";
        "F30";
        "R90";
        "E2";
        "F94";
        "E5";
        "R90";
        "F41";
        "E1";
        "N3";
        "W1";
        "N2";
        "R90";
        "S5";
        "F93";
        "N1";
        "R90";
        "F38";
        "S3";
        "F50";
        "L270";
        "W1";
        "S4";
        "F64";
        "W1";
        "N1";
        "F61";
        "R90";
        "W2";
        "R90";
        "N1";
        "F31";
        "S2";
        "F7";
        "N2";
        "R90";
        "S5";
        "E3";
        "S1";
        "E1";
        "R90";
        "E2";
        "R90";
        "E4";
        "F76";
        "R90";
        "W4";
        "F15";
        "S3";
        "F2";
        "R90";
        "N4";
        "F66";
        "L180";
        "W3";
        "N2";
        "F1";
        "S4";
        "L90";
        "N1";
        "F19";
        "F20";
        "E1";
        "R90";
        "N3";
        "F54";
        "N4";
        "F62";
        "W2";
        "S1";
        "F49";
        "W3";
        "S4";
        "W3";
        "N2";
        "E4";
        "N1";
        "R90";
        "E1";
        "N2";
        "L90";
        "F46";
        "S4";
        "E2";
        "L90";
        "S3";
        "L90";
        "N4";
        "R180";
        "F56";
        "L90";
        "E2";
        "F51";
        "W1";
        "N5";
        "E2";
        "L90";
        "E3";
        "S5";
        "W3";
        "F73";
        "E5";
        "F100";
        "L90";
        "N2";
        "W2";
        "L180";
        "F89";
        "L90";
        "N3";
        "W4";
        "S2";
        "W1";
        "L270";
        "E5";
        "N2";
        "R90";
        "F65";
        "W1";
        "F41";
        "E2";
        "N4";
        "E1";
        "F73";
        "L180";
        "S4";
        "L90";
        "N4";
        "W3";
        "N4";
        "E1";
        "R180";
        "F67";
        "E5";
        "L90";
        "N5";
        "F75";
        "N3";
        "E4";
        "R90";
        "F28";
        "R90";
        "S3";
        "F77";
        "L180";
        "N2";
        "N1";
        "R90";
        "F77";
        "S3";
        "W3";
        "N4";
        "F60";
        "W4";
        "F40";
        "L90";
        "W3";
        "W3";
        "E1";
        "S2";
        "W2";
        "N1";
        "F86";
        "R180";
        "E1";
        "L180";
        "F17";
        "R90";
        "F11";
        "E1";
        "S2";
        "F48";
        "S2";
        "W2";
        "F1";
        "N5";
        "F53";
        "N2";
        "W1";
        "L180";
        "L90";
        "N5";
        "W1";
        "L180";
        "E1";
        "F67";
        "W4";
        "N3";
        "E5";
        "N1";
        "F88";
        "R90";
        "F93";
        "E1";
        "F33";
        "L90";
        "F1";
        "W2";
        "N4";
        "W3";
        "F85";
        "S1";
        "E2";
        "F69";
        "R90";
        "S4";
        "W2";
        "L90";
        "W3";
        "S5";
        "F14";
        "W1";
        "S5";
        "W2";
        "F95";
        "F30";
        "E1";
        "F4";
        "W3";
        "R90";
        "F93";
        "N5";
        "E1";
        "F9";
        "L90";
        "W5";
        "L270";
        "E1";
        "L90";
        "S2";
        "F97";
        "S1";
        "F18";
        "E3";
        "R90";
        "N1";
        "R90";
        "N5";
        "F72";
        "S4";
        "L90";
        "W3";
        "S3";
        "F13";
        "W5";
        "N2";
        "F31";
        "F17";
        "S4";
        "E2";
        "L90";
        "N5";
        "R90";
        "F42";
        "W2";
        "N1";
        "S3";
        "F60";
        "W5";
        "N4";
        "R90";
        "E5";
        "S3";
        "F88";
        "E4";
        "N5";
        "W3";
        "L180";
        "N3";
        "F66";
        "E5";
        "R270";
        "E3";
        "L180";
        "W4";
        "W3";
        "S2";
        "W1";
        "F69";
        "E5";
        "L90";
        "F23";
        "W5";
        "L90";
        "F49";
        "S3";
        "R180";
        "W2";
        "L90";
        "N1";
        "R90";
        "S4";
        "F71";
        "N5";
        "F36";
        "R180";
        "F62";
        "L180";
        "F39";
        "N5";
        "F36";
        "R180";
        "N4";
        "W4";
        "E5";
        "F94";
        "F39";
        "L90";
        "N1";
        "F70";
        "R90";
        "W2";
        "R180";
        "F16";
        "E3";
        "S1";
        "R180";
        "E1";
        "S3";
        "E5";
        "L90";
        "N5";
        "F76";
        "N4";
        "R90";
        "E3";
        "L180";
        "N3";
        "F20";
        "S3";
        "R90";
        "N3";
        "L270";
        "E4";
        "N5";
        "F49";
        "S3";
        "F79";
        "W3";
        "R270";
        "E1";
        "L180";
        "R90";
        "F34";
        "W3";
        "S5";
        "E5";
        "F76";
        "N3";
        "N5";
        "F66";
        "L90";
        "F48";
        "E1";
        "L270";
        "E3";
        "S2";
        "L180";
        "N3";
        "F1";
        "W5";
        "L90";
        "F9";
        "S5";
        "F64";
        "L180";
        "W1";
        "N1";
        "E2";
        "F4";
        "R90";
        "F81";
        "W5";
        "S4";
        "E1";
        "N4";
        "E1";
        "F61";
        "R180";
        "S2";
        "R180";
        "F24";
        "N3";
        "W5";
        "N1";
        "F67";
        "L180";
        "F50";
        "W5";
        "R90";
        "N2";
        "L180";
        "F80";
        "W5";
        "L90";
        "N1";
        "F31";
        "E5";
        "R90";
        "N5";
        "R90";
        "F93";
        "E2";
        "E3";
        "L90";
        "E2";
        "L90";
        "E1";
        "N4";
        "W4";
        "F80";
        "R180";
        "F84";
        "E5";
        "N1";
        "F37";
        "S3";
        "W5";
        "S4";
        "F9";
        "R90";
        "E2";
        "R90";
        "F39";
        "R90";
        "F77";
        "N3";
        "R90";
        "E5";
        "N2";
        "F49";
        "S2";
        "W3";
        "F42";
        "N1";
        "F19";
        "E2";
        "N3";
        "R90";
        "F48";
        "N1";
        "W3";
        "S2";
        "E3";
        "L90";
        "E1";
        "R90";
        "F100";
        "E2";
        "L90";
        "F90";
        "W1";
        "F66";
        "N4";
        "R180";
        "W2";
        "F33";
    |] |> Array.toList

type Command =
    | Nord of int
    | East of int
    | West of int
    | South of int
    | Forward of int
    | Backward of int
    | TurnLeft of int
    | TurnRight of int

let parse (s:string) =
    let n = s.[1..] |> int
    match s.[0] with
    | 'N' -> Nord n
    | 'S' -> South n
    | 'E' -> East n
    | 'W' -> West n
    | 'F' -> Forward n
    | 'B' -> Backward n
    | 'R' -> TurnRight n
    | 'L' -> TurnLeft n
    | _ -> failwith "Syntax error"

let turtle (x, y, d) c =
    match c with
    | Nord n -> (x, y+n, d)
    | East n -> (x+n, y, d)
    | South n -> (x, y-n, d)
    | West n -> (x-n, y, d)
    | Forward n ->
        match d with
        | Up -> (x, y+n, d)
        | Down -> (x, y-n, d)
        | Left -> (x-n, y, d)
        | Right -> (x+n, y, d)
    | Backward n ->
        match d with
        | Up -> (x, y-n, d)
        | Down -> (x, y+n, d)
        | Left -> (x+n, y, d)
        | Right -> (x-n, y, d)
    | TurnLeft n ->
        match (d,n) with
        | (Down, 270)
        | (Right, 180)
        | (Up,90) -> 
            (x,y, Left)
        | (Right, 270)
        | (Left, 90)
        | (Up,180) -> 
            (x,y, Down)
        | (Left, 180)
        | (Down, 90)
        | (Up,270) -> 
            (x,y, Right)
        | (Right, 90)
        | (Left, 270)
        | (Down, 180) ->
            (x, y, Up)
        | (_,_) -> failwith "Syntax error"
    | TurnRight n ->
        match (d,n) with
        | (Up, 270)
        | (Right, 180)
        | (Down,90) -> 
            (x,y, Left)
        | (Left, 270)
        | (Right, 90)
        | (Up,180) -> 
            (x,y, Down)
        | (Left , 180)
        | (Up, 90)
        | (Down,270) -> 
            (x,y, Right)
        | (Left, 90)
        | (Right, 270)
        | (Down, 180) ->
            (x, y, Up)
        | (_,_) -> failwith "Syntax error"

let result1 =
    let (x,y,d) = 
        data
        |> List.map parse
        |> List.fold turtle (0,0, Right)
        
    manhattanDistance (0,0) (x,y)

let turtle' (x, y, sx, sy) c =
    match c with
    | Nord n -> (x, y+n, sx, sy)
    | East n -> (x+n, y, sx, sy)
    | South n -> (x, y-n, sx, sy)
    | West n -> (x-n, y, sx, sy)
    | Forward n ->
        (x, y, sx + (n*x), sy+(n*y))
    | Backward n ->
        (x, y, sx - (n*x), sy-(n*y))
    | TurnLeft 90
    | TurnRight 270 -> (-y, x, sx, sy)
    | TurnLeft 180
    | TurnRight 180 -> (-x, -y, sx, sy)
    | TurnRight 90
    | TurnLeft 270 -> (y, -x, sx, sy)
    | _ -> failwith "Syntax error"

let result2 =
    let (_,_,sx,sy) = 
        data
        |> List.map parse
        |> List.fold turtle' (10, 1, 0, 0)
        
    manhattanDistance (0,0) (sx,sy)
    
    
