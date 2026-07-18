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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode l3 = new ListNode();
        ListNode curr = l3;
       
        int carry =0;
        while(l1 != null || l2 !=null || carry !=0){
            int v1 = (l1 == null) ? 0 : l1.val;
            int v2 = (l2 == null) ? 0 : l2.val;
           int sum = v1 + v2 + carry;
            carry = sum / 10;
            sum = sum % 10;
            curr.next = new ListNode(sum);

            curr = curr.next;
            l1 = (l1 == null) ? null : l1.next;
            l2 = (l2 == null) ? null: l2.next;
        }

        return l3.next;
    }
}
