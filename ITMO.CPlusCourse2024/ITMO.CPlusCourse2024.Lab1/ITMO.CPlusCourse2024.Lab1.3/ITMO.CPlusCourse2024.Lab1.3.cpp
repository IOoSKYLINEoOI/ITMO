#include <iostream>
#include <cmath>

int main()
{
    system("chcp 1251");
    std::cout.precision(2);
    std::cout.setf(std::ios::fixed);

    double per;
    double sqare;

    std::cout << "������� �������� ��������� = ";
    std::cin >> per;
    sqare = (std::sqrt(3) * std::pow(per / 3, 2)) / 4;
    std::cout << "\n������� ������������ = " << sqare << std::endl;
}

