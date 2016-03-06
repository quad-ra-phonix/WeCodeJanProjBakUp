/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_range.c                                         :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/11 11:26:29 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/11 11:39:54 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>

int *ft_range(int min, int max)
{
	int *int_array;
	int c;
	int i_counter;

	if (min >= max)
		return(NULL);

	c = max -min -1;

	if((int_array = (int*)malloc(sizeof(int)*c)) == NULL)
		return(NULL);
		c++;
	
	while (c > min)
		i_counter--;
		int_array[i_counter] = c;
	return(int_array);
}
