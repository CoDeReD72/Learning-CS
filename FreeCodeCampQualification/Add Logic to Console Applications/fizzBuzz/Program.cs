
// THIS IS NOT THE OPTIMAL SOLUTION FOR FIZZ BUZZ

for(int i=1;i<=100; i++){
    if(i%3==0 && i%5==0){
        System.Console.WriteLine($"{i} - FizzBuzz");
    }
    else if(i%3==0){
        System.Console.WriteLine($"{i} - Fizz");
    }
    else if(i%5==0){
        System.Console.WriteLine($"{i} - Buzz");
    }
    else{
        System.Console.WriteLine(i);
    }

}