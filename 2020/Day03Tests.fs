module Day03Tests

open FsUnit.Xunit
open Xunit

open Day03

let maze = 
 [
    "..##.......";
    "#...#...#..";
    ".#....#..#.";
    "..#.#...#.#";
    ".#...##..#.";
    "..#.##.....";
    ".#.#.#....#";
    ".#........#";
    "#.##...#...";
    "#...##....#";
    ".#..#...#.#";
 ]


// Right 1, down 1. --> 2
// Right 3, down 1. (This is the slope you already checked.) --> 7
// Right 5, down 1. --> 3 
// Right 7, down 1. --> 4
// Right 1, down 2. --> 2

[<Fact>]
let ``copy and paste of input data is correct`` () =
    Day03.data
        |> should haveLength 323
    
    let l = Day03.data.[0].Length
    Day03.data
        |> List.ofArray
        |> List.filter (fun s -> s.Length <> l)
        |> should be Empty

[<Fact>]
let ``eachOther 1 SHOULD return all lines`` () =
    maze |> Array.ofList
    |> eachOther 1
    |> should matchList maze

[<Fact>]
let ``eachOther 2 SHOULD return even index elements`` () =
    maze |> Array.ofList
    |> eachOther 2
    |> should matchList
         [
            "..##.......";
            ".#....#..#.";
            ".#...##..#.";
            ".#.#.#....#";
            "#.##...#...";
            ".#..#...#.#";
         ]

[<Fact>]
let ``Test case 1`` () =
    slide (Point(0,0)) (Move(3,1)) maze
    |> should equal 7

[<Fact>]
let ``Test case 2 - step 1`` () =
    slide (Point(0,0)) (Move(1,1)) maze
    |> should equal 2

[<Fact>]
let ``Test case 2 - step 3`` () =
    slide (Point(0,0)) (Move(5,1)) maze
    |> should equal 3

[<Fact>]
let ``Test case 2 - step 4`` () =
    slide (Point(0,0)) (Move(7,1)) maze
    |> should equal 4

[<Fact>]
let ``Test case 2 - step 5`` () =
    maze|> Array.ofList
    |> eachOther 2
    |> slide (Point(0,0)) (Move(1,2)) 
    |> should equal 2