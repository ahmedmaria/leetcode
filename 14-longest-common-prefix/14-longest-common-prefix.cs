public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string prefix =strs[0];
        
     if( strs.Length==0 ) return "";
        
        for (int i =1; i<strs.Length;)
        {
           
            if (strs[i].IndexOf(prefix)==0)
                                                            
                i++;
            else
            {
                prefix = prefix.Substring(0, prefix.Length-1);
                
                
            }
                
            

        }
        return prefix;
        
     
        
        
        
        
    }
}