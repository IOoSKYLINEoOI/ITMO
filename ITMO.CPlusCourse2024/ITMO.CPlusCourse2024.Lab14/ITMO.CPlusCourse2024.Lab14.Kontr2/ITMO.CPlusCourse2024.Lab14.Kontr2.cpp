#include <iostream>
#include <vector>

template <class T>
void Print(const T& container, const std::string& separator) {
    
    std::cout << container[0];
    for (int i = 1; i < size(container); i++) {
        std::cout << separator << container[i];
    }
    std::cout << std::endl;
}

int main()
{
    std::vector<int> data1 = { 1, 2, 3 };
    Print(data1, ", "); 

    std::vector<char> data2 = { 'a', 'e', 't', 'r', '7'};
    Print(data2, ", ");

    std::vector<double> data3 = { 1.06, 2.89, 3.00, 45.5, -35};
    Print(data3, ", ");

    return 0;
}


