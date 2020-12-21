module Day20

open Commons

let data =
    [|
        "Tile 3253:";
        "###....#..";
        ".#..##....";
        "##.#.#.#.#";
        "#.#.......";
        "#....#...#";
        "#.##...#..";
        "....#.....";
        "##.##.#..#";
        ".###...##.";
        "##.#...##.";
        "";
        "Tile 2843:";
        "...#.#.#..";
        "##.....#.#";
        "..#...#...";
        "#.##.##...";
        "#......###";
        "#..#.#.###";
        "........##";
        "#.....##..";
        "........#.";
        "..##..###.";
        "";
        "Tile 2557:";
        "..##..#.#.";
        "#.#......#";
        "...#......";
        "..........";
        ".#....#..#";
        "...#....##";
        "####.....#";
        ".##.##..#.";
        "#..#......";
        "#.#.##.#..";
        "";
        "Tile 2543:";
        "...#.#####";
        "...#.....#";
        "#..#.#....";
        ".......#..";
        "......#..#";
        "#......#..";
        ".#...#...#";
        "##.#.#..##";
        "#.#..#.#..";
        ".#..####.#";
        "";
        "Tile 3319:";
        "#####..###";
        ".#.#......";
        "#.....#...";
        ".....#...#";
        ".#.#.....#";
        ".....#...#";
        ".##......#";
        "##....#..#";
        "##.#...#.#";
        ".#....#..#";
        "";
        "Tile 1607:";
        ".##..#####";
        "#....#..#.";
        ".#..#.....";
        "....#.....";
        "...#.#..##";
        "#..###...#";
        "..#.#.....";
        "..##.##.##";
        "#...#..#.#";
        "###..#.##.";
        "";
        "Tile 3329:";
        "#.#######.";
        "#.#...###.";
        "###......#";
        "..........";
        "#..#.#...#";
        "#...##...#";
        "#...##...#";
        "##.#..#.#.";
        "#..##.#...";
        "......#.#.";
        "";
        "Tile 2663:";
        "#.#..##.#.";
        "...#.....#";
        "###..#....";
        "..#.....#.";
        "...#....##";
        ".#.....#.#";
        "..........";
        "#..#......";
        "####...#.#";
        "###..#.#.#";
        "";
        "Tile 1619:";
        "####.#...#";
        ".#....#..#";
        ".......#.#";
        "#.#....#..";
        "#...#.#...";
        "##........";
        "##....#.#.";
        ".#..###...";
        "#..#...###";
        "###.#.....";
        "";
        "Tile 3779:";
        "...#..#..#";
        ".....#..#.";
        ".#.....###";
        "......#.#.";
        "#....#...#";
        "##.#.#..#.";
        "...#......";
        "#.........";
        "..........";
        "##.##.#...";
        "";
        "Tile 3821:";
        ".###.#...#";
        "##.......#";
        "..#..#.#..";
        ".....#...#";
        "...###..##";
        ".#......#.";
        "..#...#.#.";
        "#...#....#";
        "#.#..#...#";
        "...###.##.";
        "";
        "Tile 2749:";
        "#.##.#..##";
        "...#.##.#.";
        ".....#...#";
        ".......##.";
        "..........";
        "#.###.....";
        "#...##...#";
        "....#..###";
        "#.#.##...#";
        "#..#.#...#";
        "";
        "Tile 1153:";
        "##....####";
        "..#..#...#";
        "#..#..#...";
        ".#.#...#..";
        "#...##.##.";
        ".....#....";
        "..#..#..##";
        "##....##..";
        "#....#....";
        "###..###..";
        "";
        "Tile 3181:";
        "#.#.##..#.";
        "#...##....";
        "....#.##.#";
        "...#......";
        "###.##....";
        ".##.......";
        "........##";
        "....#..#.#";
        "..##..#..#";
        "#.##....#.";
        "";
        "Tile 3491:";
        ".#.....##.";
        "..##..#...";
        ".##...#...";
        "##.....#..";
        "##.....#..";
        "..#...#.#.";
        "#......#.#";
        "#.......#.";
        "#.##..##.#";
        "..#...##..";
        "";
        "Tile 1129:";
        "#.##.#.#..";
        "#.#..#.#.#";
        "##........";
        "##.....#.#";
        ".#.......#";
        "#........#";
        "..###....#";
        ".#......#.";
        ".#....#..#";
        ".#.#.#.###";
        "";
        "Tile 3967:";
        "##.#.#####";
        "#....#...#";
        "#####...#.";
        "#.#....##.";
        ".#...##.#.";
        "#..#..#...";
        "#..#......";
        ".....#.#.#";
        "........##";
        "#....##..#";
        "";
        "Tile 2131:";
        "###.....#.";
        "#..#.##...";
        "#..#.##..#";
        "##.....#..";
        "..#.###.##";
        "#........#";
        "##........";
        "...#.#....";
        "##.....##.";
        ".#....###.";
        "";
        "Tile 1657:";
        "###.#.#...";
        "#..#.#...#";
        "..........";
        "..#....##.";
        ".#...#....";
        "##.#..##.#";
        "#..#..##..";
        "......#..#";
        ".....#...#";
        "#####.#.##";
        "";
        "Tile 2521:";
        ".##..###..";
        "#.......##";
        ".##......#";
        "#...#.....";
        "###...#..#";
        ".......#.#";
        "#.#..####.";
        "#..#......";
        "#.....#...";
        "#.####....";
        "";
        "Tile 1879:";
        "...#####..";
        "#...#.#...";
        "....##.###";
        ".......#..";
        "#.....###.";
        "##......#.";
        "##....##..";
        "#.....#..#";
        "...#.#.#.#";
        ".###.###..";
        "";
        "Tile 2999:";
        ".####.#..#";
        "...#.....#";
        ".......##.";
        "#..#....#.";
        ".....#.##.";
        "#.....#..#";
        "....#....#";
        "#........#";
        "...#.####.";
        ".......##.";
        "";
        "Tile 1091:";
        "#####.####";
        "##.#...##.";
        "..#......#";
        "....#.#...";
        "#...###.##";
        "#..#.#...#";
        "........##";
        "#.....##.#";
        "##..#.##..";
        "...##.#..#";
        "";
        "Tile 3673:";
        "..##.#..##";
        "#....#..##";
        "#.#.#....#";
        "...#.....#";
        "...#......";
        "..#....#..";
        ".#.....#..";
        "..........";
        "#.#.##.#.#";
        "###.##..##";
        "";
        "Tile 3727:";
        "..#.#..#.#";
        "##...##...";
        "##........";
        "..#..#.#.#";
        "..##.#....";
        "####.....#";
        "....#....#";
        "#..#.....#";
        "#.#.......";
        ".##.#..#.#";
        "";
        "Tile 3089:";
        "#.#.##..#.";
        ".....#...#";
        "##........";
        ".#.#.###.#";
        ".#....#..#";
        ".....##...";
        ".....##..#";
        "..#.......";
        "#.......#.";
        "#...##.#.#";
        "";
        "Tile 2819:";
        "....##.#.#";
        "#...#.#..#";
        "......#..#";
        ".#.#.#####";
        "...##..#.#";
        "........##";
        "##..###...";
        ".#.......#";
        "..##...#..";
        "..#.#.#.##";
        "";
        "Tile 3023:";
        "..#######.";
        "....##..#.";
        "..#.##....";
        "##...##..#";
        "#.##......";
        "....#.....";
        "##....#..#";
        ".#...##..#";
        "#.#..#....";
        "#.##.###.#";
        "";
        "Tile 2789:";
        "###.##....";
        ".##.....#.";
        ".......#.#";
        "....#.....";
        "#..#.#....";
        ".#........";
        "#.........";
        "..#.#....#";
        "#........#";
        "####..#...";
        "";
        "Tile 3583:";
        "..#####...";
        "#....#..##";
        ".#.#..#.#.";
        "#..#.#....";
        "#.#..###..";
        "#.#.#.#...";
        "#..#...#.#";
        "#.......#.";
        "#....#..##";
        "....###...";
        "";
        "Tile 1997:";
        "..#.###..#";
        "#...##....";
        "###.###..#";
        "####.##..#";
        "####..##.#";
        "##.#..##.#";
        "#..#..###.";
        "#.#.......";
        ".#......##";
        "#..#.#..#.";
        "";
        "Tile 3691:";
        ".#...#####";
        "..##.##..#";
        "##.#.#...#";
        "#........#";
        "#.#......#";
        "...#......";
        "#.#......#";
        "..#...#.##";
        "#.####...#";
        "##..#.#...";
        "";
        "Tile 1303:";
        "#...#.#...";
        "..#.......";
        "........#.";
        "#...###..#";
        "#....#..#.";
        "..........";
        "#.........";
        "#.##..##.#";
        "#.#.....##";
        ".....##...";
        "";
        "Tile 2287:";
        ".#.#.####.";
        "......#...";
        "#.###.....";
        "##..#...#.";
        "#..###...#";
        "##.......#";
        ".....#...#";
        "#.#.....##";
        "..###..#..";
        "..###...#.";
        "";
        "Tile 1733:";
        "#######...";
        "##..#....#";
        ".....#....";
        "#.##..##..";
        "#...##.###";
        "#.........";
        "###......#";
        "#.#.#.##.#";
        "...#...#.#";
        "##..#..##.";
        "";
        "Tile 1097:";
        "#.###..#..";
        "#....#.#..";
        "...###...#";
        ".##.#.##..";
        "#.#...#..#";
        "...#...#.#";
        "......##..";
        "..#..#....";
        ".....###.#";
        "##....#.#.";
        "";
        "Tile 1637:";
        "..###.#...";
        "##........";
        "#..#......";
        "###.##...#";
        "##...##..#";
        "#.........";
        "#.........";
        "#..#..##..";
        ".......#..";
        ".#..##.#..";
        "";
        "Tile 3931:";
        ".##.#.#.#.";
        "##........";
        "#...#...##";
        ".##.....##";
        "###....#.#";
        "..##..##.#";
        "#..#.#..##";
        "#.##......";
        "..#.......";
        "...#....##";
        "";
        "Tile 3463:";
        "...#.##.#.";
        ".#...#..#.";
        "##....#...";
        "#...#.###.";
        "#.....#.##";
        "#....###..";
        "..####.#..";
        "......##..";
        ".###......";
        ".##..#...#";
        "";
        "Tile 2377:";
        ".#.##.##.#";
        "#....#.#.#";
        ".........#";
        "...#...#.#";
        "#.#.......";
        "#......#..";
        "....#...#.";
        ".....##..#";
        "#.##..#..#";
        "##..##.###";
        "";
        "Tile 1249:";
        ".##..#####";
        "#........#";
        ".#..#.#...";
        "..#..#..##";
        "##.####.#.";
        "...##.#..#";
        "#..##.....";
        ".......##.";
        "#...#....#";
        "..#.#..#.#";
        "";
        "Tile 3257:";
        "#####..###";
        "..........";
        ".#....#..#";
        "#...###...";
        ".#......#.";
        "#..#.#..##";
        "#.....#.##";
        "#..#.....#";
        ".....#....";
        "..#####.##";
        "";
        "Tile 1693:";
        "...####.#.";
        "....#..#.#";
        "...#....#.";
        "...#.#.#.#";
        "#....#....";
        "..........";
        "####....##";
        "....##..##";
        "..#...#.##";
        "#.#####.##";
        "";
        "Tile 3671:";
        "###..#...#";
        ".......#.#";
        ".......#.#";
        "##......#.";
        "..#.....#.";
        ".##....#.#";
        ".##....#.#";
        "#...#.####";
        "....#..##.";
        ".##...##.#";
        "";
        "Tile 2531:";
        "#...#.##..";
        "...#.....#";
        "##........";
        "#.#......#";
        ".#.####...";
        "##........";
        ".#..#.....";
        "#....###.#";
        "#.....#...";
        "....###.#.";
        "";
        "Tile 1553:";
        "##.#....#.";
        ".##.#..#..";
        "#...#.##..";
        ".#.#.#..#.";
        ".........#";
        "#....#....";
        "..........";
        "#.#...#..#";
        "##....#...";
        ".###.##...";
        "";
        "Tile 1847:";
        ".#.##..##.";
        "......#...";
        ".#.#..#...";
        "...##....#";
        "#.........";
        ".#........";
        "#...#.##.#";
        "#...#..#.#";
        "####.#....";
        "####....#.";
        "";
        "Tile 1423:";
        "..###..##.";
        "#.#.#.....";
        "....##...#";
        "#.#.##.###";
        ".#....##.#";
        "#......#.#";
        ".....#...#";
        "#..#.#.#..";
        "##.....###";
        ".....####.";
        "";
        "Tile 3533:";
        "##.##.#...";
        "........##";
        "..##..#..#";
        ".#....#..#";
        "..........";
        "#.#......#";
        "...#....#.";
        "....#..#.#";
        "....#..##.";
        "##.#...###";
        "";
        "Tile 1033:";
        "##.##.#.#.";
        "#.....####";
        "..#....#.#";
        "###....#.#";
        "#....##.#.";
        "#...#...##";
        "#..#.#....";
        "...#..#..#";
        "##.#..##..";
        "..#.....##";
        "";
        "Tile 3413:";
        "#.#.#.#.##";
        "#....#....";
        "...#......";
        ".#..#.#.#.";
        "#...#.....";
        "......#..#";
        "...#.#....";
        "..#.#..#..";
        "##..#.###.";
        ".#####.##.";
        "";
        "Tile 1123:";
        ".#....####";
        "#....##...";
        "....#.....";
        "...#..#.##";
        "#....#..##";
        ".##.#...#.";
        "#.#.#.#...";
        "#.#...#..#";
        "##.#.....#";
        "#.##.##.#.";
        "";
        "Tile 2551:";
        "###..##.#.";
        ".#..#.##.#";
        ".##.##.#..";
        ".#...#..##";
        "##.......#";
        ".....#....";
        "..#.##...#";
        ".........#";
        ".#.#.#..#.";
        ".#.#.####.";
        "";
        "Tile 3677:";
        ".#.#.#.###";
        ".#.#.#..##";
        "#........#";
        "..#.......";
        "#.##.....#";
        "......#..#";
        "##........";
        "#...##....";
        "..##......";
        ".####..###";
        "";
        "Tile 3659:";
        "#.#.#.#.##";
        "...##.#...";
        "...#.#.#.#";
        "#..#..#...";
        "###...#...";
        "#.##.#..##";
        ".##...#...";
        ".###......";
        ".#..##....";
        "###.##.#.#";
        "";
        "Tile 1103:";
        "####..##.#";
        "##.#.#....";
        "#..#.#....";
        "#...#.#...";
        "##......##";
        "..####.#..";
        "..#..##.#.";
        ".#.#.##...";
        "..##.#.##.";
        "#.#.######";
        "";
        "Tile 1361:";
        "#.....####";
        "....##..#.";
        "#...#.....";
        ".........#";
        "#.....#.#.";
        ".....##..#";
        "....####.#";
        "...#....#.";
        "#.....#...";
        "#..##...#.";
        "";
        "Tile 3527:";
        "..###.##.#";
        "##.......#";
        ".#.....#.#";
        "#..#.#.#..";
        "#...#.....";
        "#....#....";
        "..#....#.#";
        ".........#";
        "....#....#";
        ".#..######";
        "";
        "Tile 1823:";
        ".#####..##";
        "#..#.##...";
        "..##.#...#";
        "#...#....#";
        "....#....#";
        "..#.#.#.##";
        "..#.#....#";
        "#.#....##.";
        "...#.##.##";
        "..#.#..##.";
        "";
        "Tile 1559:";
        "#....###.#";
        ".###.#.#.#";
        "#.#.......";
        "#....##.##";
        "#....#.#.#";
        "#.#......#";
        ".#...###..";
        "##...#.##.";
        ".##.#.####";
        ".##..##...";
        "";
        "Tile 2161:";
        "#..#.####.";
        ".......#.#";
        "#........#";
        "....#...##";
        "#.#.#...#.";
        "#..###...#";
        "#.........";
        ".#.....#.#";
        "..##.#...#";
        ".#.###.###";
        "";
        "Tile 2633:";
        ".#...#.###";
        "..#.#....#";
        "#.......##";
        "#....#....";
        "#.#....#.#";
        "#.##....#.";
        "...###..##";
        "#...#...##";
        "####...#..";
        ".#..###.#.";
        "";
        "Tile 2593:";
        "##..#..#.#";
        "#.....###.";
        "#.#.......";
        "##....#.#.";
        "#...##.#.#";
        "#.#..#..##";
        "###...##..";
        "..#......#";
        "#.#.##....";
        "#.#####..#";
        "";
        "Tile 2917:";
        "#####.....";
        "#....#...#";
        "..##...#.#";
        "##.#.....#";
        "....##.#.#";
        "#.....#...";
        ".....#.#.#";
        "##...#.##.";
        "..........";
        "......###.";
        "";
        "Tile 3881:";
        "..#.....#.";
        "......##..";
        "#....#....";
        "...#.###.#";
        "##....#..#";
        "#....#.#..";
        "#....##...";
        "#.....#...";
        ".....#..##";
        "##....#.##";
        "";
        "Tile 1193:";
        "#.###.#.#.";
        ".#.##.###.";
        ".######..#";
        "##.##..#.#";
        "#.....#.#.";
        "..#.##.##.";
        ".#.......#";
        "..#......#";
        "..........";
        ".#.#####.#";
        "";
        "Tile 2467:";
        "#..#.#.###";
        "#..#...#.#";
        "...#####.#";
        "#........#";
        "#.#.....#.";
        ".#..#...##";
        "...#..##.#";
        "..#..#...#";
        "#..#......";
        "..###...#.";
        "";
        "Tile 2273:";
        "##..####.#";
        "..##.#.##.";
        "..##....##";
        "#.#......#";
        "..#...#...";
        "#.........";
        "#.##....##";
        ".#.#..#..#";
        "#..##.....";
        "#.##....#.";
        "";
        "Tile 3191:";
        "###...#.##";
        ".......#..";
        "#.#.#.#...";
        "......#..#";
        "...##...##";
        "....#.##..";
        "##.#..#.##";
        ".......#..";
        "#.....#.#.";
        "...###....";
        "";
        "Tile 2423:";
        "..#..##.#.";
        "#.......##";
        ".#....#.##";
        "#.#..##...";
        "###.#####.";
        "#.....#.#.";
        "..##..##..";
        "#.#......#";
        "##........";
        "#..#.#####";
        "";
        "Tile 2719:";
        "########..";
        "#.#.#.#.#.";
        "#....#..#.";
        "........#.";
        ".#..##.#..";
        ".....##..#";
        "..##...#.#";
        "##.#......";
        "#........#";
        "..#...#..#";
        "";
        "Tile 3467:";
        "..#.#...#.";
        "#....#..##";
        "...#.#..##";
        ".#...##..#";
        "#.#.##...#";
        ".........#";
        "#..#..#..#";
        "#....#..#.";
        "#...##..#.";
        "######..#.";
        "";
        "Tile 3461:";
        "#..##.#...";
        ".#...##..#";
        "#..#..#..#";
        "#####.....";
        "...#.###..";
        "....###.#.";
        "##.##.....";
        "#.........";
        "#.###.#...";
        "##...##..#";
        "";
        "Tile 1109:";
        ".#.#.#....";
        "...#..###.";
        "......#...";
        "#.........";
        "#.#.......";
        "#.#.#.####";
        ".##..#.#.#";
        "#......#..";
        "#......###";
        "#.###.....";
        "";
        "Tile 2953:";
        "##.##.##..";
        "#....#...#";
        "##..##...#";
        "#..#.....#";
        "........#.";
        "#.....###.";
        "##...#####";
        "#.....#...";
        "..#.#..###";
        "...#.##.#.";
        "";
        "Tile 2081:";
        "##.#.##..#";
        "#....#..##";
        "###......#";
        "##.......#";
        ".#.#.#....";
        "#.#.#....#";
        "...#..#..#";
        "....##....";
        "..#..#..#.";
        "#.####....";
        "";
        "Tile 2141:";
        "###..#.###";
        "#.#..#..##";
        "####....#.";
        ".....#..##";
        "......#.#.";
        "..#.##...#";
        "...##.##..";
        "....#....#";
        "......#..#";
        "..#.####..";
        "";
        "Tile 1523:";
        ".#.##...#.";
        "#..#..##..";
        "#.#.......";
        "......#.##";
        "#.#.##.##.";
        "#..##..#..";
        "#.###.....";
        "..##.##...";
        "..#.....#.";
        ".#####.###";
        "";
        "Tile 2411:";
        "##.###.###";
        "#.#......#";
        "...##....#";
        "....##....";
        "..#......#";
        ".#.#..#...";
        "##..#...#.";
        ".....#.##.";
        "#.......#.";
        "#...#####.";
        "";
        "Tile 1627:";
        "..####.#.#";
        "....#..#..";
        ".##......#";
        ".#..#...#.";
        "##.......#";
        "#.#.......";
        "#.##......";
        ".....#.#.#";
        "#.#......#";
        "####..#...";
        "";
        "Tile 1489:";
        "#....#.##.";
        ".......#.#";
        "##.....###";
        "#.#...##.#";
        "...#.....#";
        "######...#";
        "..#...####";
        "...#...#..";
        ".#.#.#.#..";
        "#.##.#.##.";
        "";
        "Tile 2371:";
        "#.#.##.##.";
        "...#......";
        ".##.#.....";
        "#.........";
        "#....#...#";
        ".##..#..#.";
        "##.##.###.";
        ".###...#.#";
        "..#.....#.";
        "#...#.###.";
        "";
        "Tile 2221:";
        "#..#.#.###";
        "#.##..#.#.";
        ".#.###..#.";
        "#.#..#....";
        "##.#...###";
        "..#.##.#.#";
        "..##.###..";
        "..##.##.#.";
        "....#..#..";
        "#..###.#..";
        "";
        "Tile 2861:";
        "#.##.#.###";
        "##..#.#...";
        "#...#....#";
        "##......##";
        "#...#.##..";
        "..##..#..#";
        ".......#..";
        "......#...";
        "#..##..#..";
        ".#..#...#.";
        "";
        "Tile 2707:";
        ".##.....##";
        "#...###...";
        "##..####.#";
        "####....##";
        ".#.#......";
        ".##.#....#";
        ".##.....##";
        "##.#.....#";
        "#.#.......";
        ".##..#.#..";
        "";
        "Tile 2083:";
        "##...##...";
        "..........";
        ".........#";
        "...#.....#";
        ".....#.#..";
        "...#..#...";
        "#........#";
        ".#.##..#.#";
        "....###..#";
        "##.#......";
        "";
        "Tile 2621:";
        ".#..#.#.##";
        "##....##..";
        "...#..#...";
        "##.#.###.#";
        "##.#..#.##";
        "..#.....##";
        "#.##..####";
        ".##.##....";
        ".......#.#";
        "###...#..#";
        "";
        "Tile 1993:";
        "#...##.##.";
        "..#.....##";
        ".#........";
        "......#..#";
        "#.##....##";
        "#.#.##...#";
        "...#..#..#";
        "#.#....#.#";
        ".......#..";
        ".###....#.";
        "";
        "Tile 1439:";
        "..##......";
        "..#......#";
        "..##..#..#";
        "#...##.#.#";
        ".....#...#";
        "..#...#..#";
        "##.#.####.";
        "#....#....";
        "..#...#..#";
        "..#.#...#.";
        "";
        "Tile 3863:";
        ".#..###.##";
        ".........#";
        "##.##...#.";
        "#...#..###";
        "#...#....#";
        "#.....#..#";
        "#.....#..#";
        ".#.##.#..#";
        "##.....###";
        "###..###.#";
        "";
        "Tile 3203:";
        "#......##.";
        "##.....#.#";
        "....##...#";
        "....#...##";
        "........##";
        "..#......#";
        "...##....#";
        "#...##.#..";
        "###...#..#";
        "###.##....";
        "";
        "Tile 2677:";
        "..#.......";
        ".#..#.....";
        ".#..#..#.#";
        "#.##....##";
        "#...#...#.";
        "#.......##";
        ".#.....###";
        "#.........";
        "........##";
        "....##...#";
        "";
        "Tile 1069:";
        "..##..#.#.";
        "###.......";
        "#.#....#..";
        ".#....#.#.";
        "##.....#..";
        "#...#.....";
        ".......#..";
        "#........#";
        ".........#";
        "#..#...##.";
        "";
        "Tile 1171:";
        "..##.##.#.";
        "#..#......";
        "#...#....#";
        "....##...#";
        ".##......#";
        "#......#.#";
        "..###...#.";
        ".####.####";
        ".....#.#..";
        "#.#..#...#";
        "";
        "Tile 1049:";
        "#.##.##..#";
        "##.#..##..";
        "..#...#...";
        "..#.#.....";
        "#.#......#";
        ".....#.##.";
        "#.#.######";
        "...#.#....";
        "#.....#..#";
        "#...##.#..";
        "";
        "Tile 2683:";
        "#..#......";
        ".#.#..####";
        "#.#......#";
        "#.#.......";
        "##.....#.#";
        "#....##...";
        ".#.#.....#";
        "##.......#";
        "#...#.##..";
        ".#####....";
        "";
        "Tile 1213:";
        "#.##..###.";
        "...###.#.#";
        ".#....#.##";
        "#.....#...";
        "...##.....";
        "#.#.####.#";
        "#.####..##";
        "###.#.##..";
        "#.#..#.##.";
        "#..#.###..";
        "";
        "Tile 1597:";
        "#......###";
        "#.#.##..##";
        "...#####.#";
        "######.#.#";
        "...#.##.#.";
        "........#.";
        "....#....#";
        "##......#.";
        ".###..##.#";
        "##..##...#";
        "";
        "Tile 2909:";
        "#.##......";
        "#......##.";
        "...#..#...";
        "###.#..#..";
        "#..#..#...";
        "#....#...#";
        "#......#..";
        ".#........";
        ".#.......#";
        ".####.#...";
        "";
        "Tile 1429:";
        "####.#####";
        ".........#";
        "##.#...#.#";
        "#..#..#...";
        "..#...#.##";
        "#..#......";
        "##..#.....";
        "..####...#";
        "#..#..#...";
        "#...#.##..";
        "";
        "Tile 3877:";
        ".#..#.#.#.";
        "#..#......";
        "###.##.##.";
        "#.###.....";
        "#.......##";
        "##.#....##";
        "...#......";
        "#...##....";
        "#.##...###";
        ".#.#..###.";
        "";
        "Tile 1019:";
        "####.....#";
        "#.#..#..##";
        "#.....#...";
        ".#......##";
        ".........#";
        "......#..#";
        "...#.#.##.";
        "#....#...#";
        "......#..#";
        ".###.#..#.";
        "";
        "Tile 3637:";
        "#.....#...";
        ".#..##...#";
        ".###..#...";
        "#.#.#.....";
        "..#....#..";
        "#..#..#...";
        ".#.......#";
        "...#..##.#";
        "#.#....#..";
        ".#.#...##.";
        "";
        "Tile 3301:";
        "##.##...#.";
        ".#.#.#....";
        "........#.";
        "#.#..#..#.";
        ".#...###..";
        "#....#.#..";
        "..##......";
        "....#....#";
        ".#...#.###";
        "##.##..###";
        "";
        "Tile 2459:";
        "######..##";
        "...#..####";
        "....##...#";
        "...#.#.#..";
        "....#..##.";
        "...#..#...";
        "#...##....";
        ".......#..";
        "#.#.......";
        "#..###.###";
        "";
        "Tile 1741:";
        "#..#......";
        "..#.......";
        ".....#..#.";
        "....#.#...";
        "#...##....";
        "#.#......#";
        "##.......#";
        "..#..#...#";
        ".#..#...##";
        "###..#.##.";
        "";
        "Tile 3019:";
        "###.#.###.";
        ".##...#.##";
        "#.....##..";
        "#.....#..#";
        ".#.#.#...#";
        ".........#";
        "#..##..##.";
        "##...#...#";
        "#...#.#...";
        "..#.....#.";
        "";
        "Tile 1789:";
        "#...#.#.#.";
        ".##..#.#..";
        "...##.#.#.";
        "#...#.#...";
        "..#..#...#";
        "..###....#";
        "...#.#....";
        ".#..#.#..#";
        ".....#....";
        "#...#####.";
        "";
        "Tile 2207:";
        "..####.##.";
        "#.......##";
        ".##..#....";
        "..#.#.#..#";
        "#....#####";
        ".....#...#";
        "#####.##..";
        ".##...#..#";
        ".#.#.#....";
        "...####.##";
        "";
        "Tile 1783:";
        "..#.......";
        "......#..#";
        "#..#...#..";
        "#.........";
        ".........#";
        ".#.......#";
        ".##....##.";
        "##.##.#...";
        ".#.#....#.";
        ".##.#..##.";
        "";
        "Tile 1609:";
        "#.##.#.###";
        "...#...#..";
        "#.#......#";
        "#....#...#";
        ".....#....";
        "..........";
        "...#.....#";
        "###.......";
        "#...#.#..#";
        "#..#.#....";
        "";
        "Tile 3011:";
        "##.....#..";
        "..#....#..";
        "#..##.#...";
        "......#...";
        ".#.#.#.#.#";
        "...#.##..#";
        "#.#...#.##";
        ".##.####.#";
        "#.#...####";
        "..##..####";
        "";
        "Tile 3517:";
        "#.####.##.";
        "#....##..#";
        "#.##..#..#";
        ".....#...#";
        "#..#......";
        "#....#...#";
        ".........#";
        "#....#.###";
        "......###.";
        "#.#.#..##.";
        "";
        "Tile 2969:";
        "#....###.#";
        "##..#...#.";
        ".##..#...#";
        "#.#....###";
        "##.......#";
        "#.#....#.#";
        ".#.#...#.#";
        "#....#.#..";
        "##..#.....";
        "#..#...###";
        "";
        "Tile 1487:";
        "#.......#.";
        "......##..";
        "......##..";
        "###..#....";
        "#..#......";
        "#.#......#";
        "##..##..##";
        "#.##.....#";
        "#.........";
        "##.##.#.##";
        "";
        "Tile 1201:";
        "..#.#.##.#";
        "..#.....#.";
        "...#......";
        ".....#.#.#";
        "##....#.##";
        "#....#.##.";
        "###....##.";
        "###....#.#";
        "#....#.#.#";
        "#.#..##.#.";
        "";
        "Tile 3371:";
        ".#.#...##.";
        "#..#.#..#.";
        "##.#..#..#";
        ".......#..";
        "#........#";
        ".#..#.#...";
        "..........";
        "##........";
        ".#........";
        "...##..#.#";
        "";
        "Tile 1367:";
        "#..##.###.";
        "..........";
        "#......###";
        "..#..#..#.";
        "#.####....";
        "...##...##";
        "#.#......#";
        "#.#.#.#..#";
        "..##.####.";
        "##.....#.#";
        "";
        "Tile 2699:";
        "##...#...#";
        "#.#.#....#";
        ".#..#..#.#";
        "....###...";
        "#.##.##.##";
        "#..#......";
        "##........";
        "#..#...#.#";
        "..........";
        "##..#####.";
        "";
        "Tile 3761:";
        "##.##.#..#";
        "#.#.....#.";
        "..#.##...#";
        ".........#";
        "..#..#.###";
        ".##..#...#";
        "###.##..##";
        ".#....#..#";
        "#...##...#";
        "...##.#.##";
        "";
        "Tile 1697:";
        "#...#.##.#";
        "#..#.....#";
        "...###....";
        "#..#..#.#.";
        "#........#";
        ".....#....";
        "#...####.#";
        "##.#......";
        ".#........";
        "##.#...##.";
        "";
        "Tile 3221:";
        "#.##...##.";
        "###.#...#.";
        ".#..##.#..";
        ".##.......";
        "#.........";
        "..........";
        ".#####....";
        "##.##.....";
        ".....#..#.";
        "#.##.#.#.#";
        "";
        "Tile 1181:";
        "..#.###.##";
        "#.#.##.#.#";
        "...#...#..";
        "#....#.#.#";
        "#..#.##..#";
        ".####..#..";
        "..........";
        ".#.....#..";
        ".......##.";
        ".....#....";
        "";
        "Tile 2617:";
        "#..##.....";
        "#.#..#..##";
        "##.##....#";
        "#.........";
        ".....#....";
        "#.#..#.##.";
        "##.#.....#";
        "..#..#.#.#";
        "..#....#.#";
        "..#..####.";
        "";
        "Tile 3739:";
        "##.#.#..#.";
        "#.#....#..";
        ".#..#..#.#";
        "##...#.##.";
        ".##.......";
        "#.###.#.#.";
        "#....#..##";
        "..###..#.#";
        ".#....##.#";
        "#.###.#.#.";
        "";
        "Tile 1867:";
        "######.#..";
        "...##....#";
        "##.....##.";
        "##.#..#.#.";
        "#..#.#..#.";
        "..#......#";
        "#..#..##..";
        "##...#..#.";
        ".#.#.#.#.#";
        ".##.###.#.";
        "";
        "Tile 2777:";
        "..#.##.#.#";
        "..#..#....";
        "...#....##";
        "....####.#";
        ".##.#..###";
        "....##.##.";
        "##....#..#";
        ".....#....";
        "#.....##..";
        "#..##.##.#";
        "";
        "Tile 2039:";
        "....#####.";
        "..#..##...";
        "##......##";
        "#..#...#.#";
        "#.#....#.#";
        "..#.....##";
        "...#.#....";
        "#..##.....";
        "#..####.##";
        "#.##.#..#.";
        "";
        "Tile 3229:";
        "##...####.";
        "..#.#.#..#";
        "#....#.#..";
        "#.#..##..#";
        "##..#.#...";
        "...##....#";
        "#...##.#.#";
        "#..#.##...";
        "..##...#..";
        "......##..";
        "";
        "Tile 1447:";
        "#.###.##.#";
        "#..#..#..#";
        ".....###.#";
        ".......#.#";
        "#..#...##.";
        "#..##..#..";
        "##.##.#...";
        ".###..#.##";
        ".......#..";
        "#..##...#.";
        "";
        "Tile 1601:";
        "########.#";
        "##......##";
        "###.##....";
        "#####.....";
        "..........";
        ".........#";
        "..#.#...#.";
        "#...#.....";
        ".###...#..";
        ".##.##..##";
        "";
        "Tile 2897:";
        "##.#..#..#";
        "##.......#";
        ".##...#..#";
        "###.#....#";
        "##........";
        "#..#.###..";
        ".#..#.#..#";
        ".#.##..#..";
        ".##......#";
        ".#.##..###";
        "";
        "Tile 2549:";
        ".#..#####.";
        "##.......#";
        "#....#...#";
        ".##.###...";
        "##.#.##..#";
        "..#...#..#";
        "...##...##";
        "..#.....#.";
        ".##.....##";
        "##.#.###..";
        "";
        "Tile 1667:";
        "###...##.#";
        "#....#...#";
        ".##.#..#.#";
        ".......###";
        "#.......##";
        "..#....#..";
        ".........#";
        "###...#..#";
        "#.#.##.#.#";
        "..#.#..#..";
        "";
        "Tile 1327:";
        "###....#.#";
        "..#.#..#.#";
        "##..#..#.#";
        "#..#.##..#";
        ".....#....";
        "##..##.#..";
        "..#......#";
        ".#.#.....#";
        "#.##.###..";
        ".#....#.#.";
        "";
        "Tile 3137:";
        "....##.##.";
        "..#.......";
        "#.#.##...#";
        ".#.......#";
        ".##......#";
        "##.#.....#";
        "##.#.....#";
        "###.#.#.#.";
        "#.....#...";
        "..##.#..##";
        "";
        "Tile 1759:";
        "#.....#.##";
        ".#...#.#..";
        "..#...#..#";
        "#..#..#..#";
        "#....##..#";
        "..##....#.";
        "#......###";
        "#....#.#.#";
        "#...###..#";
        "###.#.##..";
        "";
        "Tile 1747:";
        "#..##....#";
        ".....#...#";
        "..#..#.#.#";
        ".##......#";
        "#.#......#";
        "..#......#";
        "##........";
        "....#.....";
        "#.#......#";
        "##.#..#..#";
        "";
        "Tile 1373:";
        ".##....###";
        "....#....#";
        ".........#";
        ".##....#.#";
        "..........";
        "..#.#....#";
        ".##.....#.";
        ".........#";
        ".....#.#.#";
        "#...#.#...";
        "";
        "Tile 3313:";
        "...##.#.#.";
        "##..#.....";
        "#...##...#";
        ".#..#.....";
        "...#..##..";
        "#...#.####";
        "#........#";
        "......##.#";
        "###..#..#.";
        "..#.#.##..";
        "";
        "Tile 2441:";
        "..#.###.##";
        "#.#..#.###";
        ".##.#.##.#";
        "....#.....";
        ".#.....##.";
        "....##.#.#";
        "..........";
        "..#....##.";
        ".#..####..";
        "#.#..###.#";
        "";
        "Tile 3299:";
        "#....#####";
        "##....####";
        "#........#";
        "#..#......";
        "#........#";
        ".###.##...";
        ".##.##.###";
        "..#..#.#..";
        "..###..#..";
        "...#.#..#.";
        "";
        "Tile 1061:";
        ".....#...#";
        "#..#...#..";
        "#......##.";
        ".##.....#.";
        "###.....##";
        ".........#";
        "#...#.....";
        ".#..##....";
        "#..#.#..##";
        "###.#....#";
        "";
        "Tile 3833:";
        "#.#.###.##";
        "..........";
        ".........#";
        "....#.....";
        "#...#....#";
        "#....#.#..";
        ".....##...";
        "#.........";
        "#.##...#..";
        "##.##.#.#.";
    |] |> Array.toList

type Tile = 
    {
        Number: int
        Sides: (int * int) array 
    }

let toBinaryString (s:string) =
    "0b" + s.Replace(".", "0").Replace("#", "1")

let extractBorders (top, left, right, bottom) (i, s:string) =
    match s with
    | "" -> (top, left, right, bottom)
    | _ ->
        (
            (if i = 0 then s else top),
            left + string s.[0],
            right + string s.[9],
            (if i = 9 then s else bottom)
        )

let toInts s =
    ( 
        s |> toBinaryString |> int,
        s |> reverseString |> toBinaryString |> int
    )

let parse lines =
    let number = match lines |> List.head with
                    | Regex @"Tile (\d+):" [tileNo] -> tileNo |> int
                    | _ -> failwith "Syntax error - tile number"

    let lines' = lines.Tail |> List.indexed
    let (top, left, right, bottom) = lines' |> List.fold extractBorders ("","","","")

    {Number = number; Sides = [|toInts top; toInts left; toInts right; toInts bottom|]}

let result1 input =
    let tiles = 
        input
        |> List.chunkBySize 12
        |> List.map parse
    1I
    
let result2 =
    2