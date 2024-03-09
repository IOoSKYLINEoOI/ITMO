#include "IdCard.h"

IdCard::IdCard(int n)
{
	number = n;
	category = "�� �����������";
}
IdCard::IdCard()
{
	number = 0;
	category = "�� �����������";
}
IdCard::IdCard(int n, std::string cat)
{
	number = n;
	category = cat;
}

void IdCard::setNumber(int newNumber)
{
	number = newNumber;
}
int IdCard::getNumber()
{
	return number;
}

void IdCard::setCategory(std::string cat)
{
	category = cat;
}
std::string IdCard::getCategory()
{
	return category;
}
