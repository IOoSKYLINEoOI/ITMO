#include <iostream>
#include "time.h"


int main()
{
    system("chcp 1251");

    Time* time1 = new Time();
    int hour, minute, second;
    time1->ShowTime();

    std::cout << "\n������� ���������� �����: ";
    std::cin >> hour;
    std::cout << "������� ���������� �����: ";
    std::cin >> minute;
    std::cout << "������� ���������� ������: ";
    std::cin >> second;
    Time* time2 = new Time(hour, minute, second);
    time2->ShowTime();

    std::cout << "\n������� ���������� �����: ";
    std::cin >> hour;
    std::cout << "������� ���������� �����: ";
    std::cin >> minute;
    std::cout << "������� ���������� ������: ";
    std::cin >> second;
    Time* time3 = new Time(hour, minute, second);
    time3->ShowTime();

    time1->AddTime(*time2, *time3);
    time1->ShowTime();

    delete time1;
    delete time2;
    delete time3;
    return 0;
}

