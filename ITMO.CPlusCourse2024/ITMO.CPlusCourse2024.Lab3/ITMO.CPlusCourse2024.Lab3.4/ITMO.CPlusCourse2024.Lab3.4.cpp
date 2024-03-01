#include <iostream>

int addNumders(int n)
{
    if (n == 1) return 1; 
    else return (n + addNumders(n - 1));
}

int addNumders(int n, int nn)
{
    if (n == nn) return 0;
    else return ((nn + addNumders(nn - 1)) - (n + addNumders(n - 1)));
}

int gcd(int m, int n)
{
    if (n == 0) return m;
    return gcd(n, m % n);
}

int main()
{
    system("chcp 1251");

    int n, x0, x1, y0, y1;

    std::cout << "Введите число, для подсчета суммы от 0 до n: "; std::cin >> n;
    std::cout << "Ответ: " << addNumders(n) << std::endl;

    std::cout << "Введите число, начала интервала: "; std::cin >> x0;
    std::cout << "Введите число, конца интервала: "; std::cin >> x1;
    std::cout << "Ответ: " << addNumders(x0, x1) << std::endl;

    std::cout << "Нахождение НОД" << std::endl;
    std::cout << "Введите число 1: "; std::cin >> y0;
    std::cout << "Введите число 2: "; std::cin >> y1;
    std::cout << "Ответ: " << gcd(y0, y1) << std::endl;

    return 0;
}
