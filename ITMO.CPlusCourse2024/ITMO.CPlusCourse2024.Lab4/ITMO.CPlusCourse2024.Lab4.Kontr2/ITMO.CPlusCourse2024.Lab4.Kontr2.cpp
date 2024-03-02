#include <iostream>

bool Input(int&, int&);

int main()
{
    system("chcp 1251");
    
    int a, b;

    if (Input(a, b) == false) 
    {
        std::cerr << "error";
        return 1;
    }
    int s = a + b;
    return 0;
}

bool Input(int& a, int& b) {

    std::cout << "\t¬ведите два целых числа: " << std::endl;

    std::cout << "¬ведите первое целое число: ";
    std::cin >> a;  
    if (std::cin.good() != true) return false;
    
    std::cout << "¬ведите второе целое число: ";
    std::cin >> b;
    if (std::cin.good() != true) return false;

    /*do{
        std::cout << "¬ведите первое целое число: ";
        std::cin >> a;

    } while (std::cin.good() == false);*/

    return true;
}