#include <iostream>

long double firBinSearch(double a, int n)
{
    double L = 0;
    double R = a;
    while (R - L > 1e-10)
    {
        double M = (L + R) / 2;
        if (pow(M, n) < a)
        {
            L = M;
        }
        else
        {
            R = M;
        }
    }
    return R;
}

int main()
{
    system("chcp 1251");

    double a;
    int n;

    do {
        std::cout << "¬ведие действительное число: "; std::cin >> a;
    } while (a <= 1 || a > 1000);

    do {
        std::cout << "¬ведие степень корн€: "; std::cin >> n;
    } while (n < 0 || n > 10);

    std::cout << firBinSearch(a, n) << std::endl;

    return 0;
}