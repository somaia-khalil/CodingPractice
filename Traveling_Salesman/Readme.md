## The Perplexing Traveling Salesman

You are given a list of cities `cities` and their coordinates in the 2D plane. Your task is to implement the function `travelingSalesman` that finds the shortest possible route that visits all cities exactly once and returns to the starting city.

The distance between two cities can be calculated as the Euclidean distance between their coordinates.

Your function should return a list of city indices in the order of the shortest route.

### Example

```js
travelingSalesman([
  { name: "A", x: 0, y: 0 },
  { name: "B", x: 1, y: 2 },
  { name: "C", x: 3, y: 1 },
  { name: "D", x: 4, y: 3 }
]);
// Output: [0, 2, 1, 3]
// The shortest route starts at city A, goes to city C, then to city B, and finally returns to city A.

travelingSalesman([
  { name: "New York", x: 0, y: 0 },
  { name: "Los Angeles", x: 3, y: 5 },
  { name: "Chicago", x: 6, y: 2 },
  { name: "San Francisco", x: 9, y: 7 }
]);
// Output: [0, 2, 1, 3]
// The shortest route starts at city New York, goes to city Chicago, then to city Los Angeles, and finally returns to city New York.
