#pragma once
#include "item.h"

class Paperbook : public Item
{
private:
	int pages;
public:
	void getdata()
	{
		Item::getdata();
		std::cout << "������� ����� ������� : ";
		std::cin >> pages;
	}
	void putdata()
	{
		Item::putdata();
		std::cout << "\n�������:" << pages;
	}
};