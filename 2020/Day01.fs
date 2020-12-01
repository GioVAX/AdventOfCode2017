module Day01

open System
open FsUnit.Xunit
open Xunit

let data = [
    1472;
    1757;
    1404;
    1663;
    1365;
    1974;
    1649;
    1489;
    1795;
    1821;
    1858;
    1941;
    1943;
    1634;
    1485;
    1838;
    817;
    1815;
    1442;
    639;
    1182;
    1632;
    1587;
    1918;
    1040;
    1441;
    1784;
    1725;
    1951;
    1285;
    285;
    1224;
    1755;
    1748;
    1488;
    1374;
    1946;
    1771;
    1809;
    1929;
    1621;
    1462;
    2001;
    1588;
    1888;
    1959;
    1787;
    1690;
    1363;
    1567;
    1853;
    1990;
    1819;
    1904;
    1458;
    1882;
    1348;
    1957;
    1454;
    1557;
    1471;
    332;
    1805;
    1826;
    1745;
    1154;
    1423;
    1852;
    1751;
    1194;
    1430;
    1849;
    1962;
    1577;
    1470;
    1509;
    1673;
    1883;
    1479;
    1487;
    2007;
    1555;
    1504;
    1570;
    2004;
    978;
    1681;
    1631;
    1791;
    1267;
    1245;
    1383;
    1482;
    1355;
    1792;
    1806;
    1376;
    1199;
    1391;
    1759;
    1474;
    1268;
    1942;
    1936;
    1766;
    1233;
    1876;
    1674;
    1761;
    1542;
    1468;
    1543;
    1986;
    2005;
    1689;
    1606;
    1865;
    1783;
    1807;
    1779;
    1860;
    1408;
    1505;
    1435;
    1205;
    1952;
    1201;
    1714;
    1743;
    1872;
    1897;
    1978;
    1683;
    1846;
    858;
    1528;
    1629;
    1510;
    1446;
    1869;
    1347;
    685;
    1478;
    1387;
    687;
    1964;
    1968;
    1429;
    1460;
    1777;
    1417;
    1768;
    1672;
    1767;
    1400;
    1914;
    1715;
    1425;
    1700;
    1756;
    1835;
    1926;
    1889;
    1568;
    1393;
    1960;
    1540;
    1810;
    1401;
    1685;
    830;
    1789;
    1652;
    1899;
    796;
    1483;
    1261;
    1398;
    1727;
    1566;
    1812;
    1937;
    1993;
    1286;
    1992;
    1611;
    1825;
    1868;
    1870;
    1746;
    1361;
    1418;
    1820;
    1598;
    1911;
    1428;
    1734;
    1833;
    1436;
    1560
]

let findCouple target list =
    let rec loop l1 l2 =
        match (l1, l2) with
        | ([], _)
        | (_, []) -> None
        | (h1::_,h2::_) when h1 + h2 = target -> Some (h1, h2)
        | (h1::_,h2::t2) when h1 + h2 > target -> loop l1 t2
        | (h1::t1,h2::_) when h1 + h2 < target -> loop t1 l2

    let data' = List.sort list
    let data'' = List.rev data'

    loop data' data''


let rec findTriple target = function
    | [] -> None
    | n::ns ->
        match findCouple (target-n) ns with
        | Some(f1, f2) -> Some(n, f1, f2)
        | None -> findTriple target ns

let result1 =
    match findCouple 2020 data with
    | None -> failwith "No couple found"
    | Some (f1, f2) -> 
        f1 * f2
    
let result2 =
    match findTriple 2020 data with
    | None -> failwith "No triple found"
    | Some (f1, f2, f3) -> f1 * f2 * f3

[<Fact>]
let ``Puzzle 1 - example case`` () =
    let data = [1721;979;366;299;675;1456]
   
    let (f1, f2) =
        match findCouple 2020 data with
        | None -> failwith "No couple found"
        | Some (f1, f2) -> (f1, f2)
    
    f1 + f2 |> should equal 2020
    f1 * f2 |> should equal 514579

[<Fact>]
let ``Puzzle 2 - example case`` () =
    let data = [1721;979;366;299;675;1456]

    let (f1, f2, f3) =
        match findTriple 2020 data with
        | None -> failwith "No triple found"
        | Some (f1, f2, f3) -> (f1, f2, f3)

    f1 + f2 + f3 |> should equal 2020
    f1 * f2 * f3 |> should equal 241861950