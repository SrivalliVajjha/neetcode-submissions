public class Solution {
    public int NumIslands(char[][] grid) {
        if (grid == null){
            return 0;
        }
        int rows = grid.Length;
        int cols = grid[0].Length;
        int numOfIslands = 0;
        HashSet<(int,int)> visited = new HashSet<(int,int)>();


    void Bfs(int r, int c){
            Queue<(int,int)> queue = new Queue<(int,int)>();
            visited.Add((r,c));
            queue.Enqueue((r,c));
            while(queue.Count>0){
                var node = queue.Dequeue();
                var row = node.Item1;
                var col = node.Item2;

                int[][] directions = new int[][] {
                new int[] {0, 1},  // Right
                new int[] {0, -1}, // Left
                new int[] {1, 0},  // Down
                new int[] {-1, 0}  // Up
            };

            foreach(var dir in directions){
                int newRow = row + dir[0];
                int newCol = col + dir[1];
                if(newRow >= 0 && newRow < rows && 
                   newCol >= 0 && newCol < cols &&
                   grid[newRow][newCol] == '1' &&
                   !visited.Contains((newRow,newCol))){
                    queue.Enqueue((newRow,newCol));
                    visited.Add((newRow,newCol));
                   }
            }

        }


    }

        for(int i=0;i<rows;i++){
            for(int j=0;j<cols;j++){
                if(grid[i][j] == '1' && !visited.Contains((i,j))){
                    Bfs(i,j);
                    numOfIslands +=1;
                }
            }
        }
        return numOfIslands;

    }

 
}
