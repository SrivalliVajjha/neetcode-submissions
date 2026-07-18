class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isPalindrome(s: string): boolean {
     const cleanStr = s.replace(/[^a-zA-Z0-9]/g, "").toLowerCase().split(" ").join("").trim();
     return cleanStr === cleanStr.split("").reverse().join("");
    }
}
