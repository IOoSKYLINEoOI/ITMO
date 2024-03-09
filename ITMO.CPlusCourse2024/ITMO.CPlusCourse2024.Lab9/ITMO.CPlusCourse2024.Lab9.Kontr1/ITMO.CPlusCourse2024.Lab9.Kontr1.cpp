#include <iostream>
#include <cmath>

class TriangleError {
public:
	TriangleError() : message("Некорректные размеры сторон") { }
	void printMessage() const { std::cout << message << std::endl; }
private:
	std::string message;
};

class Triangle
{
public:
	void set_a(double aa)
	{
		a = aa;
	}
	double get_a()
	{
		return a;
	}

	void set_b(double bb)
	{
		b = bb;
	}
	double get_b()
	{
		return b;
	}

	void set_c(double cc)
	{
		c = cc;
	}
	double get_c()
	{
		return c;
	}

	Triangle(double aa, double bb, double cc) 
	{ 
		if ((aa + bb) < cc || (aa + cc) < bb || (cc + bb) < aa || cc <= 0 || bb <= 0 || aa <= 0) throw TriangleError();

		a = aa;
		b = bb;
		c = cc;	
	}

	double Sqare() {
		double polper = (a + b + c) / 2;

		return sqrt(polper * (polper - a) * (polper - b) * (polper - c));
	}

private:
	double a;
	double b;
	double c;
};


int main()
{
	system("chcp 1251");

	double a = 0, b = 0, c = 0;

	std::cout << "Введите размеры сторон треугольника: " << std::endl;
	std::cin >> a; std::cin >> b; std::cin >> c;

	try {
		Triangle tr = Triangle(a, b, c);

		std::cout << "Площадь треугольника со сторонами a = " << tr.get_a() << " b = " << tr.get_b() << " c = " << tr.get_c() << " равна = " << tr.Sqare() << std::endl;
	}
	catch(TriangleError& error)
	{
		std::cout << "ОШИБКА: "; 
		error.printMessage();
		
		return 1;
	}

	return 0;
}
