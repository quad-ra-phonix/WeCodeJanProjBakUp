/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_list_clear.c                                    :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/17 16:08:10 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/17 16:13:38 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>
#include "ft_list.h"

void		ft_list_clear(t_list **begin_list)
{
			t_list	*tmp;
			t_list	*list;

			list = *begin_list;
			tmp = NULL;
			while (list)
			{
					if (list->next)
							tmp = list->next;
					else
							tmp = NULL;
					free(list);
					list = tmp;
			}
}
