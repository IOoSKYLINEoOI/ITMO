#include <iostream>
#include "person.h"
#include "student.h"
#include "teacher.h"
#include "collection.h"
#include "personFactory.h"
#include "teacherFactory.h"
#include "studentFactory.h"


int main()
{
    system("chcp 1251");

    Collection collection;
    PersonFactory* studentFactory = new StudentFactory();
    PersonFactory* teacherFactory = new TeacherFactory();

    Person* student1 = studentFactory->createPerson();
    Person* teacher1 = teacherFactory->createPerson();

    collection.addPerson(student1);
    collection.addPerson(teacher1);

    collection.saveToFile("people.txt");

    delete studentFactory;
    delete teacherFactory;
    delete student1;
    delete teacher1;

    return 0;
}

