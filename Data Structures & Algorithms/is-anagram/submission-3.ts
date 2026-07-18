class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s: string, t: string): boolean {
    if(s.length !== t.length) return false;
    const sortFun =(str:string) => str.split("").sort().join();
    return sortFun(s) === sortFun(t);
    }
}
