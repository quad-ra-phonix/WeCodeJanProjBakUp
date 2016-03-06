/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_list_params.c                                   :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/17 15:38:04 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/17 15:45:28 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>
#include "ft_list.h"

t_list		*add_link(t_list *list, void *data)
{
			t_list		*tmp;

			tmp = malloc(sizeof(t_list));
			if (tmp)
			{
					tmp->data = data;
					tmp->next = list;
			}
			return (tmp);
}

t_list		*ft_list_push_params(int ac, char **av)
{
			t_list	*list;
			int		i;

			i = 2;
			if (ac == 1)
					return (NULL);
			list = ft_create_elem(av[1]);
			while (i < ac)
			{
					list = add_link(list, av[i]);
					i++;
			}
			return (list);
}
