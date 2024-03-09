#include <iostream> 
#include <string>

class DivideByZeroError
{
public:
    DivideByZeroError() : message("������� �� ����") { }
    void printMessage() const { std::cout << message << std::endl; }
private: std::string message;
};

float quotient(int, int);

int main()
{
    system("chcp 1251");

    std::cout << "������� ����� �����(���������) ��� ������� ��������:\n";
    int number1;
    std::cin >> number1;

    for (int i = -10; i < 10; i++) {
        try {
            float result = quotient(number1, i);
            std::cout << "������� ����� " << result << std::endl;
        }
        catch (DivideByZeroError& error) {
            std::cout << "������: ";
            error.printMessage();
        }
    };

    return 0;
}

float quotient(int numl, int num2) {
    if (num2 == 0) throw DivideByZeroError();
    return (float)numl / num2;
};

