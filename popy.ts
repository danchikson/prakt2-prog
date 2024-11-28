function gcdOfStrings(str1: string, str2: string): string {
    // Перевірка, чи є комбінація рядків у різному порядку однаковою
    if (str1 + str2 !== str2 + str1) {
        return "";
    }

    // Знаходимо найбільший спільний дільник довжин рядків
    const gcdLength = gcd(str1.length, str2.length);

    // Повертаємо префікс довжиною gcdLength
    return str1.substring(0, gcdLength);
}

// Функція для знаходження найбільшого спільного дільника двох чисел
function gcd(a: number, b: number): number {
    return b === 0 ? a : gcd(b, a % b);
}
