public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n=position.Length;
        int[][] pairs=new int[n][];
        for(int i=0;i<n;i++)
        {
            pairs[i]=new int[]{position[i],speed[i]};
        }
        Array.Sort(pairs,(a,b)=>b[0].CompareTo(a[0]));
        Stack<double> stack=new();
        foreach (var item in pairs) {
            stack.Push((double)(target-item[0])/item[1]);
            if(stack.Count>=2 && stack.Peek()<=stack.ElementAt(1))
                stack.Pop();
            
        }
        return stack.Count;
    }
}
