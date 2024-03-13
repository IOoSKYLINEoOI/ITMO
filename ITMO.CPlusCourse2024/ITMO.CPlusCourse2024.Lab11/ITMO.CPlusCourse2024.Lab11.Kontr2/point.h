#pragma once
#include <cmath>
#include <iostream>

class Point {
public:
	Point();
	Point(double, double);

	void set_x(double);
	double get_x() const;
	void set_y(double);
	double get_y() const;

	bool operator< (const Point& p) {
		return sqrt(x * x + y * y) < sqrt(p.x * p.x + p.y * p.y);
	}

private:
	double x;
	double y;
};


