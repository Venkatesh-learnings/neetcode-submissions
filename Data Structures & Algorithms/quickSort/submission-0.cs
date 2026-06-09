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
    public List<Pair> QuickSort(List<Pair> pairs) {
     QuickSortHelper(pairs,0,pairs.Count-1);
     return pairs;
    }

    public void QuickSortHelper(List<Pair> arr,int s,int e){
    if(e-s+1<=1)
     return; 
     int left=s;
     var pivot=arr[e];
     
    for(int i=s;i<e;i++){
        if(arr[i].Key<pivot.Key){
            var temp=arr[left];
            arr[left]=arr[i];
            arr[i]=temp;
            left++;
        }
    }
    arr[e]=arr[left];
    arr[left]=pivot;

    QuickSortHelper(arr,s,left-1);
    QuickSortHelper(arr,left+1,e);
    }
}
