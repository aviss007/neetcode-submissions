public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length-1;
        int maxArea = 0;
        int area = 0;
        while(left<right){
           area = (right - left) * Math.Min(heights[left],heights[right]);
           if(maxArea<area){
            maxArea = area;
           }
           if(heights[left] < heights[right]){
            left++;
           }
           else{
            right --;
           }
        }
        return maxArea;
    }
}
