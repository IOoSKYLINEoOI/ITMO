#include <iostream>
#include <string>

int main()
{
	system("chcp 1251");
	std::cout.precision(3);

	std::string name;
	double a, b;

	std::cout << "������� a � b:\n";

	std::cin >> a; // ���� � ���������� �������� a
	std::cin >> name;
	std::cin >> b; // ���� � ���������� �������� b

	double x = a / b; // ���������� �������� x

	std::cout << "\nx = " << x << std::endl; //����� ���������� �� �����
	std::cout << "������, " << name << "!\n";
	std::cout << "\nsizeof(a/b) = " << sizeof(a / b) << std::ends <<"\nsizeof(x) = " << sizeof(x) << std::endl;
	return 0;
}
