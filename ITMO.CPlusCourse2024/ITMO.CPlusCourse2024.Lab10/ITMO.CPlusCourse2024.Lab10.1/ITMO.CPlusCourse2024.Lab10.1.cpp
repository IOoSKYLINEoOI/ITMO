#include <iostream>
#include <string>
#include "student.h"

int main()
{
	system("chcp 1251");

	std::string name;
	std::string last_name;
	IdCard idc(123, "Базовый");

	std::cout << "Name: ";
	getline(std::cin, name);

	std::cout << "Last name: ";
	getline(std::cin, last_name);

	Students* student02 = new Students(name, last_name, &idc);
	int scores[5];
	int sum = 0;

	for (int i = 0; i < 5; ++i) {
		std::cout << "Score " << i + 1 << ": ";
		std::cin >> scores[i];
		sum += scores[i];
	}

	student02->set_scores(scores);
	double average_score = sum / 5.0;
	student02->set_average_score(average_score);

	std::cout << "Average ball for " << student02->get_name() << " "
		<< student02->get_last_name() << " is "
		<< student02->get_average_score() << std::endl;
	std::cout << "IdCard: " << student02->getIdCard().getNumber() << std::endl;
	std::cout << "Category: " << student02->getIdCard().getCategory() << std::endl;

	delete student02;

	return 0;
}