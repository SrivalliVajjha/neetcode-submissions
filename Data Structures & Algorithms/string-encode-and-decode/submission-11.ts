class Solution {
    /**
     * @param {string[]} strs
     * @returns {string}
     */
    encode(strs: string[]): string {
        let encodedStr :string = "";
        for(const str of strs){
           encodedStr  += str.length + '}' + str;
        }
        console.log(encodedStr);
        return encodedStr;
    }

    /**
     * @param {string} str
     * @returns {string[]}
     */
    decode(str: string): string[] {
        const isDigit = (c:string) => {return  c >= '0' && c <= '9'};
        const res = [];
        for(let i=0;i<str.length; i++){
            if(isDigit(str[i])){
                let numStr = "";
                while (i < str.length && isDigit(str[i])) {
                    numStr += str[i];
                    i++;
                }
                const numI = Number(numStr);
                i++;
                const decStr = str.slice(i, i+numI);
                res.push(decStr);
                i = i+numI -1;
            }   
        }
      return res;
    }
}
