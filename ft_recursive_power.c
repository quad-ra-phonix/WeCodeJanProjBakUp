/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_recursive_power.c                               :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/08 11:53:34 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/08 11:53:38 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */
#include <stdio.h>

int ft_recursive_power(int nb, int power);

int main()
{
  int res;
  res = ft_recursive_power(25,5);
  printf("%d\n", res);
  return(0);
}

int ft_recursive_power(int nb, int power)
{
  int result;
  result = 1;
    if(power <= 0)
      {
	return result;
      }
    else
      {
	result = nb * ft_recursive_power(nb,power-1);
      }
    return result;
}


