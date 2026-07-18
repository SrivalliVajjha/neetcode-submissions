/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 
public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> levelOrderList = new List<List<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();

        if(root !=null)
            queue.Enqueue(root);

        while(queue.Count > 0){
            List<int> levelList = new List<int>();
            int len = queue.Count;
            for(int i=0; i< len ;i++){
                TreeNode node = queue.Dequeue();
                levelList.Add(node.val);
                if(node.left != null )
                    queue.Enqueue(node.left);
                if(node.right != null)
                    queue.Enqueue(node.right);
            }
            levelOrderList.Add(levelList);
        }
      return levelOrderList;
    }
}
