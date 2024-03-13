#pragma once
#include "distance.h"

Distance Distance::operator+ (const Distance& d2) const
{
	int f = feet + d2.feet;
	float i = inches + d2.inches;
	if (i >= 12.0)
	{
		i -= 12.0;
		f++;
	}
	return Distance(f, i);
}

Distance Distance::operator+ (const int met) const
{
	int f = feet;
	float i = inches + met;
	if (i >= 12.0)
	{
		i -= 12.0;
		f++;
	}
	return Distance(f, i);
}

Distance Distance::operator- (const Distance& d2) const
{
	int f = feet - d2.feet;
	float i = inches - d2.inches;
	if (i < 0)
	{
		i += 12.0;
		f--;
	}
	if(f < 0 || i < 0) return Distance(0, 0);

	return Distance(f, i);
}

std::ostream& operator<< (std::ostream& out, const Distance& dist)
{
	out << dist.feet << "\' - " << dist.inches << "\"\n";
	return out;
}

Distance::operator float() const
{
	float fracfeet = inches / 12;
	fracfeet += static_cast<float>(feet);
	return fracfeet / MTF;
}

Distance::Distance(float meters) : MTF(3.280833F)
{
	float fltfeet = MTF * meters;
	feet = int(fltfeet);
	inches = 12 * (fltfeet - feet);
};