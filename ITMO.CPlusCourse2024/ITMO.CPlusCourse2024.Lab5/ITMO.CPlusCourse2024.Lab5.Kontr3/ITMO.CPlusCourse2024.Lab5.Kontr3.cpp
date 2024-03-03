#include <iostream>

int SearchArr(const int n, int arr[], int key);

int main()
{
    system("chcp 1251");

    int n;
    bool flag = true;

    do {
        std::cout << "������� ������ �������: "; std::cin >> n;
    } while (!std::cin.good());

    int* myArray = new int[n];
    int x;

    for (int i = 0; i < n; i++) {
        std::cout << "������� " << i << " �������� ������� : "; std::cin >> x;
        myArray[i] = x;
    }

    int key;

    std::cout << "������� ���������� ��� ������: "; std::cin >> key;

    int index = SearchArr(n, myArray, key);

    if (index != -1) {
        std::cout << "������� ���������� ����� ������: " << index << std::endl;
    }
    else {
        std::cout << "���������� ��� � �������" << std::endl;
    }

    delete[] myArray;

    return 0;
}

int SearchArr(const int n, int arr[], int key) {
    
    for (int i = 0; i < n; i++) {
        if (arr[i] == key) {
            if (i != 0) {
                int temp = arr[i - 1];
                arr[i - 1] = arr[i];
                arr[i] = temp;
                return i;
            }
            return i;
        }
    }
    return -1;
}