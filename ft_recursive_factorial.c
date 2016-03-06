/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_recursive_factorial.c                           :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/08 09:40:17 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/08 09:40:24 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */
#include <stdio.h>

int ft_recursive_factorial(int nb);

int main()
{
  int res;
  res = ft_recursive_factorial(9);
  printf("%d\n", res);
  return(0);
}

int ft_recursive_factorial(int nb)
{
  int res;

  if (nb <= 1)
    res = 1;
  else
    res = nb * ft_recursive_factorial(nb-1);

  return res;
}


