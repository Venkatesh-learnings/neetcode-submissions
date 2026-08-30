public class MinStack {
private readonly Stack<int> _stack;
    public MinStack() {
       _stack=new Stack<int>();
    }
    
    public void Push(int val) {
       _stack.Push(val);
    }
    
    public void Pop() {
        if(_stack.Count>0)
            _stack.Pop();
        return;
    }
    
    public int Top() {
           
            
        return _stack.Peek();
    }
    
    public int GetMin() {
        Stack<int> tmp=new Stack<int>();
        int mini=_stack.Peek();

        while(_stack.Count>0){
            mini=Math.Min(mini,_stack.Peek());
            tmp.Push(_stack.Pop());
        }
        while(tmp.Count>0){
            _stack.Push(tmp.Pop());
        }
        return mini;
    }
}
