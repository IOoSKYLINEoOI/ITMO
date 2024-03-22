#pragma once
#include "personFactory.h"
#include "teacher.h"

class TeacherFactory : public PersonFactory {
public:
    Person* createPerson() override {
        std::string first_name;
        std::string last_name;
        std::string father_name;
        std::string phone_number;
        std::string subject;

        std::cout << "�������� �������" << std::endl;
        std::cout << "������� ���: "; std::cin >> first_name;
        std::cout << "������� �������: "; std::cin >> last_name;
        std::cout << "������� ��������: "; std::cin >> father_name;
        std::cout << "������� ����� ��������: "; std::cin >> phone_number;
        std::cout << "������� �������� ��������: "; std::cin >> subject;

        return new Teacher(first_name, last_name, father_name, phone_number, subject);
    }
};