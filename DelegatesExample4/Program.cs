
Action<int>[] action_test = new Action<int>[3];

action_test[0] = myAction;
action_test[0] += myAction;
action_test[0] += myAction;
action_test[1] = myAction2;
action_test[1] += myAction2;
action_test[1] += myAction2;
action_test[2] = myAction3;
action_test[2] += myAction3;
action_test[2] += myAction3;

//Martins exempel
//Console.WriteLine(func_test[i](i));

for (int i = 0; i < action_test.Length; i++)
{
    Console.WriteLine(action_test[i](i));
}

string myAction(int i)
{
    return $"Hej {i}";
}

string myAction2(int i)
{
    return $"Goodbye {i}";
}

string myAction3(int i)
{
    return $"Au Reviour! {i}";
}

Console.ReadKey();


Func<string, string>[] func_test = new Func<string, string>[3];

func_test[0] = myFunc;
func_test[1] = myFunc2;
func_test[2] = myFunc3;

//Martins exempel
//Console.WriteLine(func_test[i](i));

for (int i = 0; i < func_test.Length; i++)
{
    Console.WriteLine(func_test[i]("Jonathan"));
}

string myFunc(string i)
{
    return $"Hej {i}";
}

string myFunc2(string i)
{
    return $"Goodbye {i}";
}

string myFunc3(string i)
{
    return $"Au Reviour! {i}";
}

Console.ReadKey();



//Func<string, string> func_test;

//func_test = myFunc;

//Console.WriteLine(func_test("Jonathan"));

//string myFunc(string i)
//{
//    return $"Hej {i}";
//}