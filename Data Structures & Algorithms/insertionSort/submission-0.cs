// Definition for a pair
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        List<List<Pair>> res=new List<List<Pair>>();

        for(int j=0;j<pairs.Count;j++){
            int k=j-1;
            while(k>=0&&pairs[k].Key>pairs[k+1].Key){
                Pair temp=pairs[k];
                pairs[k]=pairs[k+1];
                pairs[k+1]=temp;
                k--;
            }
            
List<Pair> cloneList = new List<Pair>(pairs);
            res.Add(cloneList);
        }
        return res;
    }
}
