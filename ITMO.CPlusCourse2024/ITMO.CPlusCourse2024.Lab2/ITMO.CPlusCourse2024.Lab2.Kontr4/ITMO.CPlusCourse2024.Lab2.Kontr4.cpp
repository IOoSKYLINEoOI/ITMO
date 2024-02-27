#include <iostream>
#include <cmath>
#include <ctime>

int main()
{
    system("chcp 1251");
    srand(time(NULL));

    int n, mode, check = 0;

    do {
        std::cout << "\tВыберите режим\n1 - С известным количеством выстрелов.\n2 - Режим стрельбы в слепую c помехой.\n3 - До 50 очков.\n"; std::cin >> mode;
    } while (mode != 1 && mode != 2 && mode != 3);

    switch (mode)
    {
    case 1:
    {
        double x = 0, y = 0;

        std::cout << "Введите количество выстрелов: "; std::cin >> n;

        for (int i = 0; i < n; i++) {
            std::cout << "Введите координату x: "; std::cin >> x;
            std::cout << "Введите координату y: "; std::cin >> y;

            if (fabs(x) < 1 && fabs(y) < 1) {
                check += 10;
                std::cout << "Попадание в 1-ю зону" << std::endl;
            }
            else if (fabs(x) < 2 && fabs(y) < 2) {
                check += 5;
                std::cout << "Попадание вj 2-ю зону" << std::endl;
            }
            else {
                std::cout << "Промах :(" << std::endl;
            }
        }

        std::cout << "Количество очков: " << check;
        break;
    }
    case 2:
    {
        int x0 = rand() % 10 + 1;
        int y0 = rand() % 10 + 1;

        std::cout << "Центр мишени: x = " << x0 << " y = " << y0 << std::endl;

        double x = 0, y = 0;

        std::cout << "Введите количество выстрелов: "; std::cin >> n;

        for (int i = 0; i < n; i++) {
            std::cout << "Введите координату x: "; std::cin >> x;
            std::cout << "Введите координату y: "; std::cin >> y;

            if ((rand() % 10 + 1) % 2 == 0) {
                x = x + rand() % 10 + 1;
                y = y + rand() % 10 + 1;

                std::cout << "Сработала помеха, новые координаты попадания: x = " << x << " y = " << y << std::endl;
            }

            if (fabs(x) < x0 + 1 && fabs(y) < y0 + 1) {
                check += 10;
                std::cout << "Попадание в 1-ю зону" << std::endl;
            }
            else if (fabs(x) < x0 + 2 && fabs(y) < y0 + 2) {
                check += 5;
                std::cout << "Попадание вj 2-ю зону" << std::endl;
            }
            else {
                std::cout << "Промах :(" << std::endl;
            }
        }

        std::cout << "Количество очков: " << check;
        break;
    }
    case 3: {

        int count = 0;
        double x = 0, y = 0;

        while (check < 50) {
            std::cout << "Введите координату x: "; std::cin >> x;
            std::cout << "Введите координату y: "; std::cin >> y;

            count += 1;

            if (fabs(x) < 1 && fabs(y) < 1) {
                check += 10;
                std::cout << "Попадание в 1-ю зону" << std::endl;
            }
            else if (fabs(x) < 2 && fabs(y) < 2) {
                check += 5;
                std::cout << "Попадание вj 2-ю зону" << std::endl;
            }
            else {
                std::cout << "Промах :(" << std::endl;
            }
        }

        if (count <= 4) {
            std::cout << "Проффесионал" << std::endl;
        }
        else if (count <= 6) {
            std::cout << "Спортсмен" << std::endl;
        }
        else if (count <= 8) {
            std::cout << "Любитель" << std::endl;
        }
        else {
            std::cout << "Мазила" << std::endl;
        }
    }
    }

    return 0;
}

