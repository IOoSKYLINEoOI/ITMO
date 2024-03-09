#pragma once
#include "dot.h"

class Triangle {
public:
	/*Triangle(Dot, Dot, Dot);*/
	Triangle(const Dot&, const Dot&, const Dot&);
	void ShowSide();
	double Perimetr();
	double Sqare();

private:
	/*Dot a;
	Dot b;
	Dot c;*/

	Dot* a;
	Dot* b;
	Dot* c;
};