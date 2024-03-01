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

    std::cout << "������� �����, ��� �������� ����� �� 0 �� n: "; std::cin >> n;
    std::cout << "�����: " << addNumders(n) << std::endl;

    std::cout << "������� �����, ������ ���������: "; std::cin >> x0;
    std::cout << "������� �����, ����� ���������: "; std::cin >> x1;
    std::cout << "�����: " << addNumders(x0, x1) << std::endl;

    std::cout << "���������� ���" << std::endl;
    std::cout << "������� ����� 1: "; std::cin >> y0;
    std::cout << "������� ����� 2: "; std::cin >> y1;
    std::cout << "�����: " << gcd(y0, y1) << std::endl;

    return 0;
}
