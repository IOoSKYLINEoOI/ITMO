#include <iostream>

template<class T>
void sorting(T arr[], int size) {
    int j = 0;
    for (int i = 0; i < size; i++) {
        T x = arr[i];
        for (j = i - 1; j >= 0 && x < arr[j]; j--)
            arr[j + 1] = arr[j];
        arr[j + 1] = x;
    }
}

template<class T>
void print(T arr[], int size) {
    for (int i = 0; i < size; i++) std::cout << arr[i] << ";";
}

int main()
{
    int arr[] = { 9,3,17,6,5,4,31,2,12 };
    double arrd[] = { 2.1, 2.3,1.7,6.6,5.3,2.44,3.1,2.4,1.2 };
    char arrc[] = "Hello, word";

    int k1 = sizeof(arr) / sizeof(arr[0]);
    int k2 = sizeof(arrd) / sizeof(arrd[0]);
    int k3 = sizeof(arrc) / sizeof(arrc[0]) - 1;

    sorting(arr, k1);
    print(arr, k1);
    std::cout << std::endl;

    sorting(arrd, k2);
    print(arrd, k2);
    std::cout << std::endl;

    sorting(arrc, k3);
    print(arrc, k3);
    std::cout << std::endl;
}

