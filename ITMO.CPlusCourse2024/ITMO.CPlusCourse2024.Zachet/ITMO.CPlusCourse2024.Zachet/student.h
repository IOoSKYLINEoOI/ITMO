#pragma once
#include <iostream>
#include "person.h"

class Student : public Person {
public:
	Student(
		const std::string& first_name,
		const std::string& last_name,
		const std::string& father_name,
		const std::string& phone_number,
		const std::string& number_group,
		const std::string& course)
		: Person(first_name, last_name, father_name, phone_number),
		number_group(number_group), course(course) {}

	void printDetails() const override {
		std::cout << "�������: " << getFullName() 
			<< "\n����� ��������: " << getPhone() 
			<< "\n����� ������: " << number_group 
			<< "\n�������� �����: " << course << std::endl;
	}

	std::string getStatus() const override {
		return "Student";
	}

private:
	std::string number_group;
	std::string course;
};

//class Student: public Person {
//public:
//	Student();
//
//	void printDetails();
//
//private:
//	std::string name_course;
//	std::string number_group;
//	std::string status = "student";
//};
//
//Student::Student() {
//	Person::Person();
//	std::cout << "������� �������� �����: "; std::cin >> name_course;
//	std::cout << "������� ����� ������: "; std::cin >> number_group;
//}