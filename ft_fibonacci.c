/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_fibonacci.c                                     :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/08 13:12:37 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/08 13:12:42 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

int ft_fibonacci(int index);

int ft_fibonacci(int index)
{
  if (index < 1)
    return(0);
  else if (index <= 1)
    return(index);
  else
    return (ft_fibonacci(index-1) + ft_fibonacci(index-2));
}

