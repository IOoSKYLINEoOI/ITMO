#include "time.h"
#include <iostream>

void Time::set_hours(int hour)
{
	Time::hours = hour;
}
int Time::get_hours()
{
	return Time::hours;
}

void Time::set_minutes(int minute)
{
	Time::minutes = minute;
}
int Time::get_minutes()
{
	return Time::minutes;
}

void Time::set_seconds(int second)
{
	Time::seconds = second;
}
int Time::get_seconds()
{
	return Time::seconds;
}

Time::Time() {
	Time::set_hours(0);
	Time::set_minutes(0);
	Time::set_seconds(0);
}
Time::Time(int hours, int minutes, int seconds) {
	
	if (seconds >= 60) {
		minutes += seconds / 60;
		seconds = seconds % 60;
	}
	if (minutes >= 60) {
		hours += minutes / 60;
		minutes = minutes % 60;
	}

	Time::set_hours(hours);
	Time::set_minutes(minutes);
	Time::set_seconds(seconds);
}


void Time::AddTime(Time& t1, Time& t2)
{
	int hours = 0, seconds = 0, minutes = 0;

	seconds = t1.get_seconds() + t2.get_seconds();
	if (seconds >= 60) {
		minutes += seconds / 60;
		seconds = seconds % 60;
	}

	minutes += (t1.get_minutes() + t2.get_minutes());
	if (minutes >= 60) {
		hours += minutes / 60;
		minutes = minutes % 60;
	}

	hours += (t1.get_hours() + t2.get_hours());	

	Time::set_hours(hours);
	Time::set_minutes(minutes);
	Time::set_seconds(seconds);
}

void Time::ShowTime()
{
	std::cout << get_hours() << ":" << get_minutes() << ":" << get_seconds() << std::endl;
}