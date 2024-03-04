#include <iostream>
#include <fstream>


int main()
{
    system("chcp 1251");

    const int N = 10;
    int a[N] = { 1, 25, 6, 32, 43, 5, 96, 23, 4, 55 };

    int min = 0;
    int buf = 0;

    std::ofstream out("test.txt", std::ios::out);
    if (!out) {
        std::cout << "���� ������� ����������\n";
        return 1;
    }
    out << "�������� ������ :";
    for (int i = 0; i < N; i++) 
        out << a[i] << " ";
    out << std::endl;


    for (int i = 0; i < N; i++)
    {
        min = i;

        for (int j = i + 1; j < N; j++)
            min = (a[j] < a[min]) ? j : min;

        if (i != min)
        {
            buf = a[i];
            a[i] = a[min];
            a[min] = buf;
        }
    }

    out << "��������������� ������ :";
    for (int i = 0; i < N; i++)
        out << a[i] << " ";
    out << std::endl;

    out.close();

    for (int i : a)
        std::cout << i << '\t';

    return 0;
}
