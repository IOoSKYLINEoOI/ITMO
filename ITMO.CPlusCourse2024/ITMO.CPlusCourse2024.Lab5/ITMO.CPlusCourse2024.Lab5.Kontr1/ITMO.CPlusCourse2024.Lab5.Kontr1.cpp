#include <iostream>

double AVGArr(const int, const int arr[]);
int SumArr(const int, const int arr[]);
int SumNeg(const int, const int arr[]);
int SumPoz(const int, const int arr[]);
int SumChet(const int, const int arr[]);
int SumNechet(const int, const int arr[]);
void SortArr(const int, int arr[]);


int main()
{
    system("chcp 1251");

    int n;

    do {
        std::cout << "������� ������ �������: "; std::cin >> n;
    } while (!std::cin.good());

    int* myArray = new int[n];
    int x;

    for (int i = 0; i < n; i++) {
        std::cout << "������� " << i << " �������� ������� : "; std::cin >> x;
        myArray[i] = x;
    }

    std::cout << "����� ��������� �������: " << SumArr(n, myArray) << std::endl;
    std::cout << "�������������������� ��������� �������: " << AVGArr(n, myArray) << std::endl;
    std::cout << "����� ������������� ��������� �������: " << SumNeg(n, myArray) << std::endl;
    std::cout << "����� ������������� ��������� �������: " << SumPoz(n, myArray) << std::endl;
    std::cout << "����� ������ ��������� �������: " << SumChet(n, myArray) << std::endl;
    std::cout << "����� �������� ��������� �������: " << SumNechet(n, myArray) << std::endl;

    std::cout << "����������� ������: ";
    for (int i = 0; i < n; i++) {
        std::cout << myArray[i] << " ";
    }

    std::cout << std::endl;

    SortArr(n, myArray);
    std::cout << "���������������� ������: ";
    for (int i = 0; i < n; i++) {
        std::cout << myArray[i] << " ";
    }

    delete[] myArray;

    return 0;
}

double AVGArr(const int n, const int arr[]) {
    double s = 0;

    for (int i = 0; i < n; i++) {
        s += arr[i];
    }

    return s / n;
}

int SumArr(const int n, const int arr[]) {
    int s = 0;

    for (int i = 0; i < n; i++) {
        s += arr[i];
    }

    return s;
}

int SumNeg(const int n, const int arr[]) {
    int s = 0;

    for (int i = 0; i < n; i++) {
        if(arr[i] < 0) s += arr[i];
    }

    return s;
}

int SumChet(const int n, const int arr[]) {
    int s = 0;

    for (int i = 0; i < n; i++) {
        if (arr[i] % 2 == 0) s += arr[i];
    }

    return s;
}

int SumNechet(const int n, const int arr[]) {
    int s = 0;

    for (int i = 0; i < n; i++) {
        if (arr[i] % 2 != 0) s += arr[i];
    }

    return s;
}

int SumPoz(const int n, const int arr[]) {
    int s = 0;

    for (int i = 0; i < n; i++) {
        if (arr[i] > 0) s += arr[i];
    }

    return s;
}

void SortArr(const int n, int arr[]) {
    int min = 0;
    int buf = 0;

    for (int i = 0; i < n; i++)
    {
        min = i;

        for (int j = i + 1; j < n; j++)
            min = (arr[j] < arr[min]) ? j : min;

        if (i != min)
        {
            buf = arr[i];
            arr[i] = arr[min];
            arr[min] = buf;
        }
    }
}