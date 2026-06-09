public class MinStack {
 Stack<int> stack;
 Stack<int> minStack;
    public MinStack() {
      stack  =new Stack<int>();
      minStack=new Stack<int>();
    }
    
    public void Push(int val) {
     stack.Push(val);   
     val=Math.Min(val,minStack.Count==0?val:minStack.Peek());
     minStack.Push(val);
    }
    
    public void Pop() {
     if(stack.Count!=0)
        stack.Pop();
     if(minStack.Count!=0)
     minStack.Pop();   
    }
    
    public int Top() {
     //if(stack.Count!=0)
        return stack.Peek();
      
    }
    
    public int GetMin() {
    //if(minStack.Count!=0)
        return minStack.Peek();   
    }
}
