#pragma once

class Person {
public:
    Person(
        const std::string& first_name,
        const std::string& last_name,
        const std::string& father_name,
        const std::string& phone_number) : 
        first_name(first_name),
        last_name(last_name),
        father_name(father_name),
        phone_number(phone_number) {}

    virtual void printDetails() const = 0;

    virtual std::string getStatus() const = 0;

    std::string getFullName() const {
        return "Фамилия: " + last_name + " Имя: " + first_name + " Отчество: " + father_name;
    }

    std::string getPhone() const {
        return phone_number;
    }

private:
    std::string first_name;
    std::string last_name;
    std::string father_name;
    std::string phone_number;
};



//class Person {
//public:
//
//	Person();
//
//	std::string getFirstName() { return first_name; };
//	void setFirstName(std::string first_name) { this->first_name = first_name; };
//	std::string getLastName() { return last_name; };
//	void setLasttName(std::string last_name) { this->last_name = last_name; };
//	std::string getFatherName() { return father_name; };
//	void setFatherName(std::string father_name) { this->father_name = father_name; };
//	int getAge() { return age; };
//	void setAge(int age) { this->age = age; };
//	std::string getPhoneNumber() { return phone_number; };
//	void setPhoneNumber(std::string phone_number) { this->phone_number = phone_number; };
//
//	virtual void printDetails() const = 0;
//
//private:
//	std::string first_name;
//	std::string last_name;
//	std::string father_name;
//	int age;
//	std::string phone_number;
//	std::string status;
//};
//
//Person::Person() {
//	std::cout << "Введите имя: "; std::cin >> first_name;
//	std::cout << "Введите фамилию: "; std::cin >> last_name;
//	std::cout << "Введите отчество: "; std::cin >> father_name;
//	std::cout << "Введите возраст: "; std::cin >> age;
//	std::cout << "Введите номер телефона: "; std::cin >> phone_number;
//}