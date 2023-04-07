namespace HostsTask;
public class Solution
{
    public static int[] solution(string[] A, string[] B)
    {
        PrefixTree tree = new PrefixTree(B);
        List<int> result = new List<int>();

        for(int i = 0; i < A.Length; i++) 
        {
           if (!tree.Contain(A[i])) // mean what host is not ban
            {
                result.Add(i);
            }
        }


        return result.ToArray();
    }
}