#include <iostream>
#include <map>

struct StudentGrade {

    std::string name;
    char grade;

};

StudentGrade Input()
{
    StudentGrade stud;
    std::cout << "������� ��� ��������: ";
    std::cin >> stud.name;
    std::cout << "������� ������: ";
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
        std::cout << "������� 0/1, ����� ����������/���������� ���� ������:";
        std::cin >> flag;
        if (students.count(stud.name) == 0) {
            students[stud.name] = stud.grade;
        }
        else {
            std::cout << "� �������� ��� ����� ������.";
        }
    }

    for (const auto& element : students)
        std::cout <<"�������: " << element.first << "\t\t" <<"������ - " << element.second << std::endl;

    return 0;
}