#include <iostream>
using namespace std;
void substitute(char*, char, char);
int main()
{									      //p1//p2
	string S = "la!belabella!bel";     // "l a ! b e l a b e l l a ! b e l "
	char c1 = 'a';
	char c2 = 'x';

	char* p1 = &S[0];
	char* p2 = &S[0];

	for (int i = 0; i < S.length(); i++)
	{
		if (p1[i] == 'a' && p2[i+1] == '!') 
		{
			cout << p1[i] << " is being substituted by " << c2 << endl;
			substitute(&p1[i], c1, c2);
		}
		
		
	}
	cout << S << endl;
	//‘lx!belabellx!bel’
}


void substitute(char* S, char c1, char c2)
{
	*S = c2;       // get the value of p1[j] using the address of p1[j] and replace it with c2 (x) 
}