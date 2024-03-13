#pragma once
#include <iostream>

class Distance
{
private:
	int feet;
	float inches;
	const float MTF;
public:
	Distance() : feet(0), inches(0.0), MTF(3.280833F) { }
	Distance(int ft, float in) : feet(ft), inches(in), MTF(3.280833F) { }
	Distance(float meters);
	void getdist()
	{
		std::cout << "\n¬ведите число футов : ";
		std::cin >> feet;
		std::cout << "\n¬ведите число дюймов : ";
		std::cin >> inches;
	}

	Distance operator+ (const Distance&) const;
	Distance operator+ (const int) const;
	Distance operator+ (const Distance&) const;
	Distance operator- (const Distance&) const;
	friend std::ostream& operator<< (std::ostream& out, const Distance& dist);
	operator float() const;
};