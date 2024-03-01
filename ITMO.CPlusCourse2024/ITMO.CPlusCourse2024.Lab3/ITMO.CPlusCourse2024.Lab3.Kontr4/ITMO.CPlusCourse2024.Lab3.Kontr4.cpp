#include<iostream>

int Summa(int n);

int main() {
    system("chcp 1251");

    int n;

    std::cout << "¬ведите значени n: ";
    std::cin >> n;
    std::cout << Summa(n) << std::endl;
    return 0;
}

int Summa(int n) {
    if (n == 0)
        return 0;
    else
        return (n * 5) + Summa(n - 1);
}