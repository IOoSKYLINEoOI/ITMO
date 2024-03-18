#include <iostream>

template<class T, class T1> class Array
{
public:
    Array(int size);
    T1 sum();
    T average_value();
    void show_array();
    int add_value(T);
private:
    T* data;
    int size;
    int index;
};

template<class T, class T1> Array<T, T1>::Array(int size)
{
    data = new T[size];
    if (data == NULL)
    {
        std::cerr << "Error memory ---- exit program" << std::endl;
        exit(1);
    }
    Array::size = size;
    Array::index = 0;
}
template<class T, class T1> T1 Array<T, T1>::sum()
{
    T1 sum = 0;
    for (int i = 0; i < index; i++) sum += data[i];
    return(sum);
}
template<class T, class T1> T Array<T, T1>::average_value()
{
    T1 sum = 0;
    for (int i = 0; i < index; i++) sum += data[i];
    return (sum / index);
}
template<class T, class T1> void Array<T, T1>::show_array()
{
    for (int i = 0; i < index; i++) std::cout << data[i] << ' ';
    std::cout << std::endl;
}
template<class T, class T1> int Array<T, T1>::add_value(T value)
{
    if (index == size)
        return(-1);
    else
    {
        data[index] = value;
        index++;
        return(0);
    }
}


int main()
{
    Array<int, long> numbers(100);
    Array<float, float> values(200);

    int i;
    
    for (i = 0; i < 50; i++) numbers.add_value(i);

    numbers.show_array();
    std::cout << "Sum = " << numbers.sum() << std::endl;
    std::cout << "Average = " << numbers.average_value() << std::endl;
    
    for (i = 0; i < 100; i++) values.add_value(i * 100);
    
    values.show_array();
    std::cout << "Sum = " << values.sum() << std::endl;
    std::cout << "Average = " << values.average_value() << std::endl;
    
    return 0;
}
