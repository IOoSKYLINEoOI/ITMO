#pragma once
#include "personFactory.h"
#include "collegues.h"

class ColleagueFactory : public PersonFactory {
public:
    Person* createPerson() override {
        std::string first_name;
        std::string last_name;
        std::string father_name;
        std::string phone_number;
        std::string company;

        std::cout << "�������� �������" << std::endl;
        std::cout << "������� ���: "; std::cin >> first_name;
        std::cout << "������� �������: "; std::cin >> last_name;
        std::cout << "������� ��������: "; std::cin >> father_name;
        std::cout << "������� ����� ��������: "; std::cin >> phone_number;
        std::cout << "������� �������� ��������: "; std::cin >> company;

        return new Colleague(first_name, last_name, father_name, phone_number, company);
    }
};