//for (int i = 1; i < 10; i++)
//{
//    Console.WriteLine(i);
//}


//int cem = 0;
//for (int i = 1; i < 50; i++)
//{
//    cem += i;

//}
//Console.WriteLine(cem);


//for (int i = 10; i > 1; i--)
//{
//    Console.WriteLine(i);
//}


//for (int i = 1; i < 20; i++)
//{
//    if (i % 2 == 0)
//        Console.WriteLine(i);
//}


//for (int i = 1; i < 20; i++)
//{
//    if (i % 2 == 1)
//        Console.WriteLine(i);
//}


//int cem = 0;
//int say = 0;
//for (int i = 1; i < 100; i++)
//{
//    cem += i;
//    say += 1;
//}
//int ortalama = cem / say;
//Console.WriteLine(ortalama);



//for (int i = 1; i < 100; i++)
//    {
//        if (i % 5 == 0 && i % 7 == 0)
//        {
//            Console.WriteLine(i);
//        }
//    }   

//int cemCut = 0;
//int cemTek = 0;
//for (int i = 1; i < 10; i++)
//{
//    if (i % 2 == 0)
//    {
//        cemCut += i;
//    }
//    else
//    {
//        cemTek += i;
//    }
//}
//Console.WriteLine($"{cemTek}, {cemCut}");

//int grade = 87;
//if (grade >= 90)
//    Console.WriteLine("A");
//else if (grade >= 80)
//    Console.WriteLine("B");
//else if (grade >= 70)
//    Console.WriteLine("C");
//else
//    Console.WriteLine("UGURSUZ");


//int[] massiv = [12, 14, 35, 56, 68, 93];
//int cem = 0;
//for (int i = 0; i < massiv.Length; i++)
//{
//    cem += massiv[i];
//}
//Console.WriteLine(cem);


//int[] massiv = [12, 14, 35, 56, 68, 93];
//for (int i = 0; i < massiv.Length; i++)
//{
//    if (i % 2 == 1)
//        Console.WriteLine(massiv[i]);
//}


//int[] massiv = [12, 14, 35, 56, 68, 93];
//int cemCut = 0;
//for (int i = 0; i < massiv.Length; i++)
//{
//    if (i % 2 == 0)
//        cemCut += massiv[i];
//}
//Console.WriteLine(cemCut);

// -----------------------------------------------------------------------------

//int yas = int.Parse(Console.ReadLine());
//if (yas <= 0 || yas >= 125)
//    Console.WriteLine("EDED MUSBET VE 125DEN KICIK OOLMALIDIR");
//else
//{
//    if (yas >= 65)
//        Console.WriteLine("catib");
//    else
//        Console.WriteLine("catmayib");
//}


//int yas = int.Parse(Console.ReadLine());
//if (yas <= 0)
//    Console.WriteLine("EDED MUSBET OLMALIDIR");
//else
//{
//    if (yas % 2 == 0)
//        Console.WriteLine("Cut");
//    else
//        Console.WriteLine("Tek");
//}


//int yas = int.Parse(Console.ReadLine());
//if (yas <= 0)
//    Console.WriteLine("EDED MUSBET OLMALIDIR");
//else
//{
//    if (yas % 3 == 0 && yas % 7 == 0)
//        Console.WriteLine("Bolunur");
//    else
//        Console.WriteLine("Bolunmur");
//}


//int yas = int.Parse(Console.ReadLine());
//if (yas <= 0)
//    Console.WriteLine("EDED MUSBET OLMALIDIR");
//else
//{
//    if (yas % 2 == 0)
//        Console.WriteLine("Bolunur");
//    else
//    {
//        int qaliq = yas % 2;
//        Console.WriteLine($"{qaliq} qaliq");
//    }
//}


//int yas = int.Parse(Console.ReadLine());
//int yas1= int.Parse(Console.ReadLine());
//if (yas * yas1 > 0)
//    Console.WriteLine("Musbet");
//else
//    Console.WriteLine("Menfi");



//string name = Console.ReadLine();
//string surName = Console.ReadLine();
//string fullName = name  + " "+ surName;
//Console.WriteLine(fullName);



//int boy = int.Parse(Console.ReadLine());
//int ceki = int.Parse(Console.ReadLine());
//int bmi = ceki / (boy * boy);

//if (bmi >= 30)
//    Console.WriteLine("piylənmə");
//else if (bmi >= 25)
//    Console.WriteLine("artıq çəki");
//else if (bmi >= 18.5)
//    Console.WriteLine("normal");
//else
//    Console.WriteLine("arıq");


//int eded = int.Parse(Console.ReadLine());
//int fakt = 1;
//for (int i = 1; i <= eded; i++)
//{
//    fakt *= i;
//}
//Console.WriteLine(fakt);



//int[] massiv = [1,2,3,4];
//int result = 0;
//for (int i = 0; i < massiv.Length; i++)
//{
//    if (massiv[i] > result && massiv[i] % 2 == 1)
//        result = massiv[i];
//}
//if (result == 0)
//    Console.WriteLine("massivde tek eded yoxdur");
//else
//    Console.WriteLine(result);



//int[] massiv = [1, 2, 3, 4];
//int min = massiv[0];
//int max = massiv[0];
//for (int i = 0; i < massiv.Length; i++)
//{
//    if (massiv[i] < min)
//        min = massiv[i];
//    if (massiv[i] > max)
//        max = massiv[i];
//}
//int edediOrta = min + max / 2;
//Console.WriteLine(edediOrta);



//int[] massiv = [1, 2, 3, 4];
//int min = massiv[0];
//int max = massiv[0];
//for (int i = 0; i < massiv.Length; i++)
//{
//    if (massiv[i] < min)
//        min = massiv[i];
//    if (massiv[i] > max)
//        max = massiv[i];
//}
//int cem = 0;
//for (int i = 0;i < massiv.Length; i++)
//{
//    if (massiv[i] != min || massiv[i] != max)
//        cem += massiv[i];
//}
//Console.WriteLine(cem);


