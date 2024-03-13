#include <iostream>
#include "time.h"


int main()
{
    system("chcp 1251");

    Time* time1 = new Time();
    int hour, minute, second;
    time1->ShowTime();

    try {
        std::cout << "\n¬ведите количество часов: ";
        std::cin >> hour; if (std::cin.good() == false) throw Time::ExTime("¬ведены неккоректные данные", NULL);
        std::cout << "¬ведите количество минут: ";
        std::cin >> minute; if (std::cin.good() == false) throw Time::ExTime("¬ведены неккоректные данные", NULL);
        std::cout << "¬ведите количество секунд: ";
        std::cin >> second; if (std::cin.good() == false) throw Time::ExTime("¬ведены неккоректные данные", NULL);
        Time* time2 = new Time(hour, minute, second);
        time2->ShowTime();

        std::cout << "\n¬ведите количество часов: ";
        std::cin >> hour; if (std::cin.good() == false) throw Time::ExTime("¬ведены неккоректные данные", NULL);
        std::cout << "¬ведите количество минут: ";
        std::cin >> minute; if (std::cin.good() == false) throw Time::ExTime("¬ведены неккоректные данные", NULL);
        std::cout << "¬ведите количество секунд: ";
        std::cin >> second; if (std::cin.good() == false) throw Time::ExTime("¬ведены неккоректные данные", NULL);
        Time* time3 = new Time(hour, minute, second);
        time3->ShowTime();

        time1->AddTime(*time2, *time3);
        time1->ShowTime();

        double n = 78;
        Time* time4 = new Time();
        Time* time5 = new Time();
        time4=time3 + 10;
        time5 = 10+ time3;
        time4->ShowTime();
        time5->ShowTime();

        delete time1;
        delete time2;
        delete time3;
        delete time4;
        delete time5;
    }
    catch (Time::ExTime& ex) {
        std::cout << "\nќшибка инициализации: " << ex.origin;
        if (ex.iValue != NULL) {
            std::cout << "\n¬веденное значение времени " << ex.iValue << " €вл€етс€ недопустимым\n";
        }
        return -1;
    }
    return 0;
}