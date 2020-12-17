#include <iostream>
using namespace std;

int main() {
  int i;
  char y ;
  char x ;
  cin>>y>>x;
  for(i=y;i<=x;i++)
  i+=1;
if(x<y)
{
  cout<<"YES";
}
else if(y==x)
{
cout<<"EQUAL";
}
else 
{
  cout<<"NO";
}
}