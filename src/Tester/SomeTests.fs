module Blah

open System
open Library
open Xunit
open Swensen.Unquote



[<Fact>]
let ``My test`` () =
    Assert.True(7 = 5 + 2)

[<Fact>]
let ``Another Test`` () = Assert.True(4 = 2 + 2)

[<Fact>]
let ``Value should be same as input value`` () = test <@ 3*3 = 9 @> 

[<Fact>]
let ``demo Unquote xUnit support`` () =
    test <@ [3; 2; 1; 0] |> List.map ((+) 1) = [1 + 3..1 + 0] @>

[<Fact>]
let ``demo Unquote xUnit support (Another)`` () =
    test <@ [3; 2; 1; 0] |> List.map ((+) 1) = [1 + 3..-1..1 + 0] @>