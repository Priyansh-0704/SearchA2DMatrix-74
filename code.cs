public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length; // Number of rows
        int n = matrix[0].Length; // Number of columns
        int startRow = 0, endRow = m - 1;
        int row = -1;
        while(startRow <= endRow)
        {
            int midRow = startRow + (endRow - startRow) / 2;
            if(target >= matrix[midRow][0] && target <= matrix[midRow][n - 1])
            {
                // target exists in this row
                row = midRow;
                break;
            } else if(target > matrix[midRow][n - 1])
            {
                // target exists one of the in next rows
                startRow = midRow + 1;
            } else 
            {
                // target exists in one of the upper rows
                endRow = midRow - 1;
            }
        }
        if(row == -1)
        {
            return false;
        }
        int startColm = 0, endColm = n - 1;
        while(startColm <= endColm)
        {
            int midColm = startColm + (endColm - startColm) / 2;
            if(target == matrix[row][midColm])
            {
                return true;
            } else if(target > matrix[row][midColm])
            {
                // target exists in any of right columns
                startColm = midColm + 1;
            } else
            {
                // target exists in any of left columns
                endColm = midColm - 1;
            }
        }
        return false;
    }
}
