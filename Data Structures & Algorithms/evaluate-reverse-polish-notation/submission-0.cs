public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> result = new Stack<int>();
        foreach(var token in tokens){
            if(token == "+" || token == "-" || token == "*" || token == "/")
            {
                int b = result.Pop();
                int a = result.Pop();
                switch(token)
                {
                    case "+":
                        result.Push(a + b);
                        break;
                    case "-":
                        result.Push(a - b);
                        break;    
                    case "*":
                        result.Push(a * b);
                        break;
                    case "/":
                        result.Push(a / b);
                        break;   
                }
            }
            else
            {
                result.Push(int.Parse(token));
            }
        }
        return result.Peek();
    }
}
