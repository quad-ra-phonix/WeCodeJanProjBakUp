/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_iterative_power.c                               :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/08 10:42:53 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/08 10:42:57 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

int ft_iterative_power(int nb, int power);

int ft_iterative_power(int nb, int power)
{
  int res;
  res =1;

  if(nb == 0 && power <= 0)
    {
      return(0);
    }
  else
    {
      while(power > 0)
	{
	  res = nb * res;
	  power --;
	}
      return(res);
    }
}
