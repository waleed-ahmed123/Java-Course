// Webinar_6b.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
void printfirstchar(char* );
void modify(char*);
int main()
{
   /* int numA = 10;
    double numB = 50;

    cout << "numA is: " << numA << endl;
    cout << "numA memory address is: " << &numA << endl;

    cout << "numB is: " << numB << endl;
    cout << "numB memory address is: " << &numB << endl;

    // create a pointer 

    int numC = 6;
    int* p_numC;

    p_numC = &numC;
    cout << "value of numC is: " << numC << endl;

    cout << "value of numC is: " << *p_numC << endl;
    */

    /*int myArray[5] = { 10,20,30,40,50 };
    for (int i = 0; i < 5; i++)
    {
        cout << myArray[i] << endl;
    }

    int* ptr;

    ptr = &myArray[0];

    cout << "value is " << *ptr << endl;

    ptr = ptr + 2;

    cout << "value is: " << *ptr << endl;

    ptr = &myArray[0];

    cout << "array traversal with ptr is: " << endl;
    for (int i = 0; i < 5; i++)
    {
        cout << *(ptr + i) << endl;
    }

    cout << "array traversal with moving ptr is: " << endl;
    for (int i = 0; i < 5; i++)
    {
        cout << *ptr++ << endl;
    }

    cout << "array traversal is: " << endl;
    for (int i = 0; i < 10; i++)
    {
        cout << *(ptr + i) << endl;
    }
    */

    /*char string[] = "test";
    cout << string << endl;

    char* ptr_string = &string[0];

    ptr_string = ptr_string + 2;
    *ptr_string = 'a';
    *(ptr_string + 1) = 'a';

    cout << string << endl;
    */

    /*char string2[] = "this is a test";  // get the first letter on the string array
    printfirstchar(&string2[0]);
    printfirstchar(string2);

    string myString = "this is a test";
    printfirstchar(&myString[0]);*/
  

    string test = "this is a test";
    modify(&test[0]);
    cout << test << endl;


    /*
    // array notation vs arithmetic pointer

    double w3[3] = { 1.0, 2.0, 3.0 };

    //two ways

    double* pw = w3;
    cout << "w3[0] is " << w3[0] << endl;
    cout << "w3[0] is " << *pw << endl;

    */
}



void printfirstchar(char* a)
{  //display first char of the string 
    cout << *a;
}

//modify the first 2 chars passed in the string
void modify(char* a)
{
    *a = '%';
    *(a + 1) = '%';
}
