#include <iostream>

void show_array(const int Arr[], const int N);
bool from_min(const int a, const int b);
bool from_max(const int a, const int b);
void bubble_sort(int Arr[], const int N, bool (*compare)(int a, int b));


int main()
{
    system("chcp 1251");

    int n;

    do {
        std::cout << "Введите размер массива: "; std::cin >> n;
    } while (!std::cin.good());

    int* myArray = new int[n];
    double x;

    for (int i = 0; i < n; i++) {
        std::cout << "Введите " << i << " значение массива : "; std::cin >> x;
        myArray[i] = x;
    }

    int my_choose = 0;
    bool (*from_f[2])(int, int) = { from_min,from_max };

    std::cout << "1. Сортировать по возрастанию\n";
    std::cout << "2. Сортировать по убыванию\n";
    std::cin >> my_choose;

    std::cout << "Исходные данные: ";
    show_array(myArray, n);

    bubble_sort(myArray, n, (*from_f[my_choose - 1]));

    show_array(myArray, n);

    delete[] myArray;
    myArray = nullptr;

    return 0;
}

void show_array(const int Arr[], const int N)
{
    for (int i = 0; i < N; i++)
        std::cout << Arr[i] << " ";
    std::cout << "\n";
}

bool from_min(const int a, const int b)
{
    return a > b;
}

bool from_max(const int a, const int b)
{
    return a < b;
}

void bubble_sort(int Arr[], const int N, bool (*compare)(int a, int b))
{
    for (int i = 1; i < N; i++)
    {
        for (int j = 0; j < N - 1; j++)
        {
            if ((*compare)(Arr[j], Arr[j + 1])) std::swap(Arr[j], Arr[j + 1]);
        }
    }
}