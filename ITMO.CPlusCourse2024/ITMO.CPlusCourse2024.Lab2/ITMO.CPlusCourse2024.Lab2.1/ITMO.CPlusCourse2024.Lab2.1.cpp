#include <iostream>

int main()
{
    system("chcp 1251");

    //Zadnie1
    double x, y;
    std::cout << "Введите координаты точки = ";
    std::cin >> x >> y;

    if (x * x + y * y < 9 && y > 0)
    {
        std::cout << "\nВнутри";
    }    
    else if (x * x + y * y > 9 || y < 0)
    {
        std::cout << "\nCнаружи";
    }
    else
    {
        std::cout << "\nНа границе";
    }

    //Zadanie2
    char op;

    std::cout << "\nСделай свой выбор, собери авто свой мечты: ";
    std::cin >> op;

    switch (op)
    {
    case 'V':
        std::cout << "Кондиционер хочу\n";
    case 'S':
        std::cout << "Радио играть должно\n";
    default:
        std::cout << "Колеса круглые\n";
        std::cout << "Мощный двигатель\n";
    }

    return 0;
}

