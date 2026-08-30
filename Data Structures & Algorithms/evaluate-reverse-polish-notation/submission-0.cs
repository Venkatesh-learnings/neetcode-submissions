public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack=new();
        foreach(string s in tokens)
        {
            if(s=="+")
                stack.Push(Convert.ToInt32(stack.Pop() + stack.Pop()));
           else if(s=="-")
            {
                int a=stack.Pop();
                int b=stack.Pop();
                stack.Push(Convert.ToInt32(b-a));
            }
            else if(s=="*")
                stack.Push(Convert.ToInt32(stack.Pop() * stack.Pop()));
             else if(s=="/")
             {
                int a=stack.Pop();
                int b=stack.Pop();
                stack.Push(Convert.ToInt32(b/a));
             }
             else
                stack.Push(Convert.ToInt32(s));
        }
        return stack.Peek();
    }
}
