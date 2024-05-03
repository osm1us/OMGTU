inf = float('inf')
matrix = [
    [inf, 5, 4, 2, 11],
    [12, inf, 11, 13, 10],
    [6, 4, inf, 7, 10],
    [4, 3, 5, inf, 12],
    [4, 2, 3, 5, inf],
]

def c_min():
    pass

def find_row_col_min(matrix, coords):
    h_i = min(matrix[coords[0]])
    h_j = min([row[coords[1]] for row in matrix])
    return h_i + h_j


def get_last_ribs(matrix):
    return [
        (i, j)
        for i in range(len(matrix))
        for j in range(len(matrix))
        if matrix[i][j] == 0
    ]


def voyager(matrix, w, path):
    if len(path) > 2:
        print((w, path + get_last_ribs(matrix)))
        return
    H = 0
    for _ in range(len(matrix)):
        row = matrix[_]
        m = min(row)
        H += m


        matrix[_] = [i - m for i in row]
    print(matrix)
    for _ in range(len(matrix)):
        m = min([row[_] for row in matrix])
        H += m
        for n in range(len(matrix)):
            matrix[n][_] -= m
    max_v = 0
    coords = None
    for i in range(len(matrix)):
        for j in range(len(matrix)):
            if matrix[i][j] == 0:
                result = find_row_col_min(matrix, (i, j))
                if result >= max_v:
                    max_v = result
                    coords = (i, j)

    for i in range(len(matrix)):
        for j in range(len(matrix)):
            if i == coords[0] or j == coords[1]:
                matrix[i][j] = inf
    new_path = path + [coords]
    for _ in range(len(new_path)):
        cur_path = [new_path[_]]
        for n in range(len(new_path)):
            if _ == n:
                continue
            if cur_path[-1][1] == new_path[n][0]:
                cur_path += [new_path[n]]
        matrix[cur_path[-1][1]][cur_path[0][0]] = inf

    voyager(matrix, w + H, new_path)

print(voyager(matrix, 0, []))
