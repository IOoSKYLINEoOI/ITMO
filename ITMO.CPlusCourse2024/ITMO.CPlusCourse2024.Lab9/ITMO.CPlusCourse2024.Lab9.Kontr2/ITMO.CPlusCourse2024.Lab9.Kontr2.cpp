#include <iostream>
#include "time.h"


int main()
{
    system("chcp 1251");

    Time* time1 = new Time();
    int hour, minute, second;
    time1->ShowTime();

    try {
        std::cout << "\n������� ���������� �����: ";
        std::cin >> hour; if (std::cin.good() == false) throw Time::ExTime("������� ������������ ������", NULL);
        std::cout << "������� ���������� �����: ";
        std::cin >> minute; if (std::cin.good() == false) throw Time::ExTime("������� ������������ ������", NULL);
        std::cout << "������� ���������� ������: ";
        std::cin >> second; if (std::cin.good() == false) throw Time::ExTime("������� ������������ ������", NULL);
        Time* time2 = new Time(hour, minute, second);
        time2->ShowTime();

        std::cout << "\n������� ���������� �����: ";
        std::cin >> hour; if(std::cin.good() == false) throw Time::ExTime("������� ������������ ������", NULL);
        std::cout << "������� ���������� �����: ";
        std::cin >> minute; if (std::cin.good() == false) throw Time::ExTime("������� ������������ ������", NULL);
        std::cout << "������� ���������� ������: ";
        std::cin >> second; if (std::cin.good() == false) throw Time::ExTime("������� ������������ ������", NULL);
        Time* time3 = new Time(hour, minute, second);
        time3->ShowTime();

        time1->AddTime(*time2, *time3);
        time1->ShowTime();

        delete time1;
        delete time2;
        delete time3;
    }
    catch (Time::ExTime& ex) {
        std::cout << "\n������ �������������: " << ex.origin;
        if (ex.iValue != NULL) {
            std::cout << "\n��������� �������� ������� " << ex.iValue << " �������� ������������\n";
        }
        return -1;
    }
    return 0;
}