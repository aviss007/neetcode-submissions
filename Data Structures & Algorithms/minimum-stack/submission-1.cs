public class MinStack {

      private readonly Stack<(int Value, int Min)> _stack;

    public MinStack()
    {
        _stack = new Stack<(int Value, int Min)>();
    }

    public void Push(int val)
    {
        if (_stack.Count == 0)
        {
            // If the stack is empty, the item itself is the minimum
            _stack.Push((val, val));
        }
        else
        {
            // Compare the new value with the current minimum at the top of the stack
            int currentMin = _stack.Peek().Min;
            int newMin = Math.Min(val, currentMin);
            _stack.Push((val, newMin));
        }
    }

    public void Pop()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        _stack.Pop();
    }

    public int Top()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return _stack.Peek().Value;
    }

    public int GetMin()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return _stack.Peek().Min;
    }
}
