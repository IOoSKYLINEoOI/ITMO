#include <iostream>

int main()
{
    system("chcp 1251");

    const int n = 10;
    int mas[n];
    int s = 0;
    double sumneg = 0, sumpoz = 0, sumnech = 0, sumchet = 0;

    for (int i = 0; i < n; i++)
    {
        std::cout << "mas[" << i << "]=";
        std::cin >> mas[i];

        s += mas[i];

        if (mas[i] < 0) {
            sumneg += mas[i];
        }
        else {
            sumpoz += mas[i];
        }

        if (i % 2 == 0) {
            sumchet += mas[i];
        }
        else {
            sumnech += mas[i];
        }
        
    }

    double sred = s / (double)n;

    std::cout << "����� ��������� �������: " << s << std::endl;
    std::cout << "�������������������� ��������� �������: " << sred << std::endl;
    std::cout << "����� ������������� ��������� �������: " << sumneg << std::endl;
    std::cout << "����� ������������� ��������� �������: " << sumpoz << std::endl;
    std::cout << "����� ������ ��������� �������: " << sumchet << std::endl;
    std::cout << "����� �������� ��������� �������: " << sumnech << std::endl;

    return 0;
}
