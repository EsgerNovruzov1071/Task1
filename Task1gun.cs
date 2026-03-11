//TASK 1
//static bool Yoxla(string soz)
//{
//    bool reqem = false;
//    bool boyukHerf = false;
//    bool kicikHerf = false;

//    for (int i = 0; i < soz.Length; i++)
//    {
//        if (char.IsDigit(soz[i]))
//        {
//            reqem = true;
//        }
//        else if (char.IsUpper(soz[i]))
//        {
//            boyukHerf = true;
//        }
//        else if (char.IsLower(soz[i]))
//        {
//            kicikHerf = true;
//        }
//    }

//    return reqem && boyukHerf && kicikHerf;
//}
//string cumle = Console.ReadLine();
//bool netice = Yoxla(cumle);
//Console.WriteLine(netice);





//Task 2
//static bool Yoxla(string cumle)
//{
//    string[] sozler = cumle.Split(' ');

//    if (sozler.Length != 2)
//    {
//        return false;
//    }

//    if (char.IsUpper(sozler[0][0]) && char.IsUpper(sozler[1][0]))
//    {
//        return true;
//    }

//    return false;
//}
//string input = Console.ReadLine();
//bool netice = Yoxla(input);
//Console.WriteLine(netice);
