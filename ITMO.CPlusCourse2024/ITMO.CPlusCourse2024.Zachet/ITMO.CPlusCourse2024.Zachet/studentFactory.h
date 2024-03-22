#pragma once
#include "personFactory.h"
#include "student.h"

class StudentFactory : public PersonFactory {
public:
    Person* createPerson() override {
        std::string first_name;
        std::string last_name;
        std::string father_name;
        std::string phone_number;
        std::string number_group;
        std::string course;

        std::cout << "������� ���: "; std::cin >> first_name;
        std::cout << "������� �������: "; std::cin >> last_name;
        std::cout << "������� ��������: "; std::cin >> father_name;
        std::cout << "������� ����� ��������: "; std::cin >> phone_number;
        std::cout << "������� �������� �����: "; std::cin >> course;
        std::cout << "������� ����� ������: "; std::cin >> number_group;

        return new Student(first_name, last_name, father_name, phone_number, number_group, course);
    }
};