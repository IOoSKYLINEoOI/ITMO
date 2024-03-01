#include <iostream>
#include <string>

std::string privet(std::string name)
{
	std::string str = name + ", " + "hello!\n";
	return str;
}

void privet(std::string name, int k)
{
	std::cout << name << ", " << "hello! " << "you input " << k << std::endl;
}

int main()
{
	std::string name;
	int k;

	std::cout << "What is your name?" << std::endl;	std::cin >> name;
	std::string nameOut = privet(name);

	std::cout << "Input number:" << std::endl;	std::cin >> k;

	std::cout << nameOut << std::endl;
	privet(name, k);

	return 0;
}