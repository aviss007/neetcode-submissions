public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] result = new int[n];
        Stack<int> _stack = new Stack<int>();
        for(int i = 0; i<n; i++)
        {
           while(_stack.Count() > 0 && temperatures[i] > temperatures[_stack.Peek()])
           {
             int prevIndex = _stack.Pop();
             result[prevIndex] = i - prevIndex;
           }
           _stack.Push(i);
        }
        return result;
    }
}
