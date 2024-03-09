#include <iostream> 
#include <string>

class DivideByZeroError 
{ 
public:
    DivideByZeroError() : message("Деление на нуль") { } 
    void printMessage() const { std::cout << message << std::endl; } 
private: std::string message; 
};

float quotient(int, int);

int main()
{
    system("chcp 1251");

    std::cout << "Введите два целых числа для расчета их частного:\n";
    int number1, number2; 
    std::cin >> number1; std::cin >> number2; 

    try {
        float result = quotient(number1, number2);
        std::cout << "Частное равно " << result << std::endl;
    }
    catch (DivideByZeroError& error) {
        std::cout << "ОШИБКА: "; 
        error.printMessage(); 
        return 1; 
    } 
    
    return 0;
}

float quotient(int numl, int num2) {
    if (num2 == 0) throw DivideByZeroError();
    return (float)numl / num2;
};


