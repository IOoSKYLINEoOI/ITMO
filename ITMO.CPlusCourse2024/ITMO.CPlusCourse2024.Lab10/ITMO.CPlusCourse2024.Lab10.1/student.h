#pragma once 
#include <string>
#include "IdCard.h"

class Students
{
public:
	void set_name(std::string);
	std::string get_name();
	void set_last_name(std::string);
	std::string get_last_name();
	void set_scores(int[]);
	void set_average_score(double);
	double get_average_score();

	Students(std::string name, std::string last_name, IdCard* id);
	void save();
	~Students();

	IdCard* iCard;
	void setIdCard(IdCard* c);
	IdCard getIdCard();

private:
	int scores[5];
	double average_score;
	std::string name;
	std::string last_name;
};

