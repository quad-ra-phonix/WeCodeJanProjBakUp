
#include <unistd.h>

int ft_putchar(char c)
{
  write(1, &c, 1);
  return (0);
}

void ft_is_negative(int n)
{
  char int_sign;
  
  if(n<0)
    {
      int_sign = 'N'; 
    }
  else
    {
      int_sign = 'P';
    }
  ft_putchar(int_sign);
  ft_putchar('\n');
}

int main()
{
  int n;
  n=600;
  ft_is_negative(n);
  return(0);
}
