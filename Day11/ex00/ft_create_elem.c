/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_create_elem.c                                   :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/17 12:33:07 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/17 12:36:31 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>
#include "ft_list.h"

t_list		*ft_create_elem(void *data)
{
	t_lsit	*elem;

	elem = (t_list*)malloc(sizeof(t_list));
	if (elem)
	{
		elem->next = 0;
		elem->data = data;
	}
	return (elem);
}
