/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_list_size.c                                     :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/17 15:02:09 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/17 15:06:28 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_list.h"

int		ft_list_size(t_list *begin_list)
{
		t_list		*list;
		int			i;

		i = 0;
		list = begin_list;
		while (list)
		{
			i++;
			list = list->next;
		}
		return (i);
}
