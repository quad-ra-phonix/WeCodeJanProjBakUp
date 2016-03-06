/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_print_comb2.c                                   :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/04 13:58:02 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/04 13:58:10 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */
#include<unistd.h>

int ft_putchar(char c)
{
  write(1, &c, 1);
  return(0);
}

void ft_print_comb2(void)
{
  char a;
  char b;
  char c;
  char d;
  
  a='0';
  b='0';
  c='0';
  d='1';

  while (a<='9' && b<='8' && c<='9' && d<='9')
    {
      ft_putchar(a);
      ft_putchar(b);
      ft_putchar(' ');
      ft_putchar(c);
      ft_putchar(d);

      if(a!='9' || b!='8' || c!='9' || d!='9')
	{
	  ft_putchar(',');
	  ft_putchar(' ');
	}
      d++;
      if(d=='9' +1)
	{
	  d='0';
	  c++;
	}
      if(c=='9' +1)
	{
	  c='0';
	  b++;
	  d=b+1;
	}
      if(b=='8' +1)
	{
	  a=a+1;
	  b='0';
	  c='0';
	  d=b+1;
	}
    }
  ft_putchar('\n');
}

int main()
{
  ft_print_comb2();
  return(0);
}

