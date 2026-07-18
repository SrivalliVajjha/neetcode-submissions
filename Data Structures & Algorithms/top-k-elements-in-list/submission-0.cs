public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
       Dictionary<int,int> frequency = new Dictionary<int,int>();
       foreach(int num in nums){
        if(frequency.ContainsKey(num)){
            frequency[num]++;
        }
        else{
            frequency[num]=0;
        }
       }

       PriorityQueue<int,int> heap = new PriorityQueue<int,int>();
       foreach(var pair in frequency){
         heap.Enqueue(pair.Key,pair.Value);
         
         if(heap.Count > k ){
            heap.Dequeue();
         }
       }

       List<int> kFrequentResult = new List<int>();
       while(heap.Count > 0){
        kFrequentResult.Add(heap.Dequeue());
       }
       
       return kFrequentResult.ToArray();
        
    }
}
