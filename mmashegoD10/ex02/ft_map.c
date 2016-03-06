/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_map.c                                           :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/16 15:21:09 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/16 15:28:31 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

int		ft_map(int *tab, int length, int(*f)(int))
{
	int		*ptr;
	int 	i;

	i = 0;
	ptr = (int*)malloc(sizeof(*tab) * length);
	while (i < length)
	{
		ptr[i] = f(tab[i]);
		i++;
	}
	return (ptr);
}
