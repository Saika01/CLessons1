int[] arr = new int[3];
Console.WriteLine("Input first number");
arr[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
arr[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number");
arr[2] = Convert.ToInt32(Console.ReadLine());
int count = 0;
int max = 0;
while (count<arr.Length){
    if (arr[count]>max){
        max = arr[count];
    }
    count++;
};
Console.WriteLine(max + " is the maximum number");