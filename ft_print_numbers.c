
#include <unistd.h>

int ft_putchar(char c)
{
  write(1, &c, 1);
  return (0);
}

void ft_print_numbers(void)
{
  int i = '0';
  while(i <= '9')
    {
      ft_putchar(i);
      i = i+1;
    }
  ft_putchar('\n');
}

int main()
{
  ft_print_numbers();
  return (0);
}
