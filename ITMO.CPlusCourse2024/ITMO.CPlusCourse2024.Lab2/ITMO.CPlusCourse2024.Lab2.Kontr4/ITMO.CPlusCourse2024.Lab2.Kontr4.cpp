#include <iostream>
#include <cmath>
#include <ctime>

int main()
{
    system("chcp 1251");
    srand(time(NULL));

    int n, mode, check = 0;

    do {
        std::cout << "\t�������� �����\n1 - � ��������� ����������� ���������.\n2 - ����� �������� � ������ c �������.\n3 - �� 50 �����.\n"; std::cin >> mode;
    } while (mode != 1 && mode != 2 && mode != 3);

    switch (mode)
    {
    case 1:
    {
        double x = 0, y = 0;

        std::cout << "������� ���������� ���������: "; std::cin >> n;

        for (int i = 0; i < n; i++) {
            std::cout << "������� ���������� x: "; std::cin >> x;
            std::cout << "������� ���������� y: "; std::cin >> y;

            if (fabs(x) < 1 && fabs(y) < 1) {
                check += 10;
                std::cout << "��������� � 1-� ����" << std::endl;
            }
            else if (fabs(x) < 2 && fabs(y) < 2) {
                check += 5;
                std::cout << "��������� �j 2-� ����" << std::endl;
            }
            else {
                std::cout << "������ :(" << std::endl;
            }
        }

        std::cout << "���������� �����: " << check;
        break;
    }
    case 2:
    {
        int x0 = rand() % 10 + 1;
        int y0 = rand() % 10 + 1;

        std::cout << "����� ������: x = " << x0 << " y = " << y0 << std::endl;

        double x = 0, y = 0;

        std::cout << "������� ���������� ���������: "; std::cin >> n;

        for (int i = 0; i < n; i++) {
            std::cout << "������� ���������� x: "; std::cin >> x;
            std::cout << "������� ���������� y: "; std::cin >> y;

            if ((rand() % 10 + 1) % 2 == 0) {
                x = x + rand() % 10 + 1;
                y = y + rand() % 10 + 1;

                std::cout << "��������� ������, ����� ���������� ���������: x = " << x << " y = " << y << std::endl;
            }

            if (fabs(x) < x0 + 1 && fabs(y) < y0 + 1) {
                check += 10;
                std::cout << "��������� � 1-� ����" << std::endl;
            }
            else if (fabs(x) < x0 + 2 && fabs(y) < y0 + 2) {
                check += 5;
                std::cout << "��������� �j 2-� ����" << std::endl;
            }
            else {
                std::cout << "������ :(" << std::endl;
            }
        }

        std::cout << "���������� �����: " << check;
        break;
    }
    case 3: {

        int count = 0;
        double x = 0, y = 0;

        while (check < 50) {
            std::cout << "������� ���������� x: "; std::cin >> x;
            std::cout << "������� ���������� y: "; std::cin >> y;

            count += 1;

            if (fabs(x) < 1 && fabs(y) < 1) {
                check += 10;
                std::cout << "��������� � 1-� ����" << std::endl;
            }
            else if (fabs(x) < 2 && fabs(y) < 2) {
                check += 5;
                std::cout << "��������� �j 2-� ����" << std::endl;
            }
            else {
                std::cout << "������ :(" << std::endl;
            }
        }

        if (count <= 4) {
            std::cout << "������������" << std::endl;
        }
        else if (count <= 6) {
            std::cout << "���������" << std::endl;
        }
        else if (count <= 8) {
            std::cout << "��������" << std::endl;
        }
        else {
            std::cout << "������" << std::endl;
        }
    }
    }

    return 0;
}

