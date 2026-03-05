// TASK1 
//static int characterCount(string sentence)
//{
//    int uzunluq = 0;

//    for (int i = 0; i < sentence.Length; i++)
//    {
//        uzunluq += 1;
//    }

//    return uzunluq;
//}

//string sentence = Console.ReadLine();
//int netice = characterCount(sentence);

//Console.WriteLine(netice);


// TASK2
//int ay = 1;

//switch (ay)
//{
//    case 1:
//        Console.WriteLine("Yanvar");
//        break;

//    case 2:
//        Console.WriteLine("Fevral");
//        break;

//    case 3:
//        Console.WriteLine("Mart");
//        break;

//    case 4:
//        Console.WriteLine("Aprel");
//        break;

//    case 5:
//        Console.WriteLine("May");
//        break;

//    case 6:
//        Console.WriteLine("Iyun");
//        break;

//    case 7:
//        Console.WriteLine("Iyul");
//        break;

//    case 8:
//        Console.WriteLine("Avqust");
//        break;

//    case 9:
//        Console.WriteLine("Sentyabr");
//        break;

//    case 10:
//        Console.WriteLine("Oktyabr");
//        break;

//    case 11:
//        Console.WriteLine("Noyabr");
//        break;

//    case 12:
//        Console.WriteLine("Dekabr");
//        break;

//    default:
//        Console.WriteLine("1 ile 12 araliginda eded daxil edin");
//        break;
//}


// TASK3
//static int FindMax(int[] arr)
//{
//    int max = arr[0];

//    for (int i = 1; i < arr.Length; i++)
//    {
//        if (arr[i] > max)
//        {
//            max = arr[i];
//        }
//    }

//    return max;
//}
//int[] arr = { 1, 2, 56, 43, 2 };
//int max = FindMax(arr);
//Console.WriteLine(max);



// TASK5
//static void Muqayise(int a, int b)
//{
//    int hasil = a * b;
//    int cem = a + b;

//    if (hasil > cem)
//        Console.WriteLine("hasil daha boyukdur");
//    else if (hasil < cem)
//        Console.WriteLine("cem daha boyukdur");
//    else
//        Console.WriteLine("hasil ve cem beraberdir");
//}
//int a = 4;
//int b = 5;
//Muqayise(a, b);



// TASK4
//double CalculateAverage(int a, int b, int c)
//{
//    double average = (a + b + c) / 3.0;
//    return average;
//}

//int a = 1;
//int b = 2;
//int c = 3;

//double result = CalculateAverage(a, b, c);
//Console.WriteLine(result);



// Task 6
//static string Yoxla(int eded, int[] arr)
//{
//    string cavab = "Yoxdu";

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] == eded)
//        {
//            cavab = "Var";
//            break;
//        }
//    }

//    return cavab;
//}

//int[] arr = { 1, 2, 3, 4, 5, 6 };
//int eded = 4;
//Console.WriteLine(Yoxla(eded, arr));



// Task 7
//static int FindMin(int[] arr)
//{
//    int min = arr[0];

//    for (int i = 1; i < arr.Length; i++)
//    {
//        if (arr[i] < min)
//        {
//            min = arr[i];
//        }
//    }

//    return min;
//}
//int[] arr = { 1, 2, 56, 43, 2 };
//int result = FindMin(arr);
//Console.WriteLine(result);



// Task 8
//static void Ters(int[] arr)
//{
//    for (int i = arr.Length - 1; i >= 0; i--)
//    {
//        Console.Write(arr[i] + " ");
//    }
//}
//int[] arr = { 1, 2, 3, 4, 5 };
//Ters(arr);




// Task 1
//int[] array = { 33, 5, 8, 10, 1, 3, 15, 20, 25 };
//int min = array[0]; 

//for (int i = 1; i < array.Length; i++)
//{
//    if (array[i] < min)
//    {
//        min = array[i]; 
//    }
//}

//Console.WriteLine("Array-dəki ən kiçik element: " + min);



// Task 2
//int[] array = { 33, 5, 8, 10, 1, 3, 15, 20, 25 };
//int max = array[0]; // ilk elementi ən böyük kimi qəbul edirik

//for (int i = 1; i < array.Length; i++)
//{
//    if (array[i] > max)
//    {
//        max = array[i]; // daha böyük element tapılarsa, yeniləyirik
//    }
//}

//Console.WriteLine("Array-dəki ən böyük element: " + max);



// Task 3
//int[] array = { 33, 5, 8, 10, 1, 3, 15, 20, 25 };

//Console.WriteLine("Array-dəki tək ədədlər:");

//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 != 0) // tək ədəd şərti
//    {
//        Console.Write(array[i] + " ");
//    }
//}



// Task 4
//int[] array = { 33, 5, 8, 10, 1, 3, 15, 20, 25 };

//Console.WriteLine("Array-dəki cüt ədədlər:");

//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 == 0) // cüt ədəd şərti
//    {
//        Console.Write(array[i] + " ");
//    }
//}



// Task 5
//int[] array = { 33, 5, 8, 10, 1, 3, 15, 20, 25 };
//int sum = 0;

//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 != 0) 
//    {
//        sum += array[i]; 
//    }
//}

//Console.WriteLine("Array-dəki tək ədədlərin cəmi: " + sum);



// Tasdk 6
//int[] array = { 33, 5, 8, 10, 1, 3, 15, 20, 25 };
//int eded; 

//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 == 0) 
//    {
//        eded array[i]; 
//    }
//}

//Console.WriteLine("Array-dəki cüt ədədlərin hasili: " + eded);




// Task 9
//int[] array = { 33, 5, 8, 10, 1, 3, 15, 20, 25 };

//int min = array[0]; 
//int max = array[0];

//for (int i = 1; i < array.Length; i++)
//{
//    if (array[i] < min)
//        min = array[i];
//    if (array[i] > max)
//        max = array[i];
//}

//int difference = max - min;
//Console.WriteLine("Array-də ən böyük və ən kiçik elementin fərqi: " + difference);



// Task 10
//int[] array = { 33, 5, 8, 10, 1, 3, 15, 20, 25 };
//int maxOdd = 0; 

//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 != 0) 
//    {
//        if (array[i] > maxOdd)
//        {
//            maxOdd = array[i]; 
//        }
//    }
//}

//if (maxOdd == 0)
//    Console.WriteLine("Array-də tək ədəd yoxdur.");
//else
//    Console.WriteLine("Array-dəki tək ədədlərin ən böyüyü: " + maxOdd);



// Task 11
//int[] array = { 33, 5, 8, 10, 1, 3, 15, 20, 25 };
//int minEven = 0;

//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 == 0) 
//    {
//        if (minEven == 0 || array[i] < minEven)
//        {
//            minEven = array[i]; 
//        }
//    }
//}

//if (minEven == 0)
//    Console.WriteLine("Array-də cüt ədəd yoxdur.");
//else
//    Console.WriteLine("Array-dəki cüt ədədlərin ən kiçiyi: " + minEven);