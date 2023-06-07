## Circle Pair Intersection

You are given a list of circles in the 2D plane, where each circle is represented by its center coordinates (x, y) and radius r. Your task is to implement the function `circlePairIntersection` that finds the number of pairs of circles that intersect each other.

Two circles are considered to intersect if they have at least one point in common.

Your function should return the count of intersecting pairs.

### Example

```js
circlePairIntersection([[0, 0, 1], [2, 0, 1], [0, 2, 1], [3, 3, 1]]);
// Output: 2
// The circles at coordinates (0, 0) and (2, 0) intersect each other.
// The circles at coordinates (0, 2) and (3, 3) intersect each other.

circlePairIntersection([[1, 1, 2], [3, 3, 1], [5, 1, 1]]);
// Output: 0
// There are no pairs of circles that intersect each other.
