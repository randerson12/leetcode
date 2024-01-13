public class Solution {
    // DFS solution
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if (image[sr][sc] != color)
        {
            Fill(image, sr, sc, image[sr][sc], color);
        }

        return image;
    }

    private static void Fill(
        int[][] image,
        int sr,
        int sc,
        int replacingColor,
        int newColor
    ) {
        image[sr][sc] = newColor;

        if (sr > 0 && image[sr - 1][sc] == replacingColor)
        {
            Fill(image, sr - 1, sc, replacingColor, newColor);
        }
        if (sr < image.Length - 1 && image[sr + 1][sc] == replacingColor)
        {
            Fill(image, sr + 1, sc, replacingColor, newColor);
        }
        if (sc > 0 && image[sr][sc - 1] == replacingColor)
        {
            Fill(image, sr, sc - 1, replacingColor, newColor);
        }
        if (sc < image[sr].Length - 1 && image[sr][sc + 1] == replacingColor)
        {
            Fill(image, sr, sc + 1, replacingColor, newColor);
        }
    }
}
