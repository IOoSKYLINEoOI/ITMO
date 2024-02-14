#include <iostream>
#include <cmath>

int main()
{
    system("chcp 1251");
    std::cout.precision(2);
    std::cout.setf(std::ios::fixed);

    double per;
    double sqare;

    std::cout << "Введите значение периметра = ";
    std::cin >> per;
    sqare = (std::sqrt(3) * std::pow(per / 3, 2)) / 4;
    std::cout << "\nПлощадь треугольника = " << sqare << std::endl;
}

