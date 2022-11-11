//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] i = solution("Введите числа через пробел");  
int[] solution(string text) 
{ 
    Console.WriteLine(text); 
    string[] Num = Console.ReadLine()
                                    .Split(new char [] {' ',','},
                                    StringSplitOptions.RemoveEmptyEntries);
    int[] arrayNum = new int[Num.Length]; 
    for (int i = 0; i < Num.Length; i++) 
    { 
       arrayNum[i] = int.Parse(Num[i]); 
    } 
    return arrayNum; 
}; 
int Count(int[] text) 
{ 
    int result = 0; 
    for (int i = 0; i < text.Length; i++) 
    { 
        if (text[i] > 0) result++; 
    } 
    return result; 
} 

int r=Count(i); 
Console.WriteLine(r); 

