#include <iostream>

int main() {
  int A;
  int B;
  int C;
  int D;
  std::cin>>A>>B>>C>>D;
   int e = A+B+C+D;
  int r=(B+D)*A;
   int y=((A*D)-(B+C));
   
  if(A>C)
  {
    std::cout<<y;
  } 
  else if (C>A)
  {
    std::cout<<r;
  }
   else 
   {
     std::cout<<e;
   }
  
  
  
  
  
 
}