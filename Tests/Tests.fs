namespace CS220

open CS220.Program
open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass () =

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.A``() =
    let t1 = { Hours = 1; Minutes = 30; AMPM = AM }
    let t2 = { Hours = 1; Minutes = 0; AMPM = PM }
    let r: int = diffMinutes t1 t2
    Assert.AreEqual<int> (690, r)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.B``() =
    let t1 = { Hours = 1; Minutes = 30; AMPM = AM }
    let t2 = { Hours = 1; Minutes = 0; AMPM = AM }
    let r: int = diffMinutes t1 t2
    Assert.AreEqual<int> (0, r)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.C``() =
    let t1 = { Hours = 10; Minutes = 0; AMPM = PM }
    let t2 = { Hours = 10; Minutes = 0; AMPM = PM }
    let r: int = diffMinutes t1 t2
    Assert.AreEqual<int> (0, r)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.D``() =
    let t1 = { Hours = 10; Minutes = 5; AMPM = PM }
    let t2 = { Hours = 1; Minutes = 0; AMPM = AM }
    let r: int = diffMinutes t1 t2
    Assert.AreEqual<int> (0, r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.A``() =
    let r = StraightLine (4, 4) |> mirrorX
    Assert.AreEqual (StraightLine (-4, -4), r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.B``() =
    let r = StraightLine (-1, 1) |> mirrorY
    Assert.AreEqual (StraightLine (1, 1), r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.C``() =
    let r = StraightLine (-1, -1) |> mirrorX
    Assert.AreEqual (StraightLine (1, 1), r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.D``() =
    let r = StraightLine (20, 20) |> mirrorY
    Assert.AreEqual (StraightLine (-20, 20), r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.A``() =
    let r = removeOdd [ 1; 2; 3; 4 ]
    Assert.AreEqual ([ 2; 4 ], r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.B``() =
    let r = removeOdd [ 3; 5; 1 ]
    Assert.AreEqual ([], r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.C``() =
    let r = removeOdd [ 0 ]
    Assert.AreEqual ([ 0 ], r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.D``() =
    let r = removeOdd [ -3; -2; -1; 0; 1; 2; 3 ]
    Assert.AreEqual ([ -2; 0; 2 ], r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.A``() =
    let r = getSmallest [ 1; 2; 3; 4 ]
    Assert.AreEqual (Some 1, r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.B``() =
    let r = getSmallest [ 1; 0; -1 ]
    Assert.AreEqual (Some -1, r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.C``() =
    let r = getSmallest [ 0 ]
    Assert.AreEqual (Some 0, r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.D``() =
    let r = getSmallest []
    Assert.AreEqual (None, r)

  [<TestMethod; Timeout 1000; TestCategory "5">]
  member __.``Problem 5.A``() =
    let r = take [ 1; 2; 3 ] 1u
    Assert.AreEqual ([ 1 ], r)

  [<TestMethod; Timeout 1000; TestCategory "5">]
  member __.``Problem 5.B``() =
    let r = take [ "a"; "b"; "c" ] 2u
    Assert.AreEqual ([ "a"; "b" ], r)

  [<TestMethod; Timeout 1000; TestCategory "5">]
  member __.``Problem 5.C``() =
    let r = take [ 1.1; 2.2; 3.3; 4.4 ] 5u
    Assert.AreEqual ([ 1.1; 2.2; 3.3; 4.4 ], r)

  [<TestMethod; Timeout 1000; TestCategory "5">]
  member __.``Problem 5.D``() =
    let r = take [ "a"; "b"; "c" ] 0u
    Assert.AreEqual ([], r)

  [<TestMethod; Timeout 1000; TestCategory "6">]
  member __.``Problem 6.A``() =
    let r = runLength [ "1"; "2"; "2"; "2"; "3"; "3" ]
    Assert.AreEqual ([ ("1", 1); ("2", 3); ("3", 2) ], r)

  [<TestMethod; Timeout 1000; TestCategory "6">]
  member __.``Problem 6.B``() =
    let r = runLength []
    Assert.AreEqual ([], r)

  [<TestMethod; Timeout 1000; TestCategory "6">]
  member __.``Problem 6.C``() =
    let r = runLength [ 1; 1; 2; 3; 3; 4; 4; 4; 3; 2 ]
    Assert.AreEqual ([ (1, 2); (2, 1); (3, 2); (4, 3); (3, 1); (2, 1) ], r)

  [<TestMethod; Timeout 1000; TestCategory "6">]
  member __.``Problem 6.D``() =
    let r = runLength [ 100; 100; 100; 100; 100 ]
    Assert.AreEqual ([ (100, 5) ], r)
