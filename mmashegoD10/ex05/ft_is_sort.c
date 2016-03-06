/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_is_sort.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/16 15:53:50 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/16 16:00:38 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

int 	ft_is_sort(int *tab, int length, int(*f)(int, int))
{
	int		i;

	int = 0;
	while (i < length -1)
	{
		if (f(tab[i], tab[i + 1] >= 0)
				i++;
		else
			i = length;
	}
	if (i == length -1)
		return (1);
	i = 0;
	while (i < length - 1)
	{
		if (f(tab[i], tab[i + 1]) <= 0)
			i++;
		else
			i = length;
	}
	if (i == length -1)
	{
		return (1);
	}
	return (0);
}
