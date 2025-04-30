public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> List = new List<string>();
        for(int i=1;i<=n;i++){
            if(i % 15 == 0)
            {
                List.Add("FizzBuzz");
            }else if( i % 5 == 0)
            {
                List.Add("Buzz");
            }
            else if( i % 3 == 0)
            {
                List.Add("Fizz");
            }else{
                List.Add(i.ToString());
            }
        }
        return List;
   }
}