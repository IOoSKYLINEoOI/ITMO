#include "time.h"
#include <iostream>
#include <string>

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

	if(hours < 0 || minutes < 0 || seconds < 0) throw ExTime("в кострукторе Time(int, int, int)", hours < 0 ? hours : (minutes < 0 ? minutes : seconds));

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

Time::ExTime::ExTime(std::string orr, int sc)
{
	origin = orr;
	iValue = sc;
}

Time Time::operator- (const Time& t) const {
	int hourss = 0, secondss = 0, minutess = 0;

	secondss = seconds - t.seconds;
	if (secondss < 0) {
		minutess -= secondss / 60;
		secondss = secondss % 60;
	}

	minutess += (minutes - t.minutes);
	if (minutess < 0) {
		hourss -= minutess / 60;
		minutess = minutess % 60;
	}

	hourss += (hours - t.hours);

	if(hourss < 0) return Time(0, 0, 0);

	return Time(minutess, secondss, hourss);
}

Time operator+(const Time& t1, const Time& t2)
{
	int hourss = 0, secondss = 0, minutess = 0;

	secondss = t1.seconds + t2.seconds;
	if (secondss >= 60) {
		minutess += secondss / 60;
		secondss = secondss % 60;
	}

	minutess += (t1.minutes + t2.minutes);
	if (minutess >= 60) {
		hourss += minutess / 60;
		minutess = minutess % 60;
	}

	hourss += (t1.hours + t2.hours);

	return Time(minutess, secondss, hourss);
}

Time operator+(Time& t, double m)
{
	int hourss = 0, secondss = 0, minutess = 0;

	secondss = t.get_seconds() + (int)m;
	if (secondss >= 60) {
		minutess = minutess + secondss / 60;
		secondss = secondss % 60;
	}

	minutess = minutess + t.get_minutes();
	if (minutess >= 60) {
		hourss = hourss + minutess / 60;
		minutess = minutess % 60;
	}

	hourss = hourss + t.get_hours();

	return Time(minutess, secondss, hourss);
}

Time operator+(double m, Time& t)
{
	int hourss = 0, secondss = 0, minutess = 0;

	secondss = t.get_seconds() + (int)m;
	if (secondss >= 60) {
		minutess = minutess + secondss / 60;
		secondss = secondss % 60;
	}

	minutess = minutess + t.get_minutes();
	if (minutess >= 60) {
		hourss = hourss + minutess / 60;
		minutess = minutess % 60;
	}

	hourss = hourss + t.get_hours();

	return Time(minutess, secondss, hourss);
}
