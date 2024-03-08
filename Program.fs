module CS220.Program

type AMPM =
  | AM
  | PM

/// Time is a record type that represents a time of day. It has three fields:
/// Hours, Minutes, and AMPM. Hours and Minutes are integers, and AMPM is a
/// discriminated union with two cases: AM and PM. For example, 3:45 PM is
/// represented as { Hours = 3; Minutes = 45; AMPM = PM }.
type Time = {
  Hours: int
  Minutes: int
  AMPM: AMPM
}

/// Write this function `diffMinutes` that  takes in two Time values t1 and t2
/// and returns how many minutes t1 is earlier than t2. For example, when t1 is
/// { Hours = 1; Minutes = 30; AMPM = AM } and t2 is { Hours = 1; Minutes = 0;
/// AMPM = PM }, then the function should return 690. If t1 is later than t2,
/// the function should return 0. You can assume that t1 and t2 are on the same
/// day. You can also assume that both t1 and t2 are well-formed (i.e., hours
/// are between 1 and 12, and minutes are between 0 and 59).
let diffMinutes t1 t2 =
  failwith "TODO" // REMOVE this line when you implement your own code

/// StraightLine represents a line in a 2D plane where the line is represented
/// by the equation y = ax + b. The first component is the slope a, and the
/// second component is the y-intercept b. For example, the line y = 3x + 2 is
/// represented as (3, 2).
type StraightLine = int * int

/// Write a function `mirrorX` that takes in a StraightLine and returns a new
/// StraightLine that represents the mirror image of the given line with respect
/// to the x-axis.
let mirrorX (line: StraightLine) =
  failwith "TODO" // REMOVE this line when you implement your own code

/// Write a function `mirrorY` that takes in a StraightLine and returns a new
/// StraightLine that represents the mirror image of the given line with respect
/// to the y-axis.
let mirrorY (line: StraightLine) =
  failwith "TODO" // REMOVE this line when you implement your own code

/// Write a function `removeOdd` that takes an integer list (int list) as input
/// and returns a new integer list without odd numbers. The resulting list
/// should preserve the order of the original list. For example, given [ 1; 2; 3
/// ] the function should return [ 2 ].
let removeOdd (lst: int list) =
  failwith "TODO" // REMOVE this line when you implement your own code

/// Write a function `getSmallest` that takes in list of integers as input and
/// returns the smallest number in the list (if exists). For example, given [ 1;
/// 2; 3 ] the function will return Some 1. If the given list is empty, than the
/// function simply returns None.
let getSmallest lst =
  failwith "TODO" // REMOVE this line when you implement your own code

/// Write a function `take` that takes in a list and an unsigned integer n
/// (uint32) as input, and returns the first n elements from the list. For
/// example, take [ "a"; "b"; "c" ] 1u returns [ "a" ]. If n is larger than the
/// length of the list, then the function returns the list as it is. When n is
/// zero, the function returns an empty list.
let take lst (n: uint32) =
  failwith "TODO" // REMOVE this line when you implement your own code

/// Write a function `runLength` that takes in a list and returns a list of
/// pairs by applying run-length encoding. Specifically, the function replace n
/// consecutive elements into a pair of (element, number of appearance). For
/// example, when a list [ 1; 2; 2; 2; 3; 3 ] is given, the function returns [
/// (1, 1); (2, 3); (3, 2) ], because 1 consecutively appears once, 2 appears
/// three times, and 3 appears twice.
let runLength lst =
  failwith "TODO" // REMOVE this line when you implement your own code

[<EntryPoint>]
let main _args =
  0
