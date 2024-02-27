#include <iostream>
#include <math.h>

int main()
{
    system("chcp 1251");

    //1
    double x, x1, y, x2;

    std::cout << "x1 = "; std::cin >> x1;
    std::cout << "x2 = "; std::cin >> x2;

    std::cout << "\tx\tsin(x)\n";

    x = x1;

    do {
        y = sin(x);
        std::cout << "\t" << x << "\t" << y <<"\n";
        x = x + 0.01;
    } while (x <= x2);

    //2
    int a, b, temp;

    std::cout << "a = "; std::cin >> a;
    std::cout << "b = "; std::cin >> b;

    while (a != b)
    {
        if (a > b)
            a -= b;
        else
            b -= a;
    }

    std::cout << "НОД = " << a << std::endl;

    //3.1
    double xx, xx1, yy, xx2;

    std::cout << "xx1 = "; std::cin >> xx1;
    std::cout << "xx2 = "; std::cin >> xx2;

    std::cout << "\tx\tsin(x)\n";

    xx = xx1;

    if (xx1 >= xx2) {
        while (xx <= xx2) {
            yy = sin(x);
            std::cout << "\t" << xx << "\t" << yy << "\n";
            xx = xx + 0.01;
        }
    }
    else {
        std::cout << "Неправильный интервал" << "\n";
    }

    //3.2
    int aa, bb, temptemp;

    std::cout << "aa = "; std::cin >> aa;
    std::cout << "bb = "; std::cin >> bb;


    do {
        if (aa > bb)
            aa -= bb;
        else if (aa < bb)
            bb -= aa;
        else
            continue;
    } while (aa != bb);

    std::cout << "НОД = " << aa << std::endl;

    return 0;
}

