/**
 * Definition for singly-linked list.
 * class ListNode {
 *     constructor(val = 0, next = null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

class Solution {
    /**
     * @param {ListNode} head
     * @return {void}
     */
    reorderList(head: ListNode | null): void {

            let s = head;
            let f = head;

            while(f != null && f.next != null){
                s = s.next;
                f = f.next!.next;                
            }
            
            let middle = s;

            let prev : ListNode | null = null;
            let curr = middle;

            while(curr != null){
                let next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            middle = prev;

            let first = head;
            let second = middle;

            while(second.next !== null){
                let fnext = first!.next;
                let snext = second!.next;

                first.next = second;
                second.next = fnext;

                first = fnext;
                second = snext; 
            }


    }
}
