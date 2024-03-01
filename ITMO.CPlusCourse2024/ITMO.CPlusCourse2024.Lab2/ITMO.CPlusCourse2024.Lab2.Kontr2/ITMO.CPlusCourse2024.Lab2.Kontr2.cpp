#include <iostream>
#include <cmath>

bool CheckNumber(std::string number) {

    for (int i = 0; i < number.length(); i++) {
        if ("0123456789- ".find(number[i]) == -1) return false;
    }
    return true;
}

int main()
{
    system("chcp 1251");

    std::string number;
    int temp, summary = 0;
    bool flag = true;

    std::cout << "Введите 9-ти значный номер СНИЛС:" << std::endl;    std::cin >> number;

    //проверка основной части
    int number1 = number % 10;
    int number2 = number % 100 / 10;
    int number3;

    temp = number / 100;

    for (int i = 3; i <= 9; i++) {
        number3 = temp % 10;

        if (number1 == number2 && number2 == number3 && number1 == number3) {
            flag = false;
            std::cout << flag << std::endl;
            break;
        }
        
        number1 = number2;
        number2 = number3;
        temp = temp / 10;
    }

    if (!flag || number >= 999999999) {
        std::cout << "Введен невалидный номер СНИЛС" << std::endl;
        return 0;
    }

    //расчет контрольного числа
    temp = number;

    for (int j = 1; j <= 9; j++) {
        summary += j * (temp % 10);
        temp = temp / 10;
    }

    if (summary < 100) {
        std::cout << "Номер СНИЛС: "<< number << " " << summary << std::endl;
    }
    else if (summary == 100 || summary == 101) {
        std::cout << "Номер СНИЛС: " << number << " " << 00 << std::endl;
    }
    else {
        if (summary % 101 == 100) {
            std::cout << "Номер СНИЛС: " << number << " " << 00 << std::endl;
        }
        else {
            std::cout << "Номер СНИЛС: " << number << " " << summary % 101 << std::endl;
        }
    }
    return 0;
}
