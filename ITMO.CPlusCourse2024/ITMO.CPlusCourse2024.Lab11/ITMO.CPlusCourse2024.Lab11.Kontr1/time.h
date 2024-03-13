#pragma once
#include <string>

class Time
{
public:
	void set_hours(int);
	int get_hours();
	void set_minutes(int);
	int get_minutes();
	void set_seconds(int);
	int get_seconds();

	Time();
	Time(int, int, int);

	void AddTime(Time&, Time&);
	void ShowTime();

	class ExTime 
	{
	public:
		std::string origin; 
		int iValue; 

		ExTime(std::string orr , int sc);
	};

	friend Time operator+ (const Time& t1, const Time& t2);

	Time operator- (const Time&) const;

	friend Time operator+ (Time& t, double);
	friend Time operator+ (double, Time&);

	bool operator> (const Time& t) {
		return hours > t.hours;
	}
	bool operator< (const Time& t) {
		return hours < t.hours;
	}
	bool operator>= (const Time& t) {
		return hours >= t.hours;
	}
	bool operator<= (const Time& t) {
		return hours <= t.hours;
	}

	
private:
	int hours;
	int minutes;
	int seconds;
};

