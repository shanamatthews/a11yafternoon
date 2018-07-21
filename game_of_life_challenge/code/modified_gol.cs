for (var i=0; i < grid.Length; i++)
{
    for (var j=0; j < grid[i].Length; j++)
    {
        var count = countNeighbors(grid, i, j);
        if (count < 2 || count > 3)
            result[i][j] = 0;
        else if (count == 2)
            result[i][j] = (grid[i][j] + 1) % 2;
        else
            result[i][j] = 1;
    }
}
