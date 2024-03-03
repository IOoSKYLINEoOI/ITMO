#include <iostream>

int main()
{
    system("chcp 1251");

    const int n = 10;
    int mas[n];
    int s = 0;
    double sumneg = 0, sumpoz = 0, sumnech = 0, sumchet = 0;

    for (int i = 0; i < n; i++)
    {
        std::cout << "mas[" << i << "]=";
        std::cin >> mas[i];

        s += mas[i];

        if (mas[i] < 0) {
            sumneg += mas[i];
        }
        else {
            sumpoz += mas[i];
        }

        if (i % 2 == 0) {
            sumchet += mas[i];
        }
        else {
            sumnech += mas[i];
        }
        
    }

    double sred = s / (double)n;

    std::cout << "Сумма элементов массива: " << s << std::endl;
    std::cout << "Среднеарифметическое элементов массива: " << sred << std::endl;
    std::cout << "Сумма отрицательных элементов массива: " << sumneg << std::endl;
    std::cout << "Сумма положительных элементов массива: " << sumpoz << std::endl;
    std::cout << "Сумма четных элементов массива: " << sumchet << std::endl;
    std::cout << "Сумма нечетных элементов массива: " << sumnech << std::endl;

    return 0;
}
