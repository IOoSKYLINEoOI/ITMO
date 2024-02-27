#include <iostream>

int main()
{
    system("chcp 1251");

    double money;

    std::cout << "Введите сумму которую нужно разменять: "; std::cin >> money;

    std::cout << "Выдать 10 рублевых монет: " << (int)money / 10 << std::endl;
    std::cout << "Выдать 5 рублевых монет: " << (int)money % 10 / 5 << std::endl;
    std::cout << "Выдать 2 рублевых монет: " << (int)money % 10 % 5 / 2 << std::endl;
    std::cout << "Выдать 1 рублевых монет: " << (int)money % 10 % 5 % 2 << std::endl;
    std::cout << "Выдать 50-ти копеечных монет: " << (int)(money * 100) % 100 / 50 << std::endl;
    std::cout << "Выдать 10-ти копеечных монет: " << (int)(money * 100) % 50 / 10 << std::endl;
    std::cout << "Выдать 1 копеечных монет: " << (int)(money * 100) % 50 % 10 << std::endl;
    return 0;
}
