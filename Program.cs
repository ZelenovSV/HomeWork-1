    Console.WriteLine("Введите число №1:");
    string s1 = Console.ReadLine();
    int Number1 = int.Parse(s1);
    Console.WriteLine("Введите число №2:");
    string s2 = Console.ReadLine();
    int Number2 = int.Parse(s2);
    Console.WriteLine("Введите число №3:");
    string s3 = Console.ReadLine();
    int Number3 = int.Parse(s3);

        if (Number1 > Number2){
            if (Number1 > Number3)
            {
            Console.WriteLine("Максимальное число: " + Number1);
            }
            else{
            Console.WriteLine("Максимальное число: " + Number3);
            }}
        else{
            if (Number2 > Number3)
            {
            Console.WriteLine("Максимальное число: " + Number2);
        }    
            else{
            Console.WriteLine("Максимальное число: " + Number3);
        }}  