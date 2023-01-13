class Solution: #Defining the class Solution

    def groupAnagrams(self, strs): # Defining function groupAnagrams which takes input as strs

        result = {} #empty dictionary to store the anagrams

        for i in strs: #Iterating the input list
            x = "".join(sorted(i)) # if x already present in result then append current word i to the values of that key

            if x in result:
                result[x].append(i)#if already present in result then append current word i to the values of the key

            else:
                result[x] = [i]#if x not present in result then add new key with current word i as values.

            return
        list(result.values())#returning the values of result as a list

    ob1 = Solution()#creating instance of class solution

    print(ob1.groupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]))#calling the function and passing the input list as parameter
