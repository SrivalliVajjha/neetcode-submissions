
public class LRUCache {
    private class Node{
      public int Key {get; set;}
      public int Value {get; set;} 
      public Node Prev {get; set;}
      public Node Next {get; set;}

      public Node(int key,int value){
        Key = key;
        Value = value;
        Prev = null;
        Next = null;
      }

    }

    private Dictionary<int,Node> cache ;
    private int capacity = 0;
    private Node left;
    private Node right;

    public LRUCache(int capacity) {
       this.capacity = capacity;
       cache = new Dictionary<int,Node>();
       this.left = new Node(0,0);
       this.right = new Node(0,0); 
       left.Next = right;
       right.Prev = left;
    }

    // remove any Node
    private void Remove(Node node){
        Node Prev = node.Prev;
        Node Next = node.Next;
        Prev.Next = Next;
        Next.Prev = Prev;
    }

    //insert at right
    private void Insert(Node node){
       Node Prev = this.right.Prev;
       Node Next = this.right;
       node.Prev = Prev;
       node.Next = Next;
       Prev.Next = Next.Prev = node; 
    }

    
    public int Get(int key) {
        if(cache.ContainsKey(key)){
            Node node = cache[key];
            Remove(node);
            Insert(node);
           return node.Value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(cache.ContainsKey(key)){
            Remove(cache[key]);
        }
        Node newNode = new Node(key,value);
        cache[key] = newNode;
        Insert(newNode);

        if(cache.Count > this.capacity)
        {
             Node lru = left.Next;
             Remove(lru);
             cache.Remove(lru.Key);
        }
    }
}
