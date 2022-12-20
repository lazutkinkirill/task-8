Console.Clear();

Console.Write("введите число ");

 int a = Convert.ToInt32(Console.ReadLine());
       int res = 1;
       while (res < a)
       {
        Console.WriteLine(res+1);
        res+= 2;
       }
    
