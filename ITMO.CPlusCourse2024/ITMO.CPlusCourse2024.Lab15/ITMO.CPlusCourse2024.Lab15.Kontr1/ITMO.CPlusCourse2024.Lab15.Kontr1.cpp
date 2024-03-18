#include <iostream>
#include <map>

struct StudentGrade {

    std::string name;
    char grade;

};

StudentGrade Input()
{
    StudentGrade stud;
    std::cout << "Введите имя студента: ";
    std::cin >> stud.name;
    std::cout << "Введите оценку: ";
    std::cin >> stud.grade;

    return stud;
}

void Show(StudentGrade stud)
{
    std::cout << stud.name << "\'-" << stud.grade << "\"\n";
}

int main()
{
    system("chcp 1251");

    std::map<std::string, char> students;
    bool flag = true;

    while (flag) {
        StudentGrade stud = Input();
        std::cout << "Введите 0/1, чтобы прекратить/продолжить ввод оценок:";
        std::cin >> flag;
        if (students.count(stud.name) == 0) {
            students[stud.name] = stud.grade;
        }
        else {
            std::cout << "У студента уже стоит оценка.";
        }
    }

    for (const auto& element : students)
        std::cout <<"Фамилия: " << element.first << "\t\t" <<"Оценка - " << element.second << std::endl;

    return 0;
}