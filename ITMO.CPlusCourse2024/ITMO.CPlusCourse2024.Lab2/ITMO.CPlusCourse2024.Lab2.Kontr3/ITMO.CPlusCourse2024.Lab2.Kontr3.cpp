#include <iostream>

int main()
{
    system("chcp 1251");

    double money;

    std::cout << "������� ����� ������� ����� ���������: "; std::cin >> money;

    std::cout << "������ 10 �������� �����: " << (int)money / 10 << std::endl;
    std::cout << "������ 5 �������� �����: " << (int)money % 10 / 5 << std::endl;
    std::cout << "������ 2 �������� �����: " << (int)money % 10 % 5 / 2 << std::endl;
    std::cout << "������ 1 �������� �����: " << (int)money % 10 % 5 % 2 << std::endl;
    std::cout << "������ 50-�� ��������� �����: " << (int)(money * 100) % 100 / 50 << std::endl;
    std::cout << "������ 10-�� ��������� �����: " << (int)(money * 100) % 50 / 10 << std::endl;
    std::cout << "������ 1 ��������� �����: " << (int)(money * 100) % 50 % 10 << std::endl;
    return 0;
}
