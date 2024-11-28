public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        // Якщо сума двох рядків не дорівнює один одному в різному порядку, немає спільного дільника
        if ((str1 + str2) != (str2 + str1)) {
            return "";
        }
        
        // Знаходимо найбільший спільний дільник довжин рядків
        int gcdLength = Gcd(str1.Length, str2.Length);
        
        // Повертаємо префікс довжини gcdLength, який є спільним дільником
        return str1.Substring(0, gcdLength);
    }

    private int Gcd(int a, int b) {
        // Реалізація алгоритму Евкліда для знаходження НСД
        return b == 0 ? a : Gcd(b, a % b);
    }
}
