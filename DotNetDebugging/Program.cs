//Fibonacci dizisi, 0 ve 1 ile başlayan ve her sayının kendisinden önce gelen iki sayının toplamı olduğu bir sayı dizisidir.

int result = Fibonacci(5);
Console.WriteLine(result);

static int Fibonacci(int n){

    int n1=0;
    int n2=1;
    int sum;
    
    for(int i = 2; i< n; i++){
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }
    return n == 0 ? n1 : n2;
}

