#pragma once
#include <cmath>
#include <iostream>
#include "triangle.h"

Triangle::Triangle(const Dot& a, const Dot& b, const Dot& c) {
	this->a = new Dot(a);
	this->b = new Dot(b);
	this->c = new Dot(c);
}

//Triangle::Triangle(const Dot a, Dot b, Dot c) {
//	this->a = a;
//	this->b = b;
//	this->c = c;
//}

void Triangle::ShowSide() {
	std::cout << "Длинны сторон треугольника: 1 - " << a.distanceTo(b) << " 2 - " << b.distanceTo(c) << " 3 - " << c.distanceTo(a) << std::endl;
}

double Triangle::Perimetr() {
	return a.distanceTo(b) + b.distanceTo(c) + c.distanceTo(a);
}

double Triangle::Sqare() {
	double polyper = Perimetr() / 2;
	return sqrt(polyper * (polyper - a.distanceTo(b)) * (polyper - b.distanceTo(c)) * (polyper - c.distanceTo(a)));
}