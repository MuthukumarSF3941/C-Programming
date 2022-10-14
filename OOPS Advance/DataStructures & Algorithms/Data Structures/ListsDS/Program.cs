

namespace ListsDS;

class Program
{
    public static void Main(string[] args)
    {
        List<int> datas=new List<int>();

        List<int> data1=new List<int>() {10,20,30,40};
        datas.Add(10);
         datas.Add(11);
          datas.Add(12);
           datas.Add(13);
            datas.Add(14);
             datas.Add(15);

             datas.Insert(2,60);

             datas.RemoveAt(3);
             datas.Remove(14);

             datas.AddRange(data1);


            System.Console.WriteLine("---------for loop-----------");
             for (int i = 0; i < datas.Count; i++)
             {
                System.Console.WriteLine(datas[i]);
             }


             System.Console.WriteLine("---------for Each loop-----------");
            foreach (int data in datas)
             {
                System.Console.WriteLine(data);
             }

               System.Console.WriteLine("---------for Each loop2-----------");
            foreach (int data in datas)
             {
                System.Console.WriteLine(data);
             }






        
    }
}
