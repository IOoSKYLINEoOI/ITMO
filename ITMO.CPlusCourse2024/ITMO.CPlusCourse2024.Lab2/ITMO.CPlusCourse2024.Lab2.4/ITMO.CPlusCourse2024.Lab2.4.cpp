#include <iostream>

int main()
{
    system("chcp 1251");

    int k, m, s = 0;

    std::cout << "¬ведите начало интервала" << std::endl; std::cin >> k;
    std::cout << "¬ведите начало интервала" << std::endl; std::cin >> m;

    for (int i = 1; i <= 100; i++)
    {
        if ((i > k) && (i < m))
            continue;
        s += i;
    }

    std::cout << s << std::endl;
}

