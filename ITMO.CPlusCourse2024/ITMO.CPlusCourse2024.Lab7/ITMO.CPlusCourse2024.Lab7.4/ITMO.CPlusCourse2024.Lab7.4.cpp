#include <iostream>
#include <windows.h>
#include <string>
#include <tuple>
#include <vector>

using Tuple = std::tuple<std::string, int, double>;
using Tuple2 = std::tuple<int, double>;

void printTupleOfThree(Tuple);
void printTupleOfThree(Tuple2);
Tuple funtup(std::string, int, double);
Tuple tuplePlusFive(const Tuple);
Tuple2 tupleTwo(const Tuple);

int main()
{
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	std::vector<std::string> v1{ "one", "two", "three", "four", "five", "six" };
	std::vector<int> v2 = { 1, 2, 3, 4, 5, 6 };
	std::vector<double> v3 = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };

	auto t0 = make_tuple(v1[0], v2[0], v3[0]);
	printTupleOfThree(t0);

	auto t1 = funtup(v1[1], v2[1], v3[1]);
	printTupleOfThree(t1);

	auto t2 = tuplePlusFive(t1);
	printTupleOfThree(t2);

	auto t3 = tupleTwo(t2);
	printTupleOfThree(t3);

	return 0;
}

void printTupleOfThree(Tuple t)
{
	std::cout << "("
		<< std::get<0>(t) << ", "
		<< std::get<1>(t) << ", "
		<< std::get<2>(t) << ")" << std::endl;
}

void printTupleOfThree(Tuple2 t)
{
	std::cout << "("
		<< std::get<0>(t) << ", "
		<< std::get<1>(t) << ")" << std::endl;
}

Tuple funtup(std::string s, int a, double d)
{
	s.append("!");
	return make_tuple(s, a, d * 10);
}

Tuple tuplePlusFive(const Tuple t)
{
	return std::make_tuple(std::get<0>(t) + '5', std::get<1>(t) + 5, std::get<2>(t) + 5);
}

Tuple2 tupleTwo(const Tuple t)
{
	return std::make_tuple(std::get<1>(t) + 5, std::get<2>(t) + 5);
}

