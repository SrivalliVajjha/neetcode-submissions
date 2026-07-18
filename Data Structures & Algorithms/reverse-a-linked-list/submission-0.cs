/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prevPointer = null;
        ListNode currPointer = head;
        while(currPointer != null){
            ListNode temp = currPointer.next; 
            currPointer.next = prevPointer;
            prevPointer = currPointer;
            currPointer = temp;
        }
        return prevPointer;
    }
}
