Console.WriteLine("Write a number");
int i = Convert.ToInt32(Console.ReadLine());
int number=i;
if (i>0){
    while (i>0) {
        Console.Write(i*-1);
        i=i-1;
    };
    while (number>i) {
        Console.Write(i);
        i=i+1;
    };
};
