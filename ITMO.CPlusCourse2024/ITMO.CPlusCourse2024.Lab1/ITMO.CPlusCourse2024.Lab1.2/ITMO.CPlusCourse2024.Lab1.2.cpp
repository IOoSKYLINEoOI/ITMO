#include <iostream>
#include <string>

int main()
{
	system("chcp 1251");
	std::cout.precision(3);

	std::string name;
	double a, b;

	std::cout << "Введите a и b:\n";

	std::cin >> a; // ввод с клавиатуры значения a
	std::cin >> name;
	std::cin >> b; // ввод с клавиатуры значения b

	double x = a / b; // вычисление значения x

	std::cout << "\nx = " << x << std::endl; //вывод результата на экран
	std::cout << "Привет, " << name << "!\n";
	std::cout << "\nsizeof(a/b) = " << sizeof(a / b) << std::ends <<"\nsizeof(x) = " << sizeof(x) << std::endl;
	return 0;
}
