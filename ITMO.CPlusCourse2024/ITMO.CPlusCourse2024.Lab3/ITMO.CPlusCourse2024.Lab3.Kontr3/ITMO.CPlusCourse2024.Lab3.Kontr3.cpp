#include <iostream>
#include <cmath>

double Triangle(double a);
double Triangle(double a, double b, double c);


int main()
{
    system("chcp 1251");

    int variable = 0 , a = 0, b = 0, c = 0;

    std::cout << "\t����� ������ �������:\n1 - �������������� ������������.\n2 - �������������� �����������.\n3 - ����� �� ���������." << std::endl; std::cin >> variable;



    while (variable != 1 && variable != 2 && variable != 3) {
        std::cout << "������������ ����, ���������" << std::endl; std::cin >> variable;
    };

    switch (variable)
    {
    case 1:
        std::cout << "������� ������ �������: " << std::endl;
        std::cin >> a;
        std::cout << "�������: " << Triangle(a) << std::endl;
        break;
    case 2:
        std::cout << "������� ������ ������ �������: " << std::endl;
        std::cin >> a;
        std::cout << "������� ������ ������ �������: " << std::endl;
        std::cin >> b;
        std::cout << "������� ������ ������ �������: " << std::endl;
        std::cin >> c;
        std::cout << "�������: " << Triangle(a, b, c) << std::endl;
        break;
    default:
        std::cout << "���������� ���������" << std::endl;
    }

    return 0;
}

double Triangle(double a) {
    return sqrt(3) * pow(a, 2) / 4;
}

double Triangle(double a, double b, double c) {

    if (a + b < c || b + c < a || c + a < b) return -1;

    double polPer = (a + b + c) / 2;

    return sqrt(polPer * (polPer - a) * (polPer - b) * (polPer - c));
}