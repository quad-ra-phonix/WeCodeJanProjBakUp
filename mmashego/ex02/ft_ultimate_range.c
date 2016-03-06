/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_ultimate_range.c                                :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/11 11:42:09 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/11 11:55:14 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

	#include <stdlib.h>

	int ft_ultimate_range(int **range, int min, int max)
	{
		int i;
		int *tab;

		if(min >= max)
		{
			*range = (void *)0;
			return(0);
		}

		tab = (int*)malloc(sizeof(*tab)*(max - min));
		i = 0;
		while(min < max)
		{
			tab[i] = min;
			i++;
			min++;
		}
		*range = tab;
		return (i);
	}
