namespace HostsTask;
public class Solution
{
    // Решенеие:
    // Создаем дерево забаненных хостов B[]
    // Потом пробегаемся по каждому хосту из A[]
    // Если в хосте A[i] содержится ветвь из дерева, то данный хост - забанненный
    // Иначе пользователь может в него зайти
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