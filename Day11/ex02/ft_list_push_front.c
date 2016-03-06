/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_list_push_front.c                               :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/17 14:19:19 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/17 14:44:26 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_list.h"

void	ft_list_push_front(t_list **begin_list, void *data)
{
	t_list		*list;

	if (*begin_list)
	{
			list = ft_create_elem(data);
			list-> = *begin_list;
			*begin_list = list;
	}
	else
			*begin_list = ft_create_elem(data);
}
