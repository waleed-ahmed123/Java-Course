// Webinar_6a.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int max(int, int);
void subString(string, string);
void pointers();

int main()
{
    /*cout << "Hello World!\n";

    string course = "screw";

    cout << course << endl;

    cout << course << " is a " << 5 << " star " << endl;

    // input for char
    //you can do this for other types too

    char myChar;
    cout << "enter a char: ";
    cin >> myChar;

    cout << "char is: " << myChar << endl;

    int n1;
    int n2;

    cout << "n1 ";
    cin >> n1;

    cout << "n2 ";
    cin >> n2;

    cout << max(n1, n2);
    

    int num ;

    bool isTrue;

    char myChar;

    double pi;

    cout << "double size " << sizeof(pi) << endl;

    // for arrays

    float nums[3];

    nums[0] = 1, nums[1] = 2, nums[2] = 3;

    int i = 0;
    int lens = sizeof(nums)/sizeof(nums[0]);
    while (i<lens)
    {
        cout << nums[i] << endl;
        i++;
    }
    

    // array of strings as chars

    char mystring[12] = "test string";
    cout << mystring;

    mystring[0] = mystring[0] + 1; // get asci code of mystring[0], add 1, convert it back to char
    

    //defining strings

    string x1("test 55");
    string x2 = "test 65";
    string x3; x3 = "test 999";

    cout << x1 << endl;
    cout << x2 << endl;
    cout << x3 << endl;

    cout << x1 + x3 << endl;
    

    //test substring

    string t;
    string p;

    cout << "text in input: " << endl;
    cin >> t;

    cout << "parrtern to detect: " << endl;
    cin >> p;

    subString(t, p);

    cout << t.find(p) << endl;

    string y = "this is an example of substr";
    cout << y.substr(5, 2);


    string is = "is";
    int pos = y.find(is);

    cout << "this is substr & find " << endl;
    cout << y.substr(pos, is.length());

    //append

    string r = "this is a test for append";
    string a = "ABS";

    cout << r.append(a) << endl;
    */
    
pointers();

}



void pointers()
{
    int myvar1 = 5;
    int myvar2 = 50;
    double mydbl = 5.3;

    int* ptrVar; // this is going to store the memory address of an int
    ptrVar = &myvar2; // stores the memory address of myvar2 in ptrVar

    cout << *ptrVar << endl; // display the contents of myvar2 using ptrVar

    // change the contents of myvar2 using ptrVar
    //put 10 into myvar2

    *ptrVar = 10;

}


void subString(string t, string p)
{
    int n = t.length();
    int m = p.length();

    //for loop to move along the string t
    for (int i = 0; i <= n - m; i++)
    {
        //check if i find the pattern p inside t
        //pattern p BCE

        int j = 0;
        while (j < m && t[i + j] == p[j])  //check that each char in p matches the char in t
        {
            j++;
        }

        //check if found a pattern inside 
        if (j == m) cout << i << " " << endl;
    }
}

int max(int n1, int n2)
{
    if (n1 < n2) return n2;
    else return n1;
}