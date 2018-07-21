for i in range(len(grid)):
    for j in range(len(grid[i])):
        count = countNeighbors(grid, i, j)
        if count < 2 or count > 3:
            result[i][j] = 0
        elif count == 2:
            result[i][j] = (grid[i][j] + 1) % 2
        else:
            result[i][j] = 1
