#include <iostream>

int main()
{
    system("chcp 1251");

    //Zadnie1
    double x, y;
    std::cout << "������� ���������� ����� = ";
    std::cin >> x >> y;

    if (x * x + y * y < 9 && y > 0)
    {
        std::cout << "\n������";
    }    
    else if (x * x + y * y > 9 || y < 0)
    {
        std::cout << "\nC������";
    }
    else
    {
        std::cout << "\n�� �������";
    }

    //Zadanie2
    char op;

    std::cout << "\n������ ���� �����, ������ ���� ���� �����: ";
    std::cin >> op;

    switch (op)
    {
    case 'V':
        std::cout << "����������� ����\n";
    case 'S':
        std::cout << "����� ������ ������\n";
    default:
        std::cout << "������ �������\n";
        std::cout << "������ ���������\n";
    }

    return 0;
}

