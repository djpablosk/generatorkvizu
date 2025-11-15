using generatorkvizu;

questions questions = new questions();
engine ENGINE = new engine();
ENGINE.begin();
Thread.Sleep(500);

questions.loadQuestion1();

Console.WriteLine("Napis svoju odpoved cislom:");
Console.ReadLine();
questions.LoadAnswer1();

Thread.Sleep(500);
Console.WriteLine("Pre pokracovanie stlac ENTER......");
Console.ReadLine();
Console.Clear();

questions.loadQuestion2();
Console.WriteLine("Napis svoju odpoved pismenom:");
Console.ReadLine();
questions.LoadAnswer2();

Thread.Sleep(500);
Console.WriteLine("Pre ukoncenie stlac ENTER....");
Console.ReadLine();
ENGINE.end();



