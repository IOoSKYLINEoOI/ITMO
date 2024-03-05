#include <iostream>
#include <windows.h>


struct Distance
{
    int feet;
    double inches;

    void ShowDist()
    {
        std::cout << feet << "\'-" << inches << "\"\n";
    }
};

Distance AddDist(const Distance &, const Distance &);
Distance InputDist();


int main()
{
    system("chcp 1251");

    Distance d1 = InputDist();
    Distance d2 = { 1, 6.25 };

    Distance d3 = AddDist(d1, d2);

    d1.ShowDist();
    d2.ShowDist();
    d3.ShowDist();

    //3
    int n;

    std::cout << "Введите размер массива расстояний ";
    std::cin >> n;

    Distance* masDist = new Distance[n];

    for (int i = 0; i < n; i++)
    {
        masDist[i] = InputDist();
    }

    Distance sum = { 0, 0.0};

    for (int i = 0; i < n; i++)
    {
        masDist[i].ShowDist();
        sum = AddDist(sum, masDist[i]);
    }

    std::cout << "Cумма всех расстояний, входящих в массив: ";
    sum.ShowDist();

    delete[] masDist;

    return 0;
}

Distance AddDist(const Distance &d1,const Distance &d2)
{
    Distance d;
    d.feet = d1.feet + d2.feet;
    d.inches = d1.inches + d2.inches;
    if (d.inches >= 12.0)
    {
        d.inches -= 12.0;
        d.feet++;
    }
    return d;
}

Distance InputDist()
{
    Distance d;
    std::cout << "\nВведите число футов: ";
    std::cin >> d.feet;
    std::cout << "Введите число дюймов: ";
    std::cin >> d.inches;
    return d;
}

