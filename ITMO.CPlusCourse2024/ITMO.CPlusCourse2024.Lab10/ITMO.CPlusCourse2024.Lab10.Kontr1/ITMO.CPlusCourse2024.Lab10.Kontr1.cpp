#include <iostream>
#include "triangle.h"

int main()
{
    system("chcp 1251");

    Dot d1(-1, -3);
    Dot d2(3, 4);
    Dot d3(5, -5);

    Triangle t(d1, d2, d3);

    t.ShowSide();

    std::cout << "Периметр треугольника: " << t.Perimetr() << std::endl;
    std::cout << "Площадь треугольника: " << t.Sqare() << std::endl;

    return 0;
}
