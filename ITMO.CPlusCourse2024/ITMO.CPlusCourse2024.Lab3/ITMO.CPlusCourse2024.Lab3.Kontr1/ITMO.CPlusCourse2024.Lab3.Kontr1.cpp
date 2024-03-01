#include <iostream>
#include <cmath>
#include <string>

bool CheckNumber(std::string number);
void PrintFullNumber(std::string number);

int main()
{
    system("chcp 1251");

    std::string checknumber;

    std::cout << "������� 9-�� ������� ����� �����:" << std::endl;  std::getline(std::cin, checknumber);
    PrintFullNumber(checknumber);

    return 0;
}

bool CheckNumber(std::string number) {

    std::string check = "0123456789- ";
    std::string check_allowed = "0123456789";
    int temp = 0, number1 = -1, number2 = -1, number3 = -1;

    for (int i = 0; i < number.length(); i++) {
        if (check.find(number[i]) == -1 || temp > 9) return false;

        if (check_allowed.find(number[i]) != -1)
        {
            number1 = number2;
            number2 = number3;
            number3 = (int)number[i];

            if (number1 == number2 && number2 == number3 && number1 == number3) return false;

            temp += 1;
        }
    }

    if (temp == 9) {
        return true;
    }else return false;
}

void PrintFullNumber(std::string number) {

    int summary = 0, temp = 1;
    std::string check_allowed = "0123456789";

    while (!CheckNumber(number)) {
        std::cout << "������ ����������� ����� �����" << std::endl;
        std::cout << "������� 9-�� ������� ����� ����� ��������:" << std::endl;    std::getline(std::cin, number);
    };

    for (int i = 0; i < number.length(); i++) {
        if (check_allowed.find(number[i]) != -1) {
            summary += temp * (number[i] % 10);
            temp += 1;
        }
    }

    if (summary < 100) {
        std::cout << "����� �����: " << number << " " << summary << std::endl;
    }
    else if (summary == 100 || summary == 101) {
        std::cout << "����� �����: " << number << " " << 00 << std::endl;
    }
    else {
        if (summary % 101 == 100) {
            std::cout << "����� �����: " << number << " " << 00 << std::endl;
        }
        else {
            std::cout << "����� �����: " << number << " " << summary % 101 << std::endl;
        }
    }
}