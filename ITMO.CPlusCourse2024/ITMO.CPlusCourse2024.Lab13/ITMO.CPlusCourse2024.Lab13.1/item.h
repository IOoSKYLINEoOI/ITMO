#pragma once
#include <iostream>
#include <string>
#include <windows.h>

class Item
{
private:
	std::string title;
	double price;
public:
	virtual void getdata()
	{
		std::cout << "\n������� ��������� : ";
		std::cin >> title;
		std::cout << "������� ���� : ";
		std::cin >> price;
	}
	virtual void putdata()
	{
		std::cout << "\n���������: " << title;
		std::cout << "\n����:" << price;
	}
};