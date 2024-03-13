#pragma once
#include "point.h"

Point::Point() {
	x = 0;
	y = 0;
};

Point::Point(double xx, double yy) {
	x = xx;
	y = yy;
};

void Point::set_x(double xx) {
	x = xx;
}
double Point::get_x() const { return x; };

void Point::set_y(double yy) {
	y = yy;
};
double Point::get_y() const { return y; };

