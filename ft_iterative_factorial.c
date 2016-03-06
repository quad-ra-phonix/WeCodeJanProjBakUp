/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_iterative_factorial.c                           :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/08 08:38:01 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/08 08:38:06 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */
#include <stdio.h>

int ft_iterative_factorial(int nb);

int main()
{
  int res;
  res=ft_iterative_factorial(9);
  
  printf("From the main function%d\n",res);
  return(0);
}

int ft_iterative_factorial(int nb)
{
  int i;
  int res;

  res=1;
  i =2;

  while (i <= nb)
    {
      res*=i;
      printf("%d\n",res);
      i=i+1;
    }
  return res;
}
