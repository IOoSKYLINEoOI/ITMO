#include <string>
#include <fstream>
#include "student.h"

void Students::set_name(std::string student_name)
{
	Students::name = student_name;
}

std::string Students::get_name()
{
	return Students::name;
}

void Students::set_last_name(std::string student_last_name)
{
	Students::last_name = student_last_name;
}

std::string Students::get_last_name()
{
	return Students::last_name;
}

void Students::set_scores(int scores[])
{
	for (int i = 0; i < 5; ++i) {
		Students::scores[i] = scores[i];
	}
}

void Students::set_average_score(double ball)
{
	Students::average_score = ball;
}

double Students::get_average_score()
{
	return Students::average_score;
}

Students::Students(std::string name, std::string last_name, IdCard* id)
{
	Students::set_name(name);
	Students::set_last_name(last_name);
	Students::setIdCard(id);
}

// Запись данных о студенте в файл
void Students::save()
{
	std::ofstream fout("students.txt", std::ios::app);
	fout << Students::get_name() << " "
		<< Students::get_last_name() << " ";
	for (int i = 0; i < 5; ++i) {
		fout << Students::scores[i] << " ";
	}
	fout << std::endl;
	fout.close();
}

Students::~Students()
{
	Students::save();
}

void Students::setIdCard(IdCard* c)
{
	iCard = c;
}
IdCard Students::getIdCard()
{
	return *iCard;
}