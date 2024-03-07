#pragma once

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

private:
	int hours;
	int minutes;
	int seconds;
};