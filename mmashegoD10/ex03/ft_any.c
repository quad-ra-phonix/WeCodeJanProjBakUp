/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_any.c                                           :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/16 15:30:53 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/16 15:37:41 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */
int		ft_any(char **tab, int(*f)(char*))
{
	int		i;

	i = 0;
	while (tab[i][0] != '0')
	{
		if (f(tab[i] == 1)
				return (1);
				i++;
	}
	return (0);
}
