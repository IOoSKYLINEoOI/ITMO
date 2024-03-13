#include <iostream>
#include "distance.h"

int main()
{
    system("chcp 1251");

    /*Distance dist1, dist2, dist3, dist4, dist5, dist6;
    
    dist1.getdist();
    dist2.getdist();

    dist3 = dist1 + dist2;
    dist4 = dist1 + dist2 + dist3;

    dist5 = dist1 - dist2;
    dist6 = dist1 - dist2 - dist3;

    std::cout << "\ndist1 = " << dist1;
    std::cout << "\ndist2 = " << dist2;
    std::cout << "\ndist3 = " << dist3;
    std::cout << "\ndist4 = " << dist4;
    std::cout << "\ndist5 = " << dist5;
    std::cout << "\ndist6 = " << dist6;*/

    Distance dist1 = 2.35F, dist2, dist3;
    float mtrs;
    mtrs = static_cast<float>(dist1);
    mtrs = dist1;

    dist2.getdist();
    std::cout << "\ndist1 = " << dist1;

    return 0;
}
