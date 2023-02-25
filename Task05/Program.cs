Console.WriteLine("Write a number");
int i = Convert.ToInt32(Console.ReadLine());
int number= -i;
if (i>0){
    while (number<=i) {
        Console.Write(number+" ");
        number=number+1;
    };
};
