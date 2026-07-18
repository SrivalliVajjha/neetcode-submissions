public class Solution {
    public bool IsValid(string s) {
        Dictionary<char,char> pairs = new Dictionary<char,char>(){
            [']'] = '[',
            [')'] =  '(',
            ['}'] = '{'
        };
        
        Stack<char> stack = new Stack<char>();

        foreach(char ch in s){
            if(!pairs.ContainsKey(ch)){
                stack.Push(ch);
            }
           else{
            if (stack.Count == 0)
                return false;
            else{
                char poppedChar = stack.Pop();
                if(poppedChar != pairs[ch])
                    return false;
            }
           }
        }
        return stack.Count == 0;
    }
}
