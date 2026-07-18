class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isValid(s: string): boolean {
        let pairs = new Map([
            [')','('],
            ['}','{'],
            [']','[']
        ]);
        let stack = [];

        let i=0;
        while(i<s.length){
            if(s[i] === '{' || s[i] === '(' || s[i] === '['){
                    stack.push(s[i]);
            }
            else{
                let val = stack.pop();
                if(val !== pairs.get(s[i])) return false;
            }
            i++;
        }
        
        return stack.length === 0;
    }
}
