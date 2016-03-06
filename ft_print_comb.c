/* **********************OA**************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_print_comb.c                                    :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/04 09:52:40 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/04 09:52:45 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <unistd.h>
#include <string.h>

int ft_putchar(char c)
{
  write(1, &c, 1);
  return(0);
}

void ft_print_comb(void)
{
  char a;
  char b;
  char c;
  a='0';
  b='0';
  c='0';

  while (a<='7' && b<='8' && c<='9')
    {
      ft_putchar(a);
      ft_putchar(b);
      ft_putchar(c);

      if(a!='7' || b!='8' || c!='9')
	{
	  ft_putchar(',');
	  ft_putchar(' ');
	}
      c++;
      if(c=='9' +1)
	{
	  c=b+1;
	  b++;
	}
      if(b=='8'+1)
	{
	  b=a+1;
	  a++;
	}
  if(c==b)
    c++;
  if(b==a)
    b++;
  }
}

int main()
{
  ft_print_comb();
  return(0);
}

