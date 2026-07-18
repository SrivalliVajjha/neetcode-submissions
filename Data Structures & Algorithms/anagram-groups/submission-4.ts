class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs: string[]): string[][] {
     const map = new Map<string,string[]>();
     
     const sort = (str : string) => str.split("").sort().join("");
     for(let str of strs){
          const sortArr = sort(str);
          if(!map.has(sortArr)){
            map.set(sortArr,[]);
          }
          map.get(sortArr)!.push(str);
     }
     
     return [...map.values()];

    }
}
