#include <iostream>
using namespace std;

class Parent
{
public:
    Parent()
    {
        cout << "Calling Parent\n";
    }
};
class Student : public Parent
{
public:
    Student()
    {
        cout << "Calling Student\n";
    }
};

int main()
{

    Parent *P = new Student();
    //  Student *S = new Parent();  // this will throw error
}
