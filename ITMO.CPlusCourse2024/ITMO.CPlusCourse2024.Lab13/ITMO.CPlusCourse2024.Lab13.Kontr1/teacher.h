#pragma once
#include "human.h"
#include <string>

class Teacher : public Human {

public:
	void getdata() {
		Human::getdata();

		std::cout << "������� ���������� ������� �����: ";
		std::cin >> work_time;
	}

	unsigned int get_work_time()
	{
		return this->work_time;
	}

	void putdata() {
		Human::putdata();
		std::cout << "���������� �����: " << get_work_time() << std::endl;
	}
private:
	unsigned int work_time;
};
