static void GetChoice(string txt1, string txt2, string txt3){
    bool exit=false;
    string resp="";

    while(!exit){
        Console.WriteLine("1) "+txt1);
        Console.WriteLine("2) "+txt2);
        Console.WriteLine("3) "+txt3);
        Console.WriteLine("Choose a word");
        resp=Console.ReadLine();

        if(resp=="1"||resp=="2"||resp=="3") exit=true;
        else{
             Console.WriteLine("Not a valid answer");
             Console.ReadLine();
             Console.Clear();
        }
    }
    switch(resp){
        case "1":
        Console.WriteLine(txt1);
        break;

        case "2":
        Console.WriteLine(txt2);
        break;

        case "3":
        Console.WriteLine(txt3);
        break;
    }
}