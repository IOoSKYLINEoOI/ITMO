#include <iostream>
#include <math.h>

int main()
{
    system("chcp 1251");

    int n, countn = 2, i = 2;
    bool flag = true;


    std::cout << "������� ����� ��� ��������: "; std::cin >> n;

    //�������� n �� ��������
    while (i < sqrt(n) + 1) {
        if (n % i == 0) {
            flag = false;
        }
        i++;
    }

    
    if (flag) {

        //������� ���������� ������� ����� �� n
        for (int i = 2; i < n; i++)
        {
            bool easy = true;

            for (int j = 2; j < sqrt(i) + 1; j++)
                if (i % j == 0)
                {
                    easy = false;
                    break;
                }
            if (easy) countn++;
        }
    
        //��������� ���������� ����� �� ��������
        i = 2;
        while (flag && i < sqrt(countn) + 1) {
            if (countn % i == 0) {
                flag = false;
            }
            i++;
        }
    }

    if (flag) {
        std::cout << "����� ������������" << std::endl;
    }
    else {
        std::cout << "����� �� �������� ������������" << std::endl;
    }

    return 0;
}

