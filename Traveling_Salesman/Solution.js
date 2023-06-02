// Solution to The Perplexing Traveling Salesman challenge

function distance(city1, city2) {
  const dx = city1.x - city2.x;
  const dy = city1.y - city2.y;
  return Math.sqrt(dx * dx + dy * dy);
}

function travelingSalesman(cities) {
  const n = cities.length;
  const visited = new Array(n).fill(false);
  const currentPath = [];
  let shortestPath = [];
  let shortestDistance = Number.MAX_VALUE;

  function backtrack() {
    if (currentPath.length === n) {
      const pathDistance = currentPath.reduce((total, cityIdx, i) => {
        const currentCity = cities[cityIdx];
        const nextCity = cities[currentPath[(i + 1) % n]];
        return total + distance(currentCity, nextCity);
      }, 0);

      if (pathDistance < shortestDistance) {
        shortestDistance = pathDistance;
        shortestPath = [...currentPath];
      }

      return;
    }

    for (let i = 0; i < n; i++) {
      if (!visited[i]) {
        visited[i] = true;
        currentPath.push(i);
        backtrack();
        currentPath.pop();
        visited[i] = false;
      }
    }
  }

  backtrack();

  return shortestPath;
}

module.exports = travelingSalesman;
